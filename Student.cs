using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentManagement.Models
{
	public class Student
	{
		[Key]
		public int StudentId { get; set; }
		[Required]
		public string StudentName { get; set; }
		[Required]
		public int StudentAge { get; set; }
		[Required]
		public string StudentCourse { get; set; }
	}
}