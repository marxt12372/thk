using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data;

namespace WebApplication1.Models
{
	public class Events
	{
		[Required]
		public long Id { get; set; }

		[Required]
		[DataType(DataType.Text)]
		[StringLength(maximumLength: 100, MinimumLength = 4)]
		public string Title { get; set; }

		[Required]
		[DataType(DataType.MultilineText)]
		public string Description { get; set; }

		[Required]
		[DataType(DataType.DateTime)]
		public DateTime Date { get; set; }
	}
}