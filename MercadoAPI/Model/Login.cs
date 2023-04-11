using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MercadoAPI.Model
{
	public class Login
	{
		[Key]
		public string username { get; set; }

		[ForeignKey("Signup")]
		public int Id { get; set; }

		[Required]
		public string password { get; set; }
	}
}
