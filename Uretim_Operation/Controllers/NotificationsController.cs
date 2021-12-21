using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Uretim_Operation.Data;
using Uretim_Operation.Models;

namespace Uretim_Operation.Controllers
{
    public class NotificationsController : Controller
    {

        private readonly UOBContext _context;

        public NotificationsController(UOBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
           return View(_context.Notifications.ToList());
        }

        public JsonResult CreateNotification(int _IsNo, DateTime _BaslangicTarihi, DateTime _BitisTarihi, TimeSpan _ToplamSure, string _Statu, string _DurusNedeni)
        {
            
            Notifications notifications = new Notifications();
            notifications.IsNo = _IsNo;
            notifications.BaslangicTarihi = _BaslangicTarihi;
            notifications.BitisTarihi = _BitisTarihi;
            var span = _BitisTarihi.Subtract(_BaslangicTarihi);
            var minute = span.TotalMinutes.ToString();
            notifications.ToplamSure = span;
            notifications.Statu = _Statu;
            var m = Int32.Parse(minute);

            if (m > 0 && m <=15 )
            {
                notifications.DurusNedeni = "Çay Molası";
            }
            else if (m>15 && m<=30)
            {
                notifications.DurusNedeni = "Yemek Molası";
            }
            

            _context.Add(notifications);
            var result = _context.SaveChanges();

            return Json(result);
        }

    }
}
