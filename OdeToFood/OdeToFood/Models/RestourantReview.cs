using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OdeToFood.Models
{
	public class RestourantReview
	{
		public int Id { get; set; }
		public float Rating { get; set; }
		public string Body { get; set; }
		public string RatedBy { get; set; }
		public int RestourantId { get; set; }
	}
}