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

        public AuthController(UserDBContext context, AdminDBContext adminContext, IConfiguration configuration, ILogger<AuthController> logger)
        {
            _context = context;
            _configuration = configuration;
            _logger = logger;
            _adminContext = adminContext;
        }


        [HttpPost("login")] // ========================================= Login for users algo go here ==================================================
        public IActionResult Login([FromBody] LoginModel model) // model chua email + pw
        {
            var user = _context.khachhang.SingleOrDefault(u => u.Email == model.Email); // PW HasNoKey in OnModelCreating
            if (user == null)
                return Unauthorized();
            var pass =  _context.Passwords
                .FirstOrDefault(p => p.ID_KhachHang == user.ID_KhachHang);    // Lay bo Password tu database
            if (pass.Hashed != HashPassword(model.Password, pass.salt)) // SS digest cua database voi ket qua hash tu login attempt
            {
                return Unauthorized();
            }
            // var token = _tokenGen.GenerateJwtToken(user); ---- Outdated
            var token = GenerateJwtToken(user.Email, true);
            Response.Headers.Add("Authorization", "Bearer " + token);
            return Ok(new { Token = token });   // Accept response, return OK + token
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
        private string GenerateJwtToken(string input, bool isUser)    // true for user, false for admin
        {
            var jwtSettings = _configuration.GetSection("Jwt");
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
    [ApiController]
    [Route("api/[controller]")]         // =========== For testing purposes only ===============
    public class ServerController : ControllerBase
    {
        [HttpGet("secure")]
        [Authorize(Policy = "ValidJwt")]
        public IActionResult Get()
        {
            var header = Request.Headers["Authorization"].FirstOrDefault();
            if (header == null)
                return BadRequest("Forgot the token dummy");
            var token = header.Substring("Bearer ".Length).Trim();  // get the token exclusively
            return Ok(new { message = token });
        }
    }
}
