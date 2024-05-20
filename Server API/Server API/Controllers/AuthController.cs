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

        public AuthController(UserDBContext context, IConfiguration configuration, ILogger<AuthController> logger)
        {
            _context = context;
            _configuration = configuration;
            _logger = logger;

        }


        [HttpPost("login")] // ===== Login algo go here =====
        public IActionResult Login([FromBody] LoginModel model) // model chua email + pw
        {
            var user = _context.khachhang.SingleOrDefault(u => u.Email == model.Email); // PW HasNoKey in OnModelCreating
            if (user == null)
                return Unauthorized();
            var pass =  _context.Passwords
                .FirstOrDefault(p => p.ID_KhachHang == user.ID_KhachHang);    // Lay bo Password tu database
            if (pass.Hashed != HashPassword(model.Raw, pass.salt)) // SS digest cua database voi ket qua hash tu login attempt
            {
                return Unauthorized();
            }
            // var token = _tokenGen.GenerateJwtToken(user); ---- Outdated
            var token = GenerateJwtToken(user.Email);
            return Ok(token);   // Accept response, return OK + token
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
        private string GenerateJwtToken(string Email)
        {
            var jwtSettings = _configuration.GetSection("Jwt");
            var key = Encoding.ASCII.GetBytes(jwtSettings["Key"]);
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                new Claim(ClaimTypes.Email, Email)
            }),
                Expires = DateTime.UtcNow.AddHours(1),  // ====== Expire duration ======
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)  // Algo for the token (SHA256)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
    public class LoginModel
    {
        public string Email { get; set; }
        public string Raw { get; set; }  // Login password o dang plaintext
    }

    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class ServerController : ControllerBase
    {
        [HttpGet("secure")]
        public IActionResult Get()
        {
            return Ok(new { message = "This is a protected endpoint" });
        }
    }
}
