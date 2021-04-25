using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using InTouch2021.Models;
using InTouch2021.Data;

namespace InTouch2021.Controllers
{
    public class FeedBackController : Controller
    {
        public readonly ApplicationDbContext _db;

        public FeedBackController(ApplicationDbContext db)
        {
            _db = db;

        }

        public IActionResult FeedBack()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SubmitAsync(FeedBackModel obj)
        {
            
            EmailService emailService = new EmailService();
            await emailService.SendEmailAsync("intouch2021@mail.ru", $"Тема:письмо {obj.Value} ",$"{obj.name}\n " +
                $"номер телефона: {obj.phoneNumber}\n " +$"электронная почта {obj.email}" + $" номер студенческого: {obj.studNumber}\n " + $"Сообщение: {obj.message}" );


            _db.FeedBackItems.Add(obj);
            _db.SaveChanges();

            return View();
        }

        [HttpGet]
        public IActionResult UserManager()
        {
            IEnumerable<FeedBackModel> objList = _db.FeedBackItems;
            return View(objList);
        }

        [HttpGet]
        public IActionResult Manager()
        {
            IEnumerable<FeedBackModel> objList = _db.FeedBackItems;
            return View(objList);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {

            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _db.FeedBackItems.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);

        }

        [HttpPost]

        public IActionResult postDelete(int? id)
        {
        

            var obj = _db.FeedBackItems.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.FeedBackItems.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Manager");

        }

        [HttpGet]

        public IActionResult Update(int? id)
        {


            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _db.FeedBackItems.Find(id);

            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);

        }

        [HttpPost]

        public IActionResult Update(FeedBackModel obj)
        {


            if (ModelState.IsValid)
            {
                _db.FeedBackItems.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Manager");
            }

            return View(obj);

        }
    }
}
