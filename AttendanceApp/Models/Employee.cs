using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AttendanceApp.Models
{
	public class Employee
	{
		public int ID { get; set; }
		[Display(Name = "Nombres")]
		public string FirstName { get; set; }

		[Display(Name = "Apellidos")]
		public string LastName { get; set; }

		[Display(Name = "Sueldo")]
		public decimal salary { get; set; }

		[Display(Name = "Cumpleaños")]
		public DateTime BirthDate { get; set; }


		[Display(Name = "Email")]

		[Required(ErrorMessage = "The email address is required")]
		[EmailAddress(ErrorMessage = "Invalid Email Address")]
		public string Email { get; set; }

		[Required]
		[DataType(DataType.Password)]
		[Display(Name = "Password")]
		public string Password { get; set; }

		[DataType(DataType.Password)]
		[Display(Name = "Confirmar password")]
		[Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
		public string ConfirmPassword { get; set; }



		[Display(Name = "Rol")]
		public string UserRoles { get; set; }


	}
}