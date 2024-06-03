using System.Security.Cryptography;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Tokens;
using Server_API.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.Extensions.Logging;
using System.Linq.Expressions;
using Server_API.DBContext;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json.Linq;
using Microsoft.EntityFrameworkCore.Metadata.Internal;


namespace Server_API.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ILogger<AuthController> _logger;
        private readonly UserDBContext _context;
        private readonly IConfiguration _configuration;
        private readonly AdminDBContext _adminContext;
        private readonly TrainDBContext _trainContext;

        public AuthController(UserDBContext context, AdminDBContext adminContext, IConfiguration configuration, ILogger<AuthController> logger)
        {
            _context = context;
            _configuration = configuration;
            _logger = logger;
            _adminContext = adminContext;
        }


        [HttpPost("login")] // ========================================= Login ==================================================
        public IActionResult Login([FromBody] LoginModel model)
        {
            var user = _context.khachhang.SingleOrDefault(u => u.Email == model.Email);
            if (user == null)
                return Unauthorized();

            var pass =  _context.Passwords
                .FirstOrDefault(p => p.ID_KhachHang == user.ID_KhachHang);

            if (pass.Hashed != HashPassword(model.Password, pass.salt))
                return Unauthorized();

            var token = GenerateJwtToken(user.Email, true);
            Response.Headers.Add("Authorization", "Bearer " + token);

            return Ok(new { Token = token, ID = user.ID_KhachHang });   // Accept, return OK + token
        }

        private string HashPassword(string password, string salt)
        {
            using (var sha256 = SHA256.Create())
            {
                var salted = password + salt;
                var saltedBytes = Encoding.UTF8.GetBytes(salted);
                var hashBytes = sha256.ComputeHash(saltedBytes);
                return Convert.ToHexString(hashBytes);
            }
        }
        private string GenerateJwtToken(string input, bool isUser)
        {
            var jwtSettings = _configuration.GetSection("JwtSettings");
            var key = Encoding.ASCII.GetBytes(jwtSettings["Key"]);
            var tokenHandler = new JwtSecurityTokenHandler();
            if (isUser)
            {
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new[]
                    {
                new Claim(ClaimTypes.Email,input)
                }),
                    Expires = DateTime.UtcNow.AddDays(1),  // ====== Expire duration ======
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                };
                var token = tokenHandler.CreateToken(tokenDescriptor);
                return tokenHandler.WriteToken(token);
            }
            else
            {
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new[]
                    {
                new Claim(ClaimTypes.NameIdentifier, input)
                }),
                    Expires = DateTime.UtcNow.AddDays(1),  // ====== Expire duration ======
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                };
                var token = tokenHandler.CreateToken(tokenDescriptor);
                return tokenHandler.WriteToken(token);
            }

        }

        // ========================================================== Admin authenticator go here =============================================================
        [HttpPost("adminlogin")]
        public IActionResult AdminLogin([FromBody] Admin admin)
        {
            var queryResult = _adminContext.Admin.SingleOrDefault(a => a.ID == admin.Id);   // fetch the matching admin entity with the ID from the log in attempt
            if (queryResult == null)
                return Unauthorized();
            var hashedInput = HashPassword(admin.Password, queryResult.Salt);
            if (hashedInput != queryResult.Hashed)
            {
                return Unauthorized();
            }
            var token = GenerateJwtToken(admin.Id, false);
            Response.Headers.Add("Authorization", "Bearer " + token);
            return Ok(new { Token = token });   // return jwt token based on the admin's ID
        }
    }
    public class LoginModel
    {
        public string Email { get; set; }
        public string Password { get; set; }  // Login password o dang plaintext
    }

    public class Admin
    {
        public string Id { get; set; }
        public string Password { get; set; }
    }
    //[ApiController]
    //[Route("api/[controller]")]         // =========== For testing ===============
    //public class ServerController : ControllerBase
    //{
    //    [HttpGet("test")]
    //    [Authorize(Policy = "ValidJwt")]
    //    public IActionResult Get()
    //    {
    //        var header = Request.Headers["Authorization"].FirstOrDefault();

    //        if (header == null)
    //            return BadRequest();

    //        //var token = header.Substring("Bearer ".Length).Trim();  // get the token
    //        return Ok();
    //    }
    //}

    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly TrainDBContext _trainContext;
        private readonly UserDBContext _context;
        private readonly IConfiguration _configuration;
        public UserController(TrainDBContext trainContext, UserDBContext context, IConfiguration configuration)
        {
            _trainContext = trainContext;
            _context = context;
            _configuration = configuration;
        }

        //[Authorize(AuthenticationSchemes = "Bearer")]
        [HttpGet("ticketHistory/{email}")]
        public async Task<ActionResult> UserHistoryQuery(string email)
        {
            // Validate token
            string token = Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();    // Exclude 'bearer' prefix to get the token itself

            if (ValidateJwtToken(token) == 0)
                return Unauthorized("No token detected. Are you missing the bearer token?");

            else if (ValidateJwtToken(token) == 2)
                return BadRequest("User email does not exist.");

            else if (ValidateJwtToken(token) == 3)
                return BadRequest("Expired token. Consider refresh the token");

            else if (ValidateJwtToken(token) == 4)
                return BadRequest("Invalid token");

            else if (ValidateJwtToken(token) == 1)
            {
                if (string.IsNullOrEmpty(email))
                    return BadRequest("Missing user's Email");

                if (email.Contains(" ") || !email.Contains("@"))
                    return BadRequest("Invalid user's Email");

                var queryNam = from kh in _context.khachhang
                               join ls in _context.LichSuDatVeNam on kh.ID_KhachHang equals ls.ID_KhachHang
                               where kh.Email == email
                               select new
                               {
                                   ID_VeNam = ls.ID_VeNam,
                               };

                var id_veNam = queryNam.ToString().ToList();
                var resultVeNam = from venam in _trainContext.VeNam
                                  where venam.ID_VeNam.Equals(id_veNam)
                                  select new
                                  {
                                      ID_VeNam = venam.ID_VeNam,
                                      ID_LichTrinh = venam.ID_LichTrinh,
                                      ID_Giuong = venam.ID_Giuong,
                                      ID_Phong = venam.ID_Phong,
                                      DonGia = venam.DonGia,
                                      HoTen = venam.HoTen,
                                      NamSinh = venam.NamSinh
                                  };

                var queryNgoi = from kh in _context.khachhang
                                join ls in _context.LichSuDatVeNgoi on kh.ID_KhachHang equals ls.ID_KhachHang
                                where kh.ID_KhachHang == email
                                select new
                                {
                                    ID_VeNam = ls.ID_VeNgoi,
                                };

                var id_veNgoi = queryNam.ToString().ToList();
                var resultVeNgoi = from vengoi in _trainContext.VeNgoi
                                   where vengoi.ID_VeNgoi.Equals(id_veNgoi)
                                   select new
                                   {
                                       ID_VeNam = vengoi.ID_VeNgoi,
                                       ID_LichTrinh = vengoi.ID_LichTrinh,
                                       ID_Giuong = vengoi.ID_Ghe,
                                       DonGia = vengoi.DonGia,
                                       HoTen = vengoi.HoTen,
                                       NamSinh = vengoi.NamSinh
                                   };

                var result = new
                {
                    email = email,
                    veNgoi = queryNgoi,
                    veNam = queryNam
                };

                return Ok(result);
            }
            else
                return StatusCode(StatusCodes.Status500InternalServerError, "Oops! Server is down");
        }

        [HttpPost("createAccount")]
        [AllowAnonymous]
        public async Task<ActionResult> CreateAccount([FromBody] CreateAccount input)
        {
            var check_exist = _context.khachhang
                .Where(e => e.Email.Equals(input.Email))
                .Count();
            if (check_exist != 0)
                return BadRequest("Email already exists.");
            else
            {
                string hashDigest = new string("");
                string hashID = new string("");
                using (SHA256 sha256 = SHA256.Create())
                {
                    byte[] hashByte = sha256.ComputeHash(Encoding.UTF8.GetBytes(input.HoTen + input.Email));
                    hashID = Convert.ToBase64String(hashByte);
                    hashByte = sha256.ComputeHash(Encoding.UTF8.GetBytes(input.Password + hashID));   // hash ID là salt
                    hashDigest = Convert.ToHexString(hashByte);
                }

                var handler = new User
                {
                    Email = input.Email,
                    HoTen = input.HoTen,
                    NamSinh = input.NamSinh,
                    NgayTao = DateTime.Now,
                    ID_KhachHang = hashID
                };
                _context.khachhang.Add(handler);

                var passHandler = new PW
                {
                    ID_KhachHang = handler.ID_KhachHang,
                    Hashed = hashDigest,
                    salt = hashID
                };
                _context.Passwords.Add(passHandler);

                await _context.SaveChangesAsync();

                var result = new
                {
                    Email = input.Email,
                    HoTen = input.HoTen,
                    ID_KhachHang = hashID
                };

                return Ok(result);
            }
        }

        [HttpGet("details/{email}")]
        public async Task<ActionResult> GetUserDetails(string email)
        {
            // Validate token
            string token = Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();    // Exclude 'bearer' prefix to get the token itself

            if (ValidateJwtToken(token) == 0)
                return Unauthorized("No token detected. Are you missing the bearer token?");

            else if (ValidateJwtToken(token) == 2)
                return BadRequest("User email does not exist.");

            else if (ValidateJwtToken(token) == 3)
                return BadRequest("Expired token. Consider refresh the token");

            else if (ValidateJwtToken(token) == 4)
                return BadRequest("Invalid token");

            else if (ValidateJwtToken(token) == 1)
            {

                var query = from user in _context.khachhang
                            where user.Email == email
                            select new { id = user.ID_KhachHang, email = user.Email, HoTen = user.HoTen, NamSinh = user.NamSinh, NgayTao = user.NgayTao.Date.ToString("dd-MM-yyyy H-mm-ss") };

                return Ok(query.FirstOrDefault());
            }

            else
                return StatusCode(StatusCodes.Status500InternalServerError, "Oops! Server is down");
        }

        private int ValidateJwtToken(string token)
        {
            if (string.IsNullOrEmpty(token))    // Token does not exist, returns 0
                return 0;

            var handler = new JwtSecurityTokenHandler();
            var jwtToken = handler.ReadJwtToken(token); // Read the token
            var email = jwtToken.Claims.FirstOrDefault(claim => claim.Type == ClaimTypes.NameIdentifier)?.Value;

            var challengeQuery1 = from user in _context.khachhang
                                  where user.Email.Equals(email)
                                  select user.ID_KhachHang;
            if (challengeQuery1 == null)        // Email does not exist, returns 2
                return 2;

            var exp = jwtToken.Claims.FirstOrDefault(exp => exp.Type == Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames.Exp)?.Value;
            if (exp != null && long.TryParse(exp, out long expValue))   // exp time in json is a long value formatted as string, so we convert it
            {
                var expTime = DateTimeOffset.FromUnixTimeSeconds(expValue);    // convert jwt expiration time (long) to DateTime type
                if (expTime < DateTime.UtcNow)
                    return 3;
            }
            // actual validation begins, still buggy so this will be wrapped with a try-catch
            try
            {
                var validationParameters = new TokenValidationParameters    // validation parameters (must match program.cs)
                {
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_configuration["JwtSettings:Key"]))
                };

                var principal = handler.ValidateToken(token, validationParameters, out SecurityToken validatedToken);
                if (principal == null)                                      // token did not pass the built in validation, returns 4
                    return 4;
                return 1;
            }
            catch (SecurityTokenException) {
                return 4;
            }
            catch (Exception ex)
            {
                return -1;
            }

        }
    }

    public class CreateAccount
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string HoTen { get; set; }
        public int NamSinh {  get; set; }        
    }
}
