using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using InTouch2021.Models;

namespace InTouch2021.Controllers
{
    public class FeedBackController : Controller
    {
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
            return View();
        }
    }
}
