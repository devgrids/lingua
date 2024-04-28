using System.ComponentModel.DataAnnotations;

namespace lingua.Models.ViewModels
{
	public class ProfileViewModel
	{
		[Required]
		[Display(Name = "EnglishLevel")]
		public byte EnglishLevel { get; set; }

		[Required]
		[Display(Name = "UserId")]
		public int UserId { get; set; }
	}
}
