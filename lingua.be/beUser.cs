using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lingua.be
{
	public class beUser
	{
		public int UserId { get; set; }

		public string FirstName { get; set; } = null!;

		public string LastName { get; set; } = null!;

		public string Email { get; set; } = null!;

		public DateTime? BirthDate { get; set; }

		public string? Gender { get; set; }

		public DateTime? RegistrationDate { get; set; }

		public DateTime? LastUpdate { get; set; }

		public string? AccountStatus { get; set; }

		//public virtual ICollection<Profile> Profiles { get; set; } = new List<Profile>();
	}
}
