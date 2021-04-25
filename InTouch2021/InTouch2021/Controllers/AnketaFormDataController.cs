using InTouch2021.Data;
using InTouch2021.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InTouch2021.Controllers
{
    public class AnketaFormDataController : Controller
    {
        public readonly ApplicationDbContext _db;
        AverageValue avg;
        public static float forOneBlock;
        public static float forSecondBlock;
        public static float forThirdBlock;
        public AnketaFormDataController(ApplicationDbContext db)
        {
            _db = db;
            
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

     

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(AnketaFormDataModel model)
        {
            avg = new AverageValue();
          
            AverageValue.NumberUser++;
            AnketaFormDataModel.CH++;
            forOneBlock = Value_1(model);
            forSecondBlock = Value_2(model);
            forThirdBlock = Value_3(model);
            model.forOneBlock = forOneBlock;
            model.forSecondBlock = forSecondBlock;
            model.forThirdBlock = forThirdBlock;

              _db.Items.Add(model);
               _db.SaveChanges();

              return View();
        }

        [HttpGet]
        public IActionResult Monitor()
        {
            IEnumerable<AnketaFormDataModel> objList = _db.Items;
            return View(objList);
        }

        [HttpGet]
        public IActionResult Submit()
        {
            return View();
        }

        public float Value_1(AnketaFormDataModel model)
        {
            for (int i = 0; i < model.WeightAnswersForSite.Length; i++)
            {
                avg.information.WeightAnswersForSite[i] = model.WeightAnswersForSite[i];
                //avg.information.WeightAnswersForStand[i] = model.WeightAnswersForStand[i];
            }

            for (int i = 0; i < model.WeightAnswersForStand.Length; i++)
            {
                //avg.information.WeightAnswersForSite[i] = model.WeightAnswersForSite[i];
                avg.information.WeightAnswersForStand[i] = model.WeightAnswersForStand[i];
            }

            for (int i = 0; i < model.WeightAnswersForSecond.Length; i++)
            {
                avg.information.WeightForSecondRule[i] = model.WeightAnswersForSecond[i];
            }
            for (int i = 0; i < model.WeightForThirdRuleSite.Length; i++)
            {
                avg.information.WeightForThirdRuleSite[i] = model.WeightForThirdRuleSite[i];
                
            }

            for (int i = 0; i < model.WeightForThirdRuleStand.Length; i++)
            {
                avg.information.WeightForThirdRuleStand[i] = model.WeightForThirdRuleStand[i];
                
            }
            RatingInformation.CH = AnketaFormDataModel.CH;
            return avg.AverageInformation();

        }

        public float Value_2(AnketaFormDataModel model)
        {
            for (int i = 0; i < model.WeightAnswersForOne.Length; i++)
            {
                avg.Invalid.WeightAnswersForOne[i] = model.WeightAnswersForOne[i];
            }
            for (int i = 0; i < model.WeightAnswersForSecond.Length; i++)
            {
                avg.Invalid.WeightAnswersForSecond[i] = model.WeightAnswersForSecond[i];
            }
            for (int i = 0; i < model.WeightAnswersForThird.Length; i++)
            {
                avg.Invalid.WeightAnswersForThird[i] = model.WeightAnswersForThird[i];
            }

            RatingInvalid.CH = AnketaFormDataModel.CH;
            return avg.AverageInvalid();

        }

        public float Value_3(AnketaFormDataModel model)
        {
            for (int i = 0; i < model.WeightAnswersForOne_1.Length; i++)
            {
                avg.service.WeightAnswersForOne[i] = model.WeightAnswersForOne_1[i];
            }
            for (int i = 0; i < model.WeightAnswersForSecond_1.Length; i++)
            {
                avg.service.WeightAnswersForSecond_1[i] = model.WeightAnswersForSecond_1[i];
            }

            RatingService.CH = AnketaFormDataModel.CH;

            return avg.AverageService();

        }
    }

}

