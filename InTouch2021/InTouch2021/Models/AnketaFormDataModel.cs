using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace InTouch2021.Models
{
    public class AnketaFormDataModel
    {
        
        [Key]

        public int id { get; set; }

        public float forOneBlock { get; set; }
        public float forSecondBlock { get; set; }
        public float forThirdBlock { get; set; }

        //Число опрошенных
        public static int CH { get; set; }

        //Для перовй диграммы
        [NotMapped]
        [Required]
        public float[] WeightAnswersForSite { get; set; }
        [NotMapped]
        [Required]
        public float[] WeightAnswersForStand { get; set; }
        [NotMapped]
        [Required]
        public float[] WeightForSecondRule { get; set; }
        [NotMapped]
        [Required]
        public float[] WeightForThirdRuleStand { get; set; }
        [NotMapped]
        [Required]
        public float[] WeightForThirdRuleSite { get; set; }


        //public float[] WeightForThirdRuleAll { get; set; }

        //Для второй
        [NotMapped]
        [Required]
        public float[] WeightAnswersForOne { get; set; }
        [NotMapped]
        [Required]
        public float[] WeightAnswersForSecond { get; set; }
        [NotMapped]
        [Required]
        public float[] WeightAnswersForThird { get; set; }


        //Для третьей
        [NotMapped]
        [Required]
        public float[] WeightAnswersForOne_1 { get; set; }
        [NotMapped]
        [Required]
        public float[] WeightAnswersForSecond_1 { get; set; }


        public string isSuccess { get; set; }
        [Required]
        public string chouse { get; set; }
        [Required]
        public string sex { get; set; }
        [Required]
        public string age { get; set; }
        [Required]
        public string directionStudy { get; set; }
        [Required]
        public string studNumber { get; set; }

        [Required]
        public string email { get; set; }
        [Required]
        public string name { get; set; }


    }
}
