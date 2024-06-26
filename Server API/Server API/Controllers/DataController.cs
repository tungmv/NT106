﻿using System.Text.Json.Nodes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Server_API.DBContext;
using Server_API.Models;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Security.Cryptography.Xml;
using Microsoft.EntityFrameworkCore.Internal;
using System.Runtime;
using Microsoft.AspNetCore.Authentication;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Text;


namespace Server_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RouteController : ControllerBase
    {
        private readonly TrainDBContext _context;
        private readonly IConfiguration _configuration;

        public RouteController(TrainDBContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }
        // GET: api/<DataController>
        [HttpPost("FindRoutes")]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<Tram>>> ReturnDest([FromBody] OriginDestination AandB)     // ===== Return the routes that go through A, B =====
        {
            string Origin = AandB.Origin;
            string Destination = AandB.Destination;

            // Simple check
            if (string.IsNullOrEmpty(Origin) || string.IsNullOrEmpty(Destination) || Origin.Contains("string") || Destination.Contains("string")) {
                return BadRequest("Invalid Origin and Destination points. Returning null");
            }

            var throughA = from DiemDi in _context.DiemDi
                           join Tram in _context.Tram on DiemDi.ID_Tram equals Tram.ID_Tram
                           where Tram.TenTram.Equals(Origin)
                           select DiemDi.ID_Tuyen; // Tim cac ID_Tuyen di qua {Origin}

            var throughB = from DiemDi in _context.DiemDi
                           join Tram in _context.Tram on DiemDi.ID_Tram equals Tram.ID_Tram
                           where Tram.TenTram.Equals(Destination)
                           select DiemDi.ID_Tuyen;  // Tim cac ID_Tuyen di qua {Destination}

            var throughAandB = throughA.Intersect(throughB).Distinct();

            var result = new
            {
                routes = throughAandB
            };

            return Ok(result);
        }

        [AllowAnonymous]
        [HttpGet("fetchStation")]
        public async Task<ActionResult<IEnumerable<Tram>>> FetchStation()
        {
            var waypoints = from Tram in _context.Tram
                            select new
                            {
                                Tram.ID_Tram,
                                Tram.TenTram,
                                Tram.Thanhpho,
                                Tram.Tinh
                            };

            var content = waypoints.Distinct().ToList();

            var result = new
            {
                station = content
            };

            return Ok(result);
        }

        [AllowAnonymous]
        [HttpGet("{id}")]

        public async Task<ActionResult<IEnumerable<LichTrinh>>> FindSchedule(string id)
        {
            if (string.IsNullOrEmpty(id) || id.Contains(" "))
                return BadRequest("Invalid ID_Tuyen");

            var query = from LichTrinh in _context.LichTrinh
                        where LichTrinh.ID_Tuyen.Equals(id)
                        select new
                        {
                            LichTrinh.ID_LichTrinh,
                            LichTrinh.ID_Tau,
                            LichTrinh.Gio,
                            LichTrinh.Thu,
                            LichTrinh.Chieu
                        };

            var content = query.Distinct().ToList();
            var result = new
            {
                lichtrinh = content
            };

            return Ok(result);
        }
    }

    [Route("api/[controller]")]
    [ApiController]
    public class TrainController : ControllerBase
    {
        private readonly TrainDBContext _context;
        private IConfiguration _configuration;
        private readonly UserDBContext _userContext;

        public TrainController(TrainDBContext context, IConfiguration configuration, UserDBContext userContext)
        {
            _context = context;
            _configuration = configuration;
            _userContext = userContext;
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult> GetSlots(string id)
        {
            if (string.IsNullOrEmpty(id) || id.Contains(" "))
                return BadRequest("Invalid ID_Tau");

            var queryToa = from tau in _context.Tau
                        join toa in _context.Toa on tau.ID_Tau equals toa.ID_Tau
                        where toa.ID_Toa.Contains(id)
                        select toa.ID_Toa;

            /*var ghe = from ghe in _context.Ghe
                      join toa in _context.Toa on ghe.ID_Toa equals toa.ID_Toa
                      where ghe.ID_Toa.Equals(queryToa.ID_Toa)*/

            var query = await _context.Toa
                .Where(toa => queryToa.Contains(toa.ID_Toa))
                .Select(toa => new
                {
                    ID_Toa = toa.ID_Toa,
                    Ghe = toa.Ghe.Where(ghe => ghe.KhaDung != 0).Select(ghe => ghe.ID_Ghe.ToString()).ToList(),
                    Phong = toa.Phong.Select(phong => new {
                        ID_Phong = phong.ID_Phong,
                        Giuong = phong.Giuong.Where(giuong => giuong.KhaDung != 0).Select(giuong => giuong.ID_Giuong.ToString()).ToList()
                    }).ToList()
                }
                ).ToListAsync();

            var queryLop = _context.Tau
                .Select(tau => tau.Lop);

            var result = new
            {
                Class = queryLop.ToString(),
                Cars = query
            };

            return Ok(result);
        }

        [AllowAnonymous]
        [HttpGet("car/{id}")]
        public async Task<ActionResult> GetCar(string id)
        {
            if (string.IsNullOrEmpty(id) || id.Contains(" "))
                return BadRequest("Invalid ID_Toa");

            var query = await _context.Toa
                .Where(toa => toa.ID_Toa.Contains(id))
                .Select(toa => new
                {
                    ID_Toa = toa.ID_Toa,
                    Ghe = toa.Ghe.Where(ghe => ghe.KhaDung != 0).Select(ghe => ghe.ID_Ghe.ToString()).ToList(),
                    Phong = toa.Phong.Select(phong => new {
                        ID_Phong = phong.ID_Phong,
                        Giuong = phong.Giuong.Where(giuong => giuong.KhaDung != 0).Select(giuong => giuong.ID_Giuong.ToString()).ToList()
                    }).ToList()
                }
                ).ToListAsync();

            var response = new
            {
                response = query,
            };

            return Ok(response);
        }

        [AllowAnonymous]
        [HttpPost("GenerateTicket")]
        public async Task<ActionResult> ConfirmTicket([FromBody] Ticket ticket)
        {
            if (ticket == null)
                return BadRequest("Empty ticket!");
            if (string.IsNullOrEmpty(ticket.ID_KhachHang) || string.IsNullOrEmpty(ticket.ID_LichTrinh) || string.IsNullOrEmpty(ticket.ID_GiuongorGhe) || string.IsNullOrEmpty(ticket.HoTen) || string.IsNullOrEmpty(ticket.ID_PhongorToa))
                return BadRequest("Missing properties");
            if (ticket.isVeNam < 0 || ticket.isVeNam > 1)
                return BadRequest("Invalid isVeNam property, set 0 for VeNgoi, 1 for VeNam");
            if (ticket.NamSinh > DateTime.Now.Year)
                return BadRequest("Invalid ticket holder's age");

            var targetDay = await _context.LichTrinh
                            .Where (lt => lt.ID_LichTrinh ==  ticket.ID_LichTrinh)
                           .Select(lt => new {thu = lt.Thu.ToString(), gio = lt.Gio }).FirstOrDefaultAsync();

            int daysDifference;
            DateTime targetDateTime;
            if (targetDay.thu != null)      // Danh cho cac lich trinh hang tuan
            {
                daysDifference = ((int)Enum.Parse<DayOfWeek>(targetDay.thu) - (int)DateTime.Now.DayOfWeek + 7) % 7;
                targetDateTime = DateTime.Now.AddDays(daysDifference).Add(targetDay.gio);
            }
            else
                targetDateTime = DateTime.Now.AddDays(7);
            if (ticket.isVeNam == 1)        // =========== For VeNam
            {

                // Check if exists a ticket of the same properties and has not yet expired:
                var existQuery = await _context.VeNam 
                                .Where(vn => vn.ID_Giuong == ticket.ID_GiuongorGhe && vn.ID_Phong == ticket.ID_PhongorToa && vn.ExpireDate > DateTime.Now)
                                .Select(vn => new {id = vn.ID_VeNam }).FirstOrDefaultAsync();
                if (existQuery != null)
                    return BadRequest("A ticket of the same properties is booked but not expired yet or the properties of the ticket don't exist.");

                // Get the train's class and the distance 
                var phongQuery = from phong in _context.Phong
                                 where phong.ID_Phong.Equals(ticket.ID_PhongorToa)
                                 select phong.ID_Toa;
                // Check if the properties set is valid
                // Then we get id_tau
                var validateSubQuery2 = from tau in _context.Tau
                                        join toa in _context.Toa on tau.ID_Tau equals toa.ID_Tau
                                        where toa.ID_Toa.Equals(phongQuery.FirstOrDefault())
                                        select toa.ID_Tau;

                // Explanation: a valid ticket is a ticket such that its id_lichtrinh and id_tau matches so we check if there exists a lichtrinh that satisfy this condition
                var validateQuery = await _context.LichTrinh
                                .Where(lt => lt.ID_LichTrinh == ticket.ID_LichTrinh && lt.ID_Tau == validateSubQuery2.FirstOrDefault())
                                .Select(lt => lt.ID_LichTrinh).FirstOrDefaultAsync();

                if (validateQuery == null)
                {
                    var error = new
                    {
                        msg = "The given train does not operate on the given schedule ID.",
                        id_tau = validateSubQuery2.FirstOrDefault(),
                        id_lichtrinh = ticket.ID_LichTrinh,
                    };
                    return BadRequest(error);
                }

                var classQuery = from tau in _context.Tau
                                 join toa in _context.Toa on tau.ID_Tau equals toa.ID_Tau
                                 where toa.ID_Toa.Equals(phongQuery.FirstOrDefault())
                                 select tau.Lop;

                var classString = classQuery.FirstOrDefault();

                double multiplier = 0;
                if (classString == "C")
                    multiplier = 1;
                else if (classString == "B")
                    multiplier = 1.5;
                else if (classString == "A")
                    multiplier = 2.0;

                //Get ID_Tuyen
                var tuyenQuery = from lichtrinh in _context.LichTrinh
                                 where lichtrinh.ID_LichTrinh.Equals(ticket.ID_LichTrinh)
                                 select lichtrinh.ID_Tuyen;

                // Get the total distance
                var originQuery = from tram in _context.Tram
                                  where tram.TenTram.Equals(ticket.XuatPhat)
                                  select tram.ID_Tram;

                var destinationQuery = from tram in _context.Tram
                                       where tram.TenTram.Equals(ticket.DiemDen)
                                       select tram.ID_Tram;

                var originMilestone = from diemdi in _context.DiemDi
                                      where diemdi.ID_Tram.Equals(originQuery.FirstOrDefault()) && diemdi.ID_Tuyen.Equals(tuyenQuery.FirstOrDefault())
                                      select diemdi.KhoangCach;
                float originFloat = originMilestone.FirstOrDefault();

                var destinationMilestone = from diemdi in _context.DiemDi
                                           where diemdi.ID_Tram.Equals(destinationQuery.FirstOrDefault()) && diemdi.ID_Tuyen.Equals(tuyenQuery.FirstOrDefault())
                                           select diemdi.KhoangCach;
                float destinationFloat = destinationMilestone.FirstOrDefault();

                // If such condition fails or the chosen LichTrinh has a different 'Chieu', throws a bad request response.
                float dist = destinationFloat - originFloat;
                var chieuQuery = from lt in _context.LichTrinh
                                 where lt.ID_LichTrinh == ticket.ID_LichTrinh
                                 select lt.Chieu;
                if (chieuQuery.FirstOrDefault() == 1 && dist > 0 || chieuQuery.FirstOrDefault() == 0 && dist < 0)
                    return BadRequest("The order of Departure and Desination is wrong. Consider reverse it and try again.");

                // After checking, overwrite dist with its effective value
                dist = Math.Abs(dist);
                // Fair price configuration:
                double Fare = dist * 250 + 50000;    // 1000 vnd/km * dist (km) + base fare
                Fare *= multiplier; // nhan voi he so class cua tau: hang thuong/thuong gia/first class vv
                var hashPayload = $"{ticket.ID_GiuongorGhe}|{ticket.ID_PhongorToa}|{ticket.HoTen}|{ticket.NamSinh}";
                var hashDigest = new string("");
                using (SHA256 sha256 = SHA256.Create())
                {
                    byte[] hashByte = sha256.ComputeHash(Encoding.UTF8.GetBytes(hashPayload));
                    hashDigest = Convert.ToHexString(hashByte);
                }

                var input = new VeNam
                {
                    ID_VeNam = hashDigest,
                    ID_LichTrinh = ticket.ID_LichTrinh,
                    ID_Giuong = ticket.ID_GiuongorGhe,
                    ID_Phong = ticket.ID_PhongorToa,
                    HoTen = ticket.HoTen,
                    NamSinh = ticket.NamSinh,
                    ExpireDate = targetDateTime,
                    DonGia = (int)Fare,
                    XuatPhat = ticket.XuatPhat,
                    DiemDen = ticket.DiemDen
                };

                _context.VeNam.Add(input);

                // Also set KhaDung of the booked bed to 0.
                var booked_bed = _context.Giuong.SingleOrDefault(g => g.ID_Giuong == ticket.ID_GiuongorGhe && g.ID_Phong == ticket.ID_PhongorToa);
                booked_bed.KhaDung = 0;

                await _context.SaveChangesAsync();
                _userContext.LichSuDatVeNam.Add(new LichSuDatVeNam
                {
                    ID_KhachHang = ticket.ID_KhachHang,
                    ID_VeNam = hashDigest
                });

                await _userContext.SaveChangesAsync();

                var response = new
                {
                    Success = true,
                    ID_Ve = hashDigest,
                    ID_Giuong = ticket.ID_GiuongorGhe,
                    ID_Phong = ticket.ID_PhongorToa,
                    ID_Toa = phongQuery.FirstOrDefault(),
                    HoTen = ticket.HoTen,
                    NamSinh = ticket.NamSinh,
                    DonGia = (int)Fare,
                    XuatPhat = ticket.XuatPhat,
                    DiemDen = ticket.DiemDen,
                    ExpireDay = input.ExpireDate.Date.ToString("dd-MM-yyyy"),
                    ExpireTime = input.ExpireDate.ToString("H-mm-ss")
                };

                return Ok(response);
            }
            else
            {                              // =========== For VeNgoi ============

                // Check if exists a ticket of the same properties and has not yet expired:
                var existQuery = await _context.VeNgoi
                                .Where(vn => vn.ID_Ghe == ticket.ID_GiuongorGhe && vn.ID_Toa == ticket.ID_PhongorToa && vn.ExpireDate > DateTime.Now)
                                .Select(vn => new { id = vn.ID_VeNgoi }).FirstOrDefaultAsync();
                if (existQuery != null)
                    return BadRequest("A ticket of the same properties is booked but not expired yet or the properties of the ticket don't exist.");

                // Check if the properties set is valid
                // Get id_tau first
                var validateSubQuery = from tau in _context.Tau
                                        join toa in _context.Toa on tau.ID_Tau equals toa.ID_Tau
                                        where toa.ID_Toa.Equals(ticket.ID_PhongorToa)
                                        select toa.ID_Tau.ToString();

                // Explanation: a valid ticket is a ticket such that its id_lichtrinh and id_tau matches so we check if there exists a lichtrinh that satisfy this condition
                var validateQuery = await _context.LichTrinh
                                .Where(lt => lt.ID_LichTrinh == ticket.ID_LichTrinh && lt.ID_Tau == validateSubQuery.FirstOrDefault())
                                .Select(lt => lt.ID_LichTrinh).FirstOrDefaultAsync();

                if (validateQuery == null)
                {
                    var error = new
                    {
                        msg = "The given train does not operate on the given schedule ID.",
                        id_tau = validateSubQuery.FirstOrDefault(),
                        id_lichtrinh = ticket.ID_LichTrinh,
                    };
                    return BadRequest(error);
                }

                // Get the train's class and the distance 
                var classQuery = from tau in _context.Tau
                                 join toa in _context.Toa on tau.ID_Tau equals toa.ID_Tau
                                 where toa.ID_Toa.Equals(ticket.ID_PhongorToa)
                                 select tau.Lop;

                var classString = classQuery.FirstOrDefault();

                double multiplier = 0;
                if (classString == "C")
                    multiplier = 1;
                else if (classString == "B")
                    multiplier = 1.5;
                else if (classString == "A")
                    multiplier = 2.0;

                //Get ID_Tuyen
                var tuyenQuery = from lichtrinh in _context.LichTrinh
                                 where lichtrinh.ID_LichTrinh.Equals(ticket.ID_LichTrinh)
                                 select lichtrinh.ID_Tuyen;

                // Get the total distance
                var originQuery = from tram in _context.Tram
                                  where tram.TenTram.Equals(ticket.XuatPhat)
                                  select tram.ID_Tram;

                var destinationQuery = from tram in _context.Tram
                                       where tram.TenTram.Equals(ticket.DiemDen)
                                       select tram.ID_Tram;

                var originMilestone = from diemdi in _context.DiemDi
                                      where diemdi.ID_Tram.Equals(originQuery.FirstOrDefault()) && diemdi.ID_Tuyen.Equals(tuyenQuery.FirstOrDefault())
                                      select diemdi.KhoangCach;
                float originFloat = originMilestone.FirstOrDefault();

                var destinationMilestone = from diemdi in _context.DiemDi
                                           where diemdi.ID_Tram.Equals(destinationQuery.FirstOrDefault()) && diemdi.ID_Tuyen.Equals(tuyenQuery.FirstOrDefault())
                                           select diemdi.KhoangCach;
                float destinationFloat = destinationMilestone.FirstOrDefault();
                // Before proceeding, we check if the 'Chieu' of the LichTrinh matches the order of Origin and Destination stations. dist must hold negative if Chieu is 1 and vice versa.
                // If such condition fails or the chosen LichTrinh has a different 'Chieu', throws a bad request response.
                float dist = destinationFloat - originFloat;
                var chieuQuery = from lt in _context.LichTrinh
                                 where lt.ID_LichTrinh == ticket.ID_LichTrinh
                                 select lt.Chieu;
                if (chieuQuery.FirstOrDefault() == 1 && dist > 0 || chieuQuery.FirstOrDefault() == 0 && dist < 0)
                    return BadRequest("The order of Departure and Desination is wrong. Consider reverse it and try again.");
                
                // After checking, overwrite dist with its effective value
                dist = Math.Abs(dist);

                // Fair price configuration:
                double Fare = dist * 250 + 25000;    // 250 vnd/km * dist (km) + base fare
                Fare *= multiplier; // nhan voi he so class cua tau: hang thuong/thuong gia/first class vv

                var hashPayload = $"{ticket.ID_GiuongorGhe}|{ticket.ID_PhongorToa}|{ticket.HoTen}|{ticket.NamSinh}";
                var hashDigest = new string("");
                using (SHA256 sha256 = SHA256.Create())
                {
                    byte[] hashByte = sha256.ComputeHash(Encoding.UTF8.GetBytes(hashPayload));
                    hashDigest = Convert.ToHexString(hashByte);
                }

                var input = new VeNgoi
                {
                    ID_VeNgoi = hashDigest,
                    ID_LichTrinh = ticket.ID_LichTrinh,
                    ID_Toa = ticket.ID_PhongorToa,
                    ID_Ghe = ticket.ID_GiuongorGhe,
                    HoTen = ticket.HoTen,
                    NamSinh = ticket.NamSinh,
                    ExpireDate = targetDateTime,
                    DonGia = (int)Fare,
                    XuatPhat = ticket.XuatPhat,
                    DiemDen = ticket.DiemDen
                };

                _context.VeNgoi.Add(input);

                // Also set KhaDung of the booked bed to 0.
                var booked_seat = _context.Ghe.SingleOrDefault(g => g.ID_Ghe == ticket.ID_GiuongorGhe && g.ID_Toa == ticket.ID_PhongorToa);
                booked_seat.KhaDung = 0;

                await _context.SaveChangesAsync();

                _userContext.LichSuDatVeNgoi.Add(new LichSuDatVeNgoi
                {
                    ID_KhachHang = ticket.ID_KhachHang,
                    ID_VeNgoi = hashDigest
                });

                await _userContext.SaveChangesAsync();

                var response = new
                {
                    Success = true,
                    ID_Ve = hashDigest,
                    ID_Toa = ticket.ID_PhongorToa,
                    ID_Ghe = ticket.ID_GiuongorGhe,
                    HoTen = ticket.HoTen,
                    NamSinh = ticket.NamSinh,
                    DonGia = (int)Fare,
                    XuatPhat = ticket.XuatPhat,
                    DiemDen = ticket.DiemDen,
                    ExpireDay = input.ExpireDate.Date.ToString("dd-MM-yyyy"),
                    ExpireTime = input.ExpireDate.ToString("H-mm-ss")
                };

                return Ok(response);
            }
        }
    }


    public class OriginDestination
    {
        public string Destination { get; set; }
        public string Origin { get; set; }
    }

    public class Ticket
    {
        public string ID_KhachHang { get; set; }
        public int isVeNam { get; set; } // 0 = Ngoi, 1 = Nam
        public string ID_LichTrinh { get; set; }
        public string ID_PhongorToa { get; set; }
        public string ID_GiuongorGhe { get; set; }   // Hoac la cho nam hoac la cho ngoi
        public string HoTen { get; set; }
        public int NamSinh { get; set; }
        public string XuatPhat { get; set; } // ten tram vd: Ga Hoan Kiem
        public string DiemDen { get; set; } // ten tram
    }

    public class BedAndSeatUpdate : IHostedService, IDisposable     // This will be run every hour to refresh KhaDung of Ghe and Giuong
    {
        private readonly IServiceProvider _services;
        private ILogger<BedAndSeatUpdate> _logger;
        private Timer _timer;

        public BedAndSeatUpdate(IServiceProvider services, ILogger<BedAndSeatUpdate> logger)
        {
            _services = services;
            _logger = logger;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Bed and Seats are being refreshed.");
            _timer = new System.Threading.Timer(UpdateDataAsync, null, TimeSpan.Zero, TimeSpan.FromHours(1));
            return Task.CompletedTask;
        }

        private async void UpdateDataAsync(object state)
        {
            using (var scope = _services.CreateScope()) // Create a scope to add database for updating
            {
                var _context = scope.ServiceProvider.GetRequiredService<TrainDBContext>();
                // for seats
                var seattickets = from vngoi in _context.VeNgoi
                                  where vngoi.ExpireDate < DateTime.Now
                                  select new
                                  {
                                      id_ghe = vngoi.ID_Ghe,
                                      id_toa = vngoi.ID_Toa
                                  };
                foreach (var ticket in seattickets)
                {
                    var seatQuery = from ghe in _context.Ghe
                                    where ghe.ID_Ghe.Equals(ticket.id_ghe) && ghe.ID_Toa.Equals(ticket.id_toa)
                                    select ghe;
                    seatQuery.FirstOrDefault().KhaDung = 1;
                }

                // for beds
                var bedtickets = from vnam in _context.VeNam
                                 where vnam.ExpireDate < DateTime.Now
                                 select new
                                 {
                                     id_giuong = vnam.ID_Giuong,
                                     id_phong = vnam.ID_Phong
                                 };
                foreach (var ticket in bedtickets)
                {
                    var bedQuery = from giuong in _context.Giuong
                                   where giuong.ID_Giuong.Equals(ticket.id_giuong) && giuong.ID_Phong.Equals(ticket.id_phong)
                                   select giuong;
                    bedQuery.FirstOrDefault().KhaDung = 1;
                }

                // commit changes to database
                await _context.SaveChangesAsync();
            }
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("The update is stopping.");
            _timer?.Change(Timeout.Infinite, 0);
            return Task.CompletedTask;
        }

        public void Dispose()
        {
            _timer?.Dispose();
        }
    }
}
