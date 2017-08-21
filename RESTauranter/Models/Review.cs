using System;
using System.ComponentModel.DataAnnotations;

namespace RESTauranter.Models
{
    public class Review : BaseEntity
    {
        public int ReviewId {get;set;}

        [Required]
        [Display(Name="Reviewer")]
        public string Reviewer {get; set;}

        [Required]
        [Display(Name="Restaurant")]
        public string Restaurant {get;set;}

        [Required]
        [Display(Name="Content")]
        [MinLength(10)]
        public string Content {get;set;}

        [Required]
        [Range(0,5)]
        [Display(Name="Stars")]
        public int Stars {get;set;}

        [Required]
        [Display(Name="Visit Date")]
        public DateTime VisitDate {get;set;}
        public DateTime created_at {get;set;}
        public DateTime updated_at {get;set;}

    }
}