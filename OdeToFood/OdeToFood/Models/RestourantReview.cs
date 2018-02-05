using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OdeToFood.Models
{
	public class RestourantReview:IValidatableObject
	{
		public int Id { get; set; }

		[Range(0,10)]
		public float Rating { get; set; }

		[StringLength(1024)]
		[Required]
		public string Body { get; set; }

		[StringLength(64)]
		[Display(Name = "User name")]
		[DisplayFormat(NullDisplayText = "Anonymous")]
		public string RatedBy { get; set; }
		public int RestourantId { get; set; }

		public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
		{
			//if (Rating < 5 && RestourantId == 9) Rating = 5;
			if (Rating < 5 && RestourantId == 9) yield return new ValidationResult("Sorry, but Staap can't take ratings lower then 5.");
			else if (Rating > 1 && RestourantId == 10) yield return new ValidationResult("Sorry, but Daily can't have bigger ratings then 1.");
		}
	}
}