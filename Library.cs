using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace libraryProject.Models
{
	public class Library
	{
		[Key]
		public int BookId { get; set; }
		[Required]
		public string BookName { get; set; }
		[Required]
		public string Author { get; set; }
		public   int year { get; set; }
	}
}