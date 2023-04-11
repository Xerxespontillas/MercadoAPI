using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MercadoAPI.Model
{
	
	public class Signup
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }


		[Required]
		public string phoneNum  { get; set; }

		[Required]
		public string address { get; set; }

		[Required]
		public string role { get; set; }

		public string company {get; set; }

		[Required]
		public string username { get; set; }

		[Required]
		public string password { get; set; }
	}

}
