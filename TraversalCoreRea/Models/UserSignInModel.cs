

using System.ComponentModel.DataAnnotations;

namespace TraversalCoreRea.Models
{
	public class UserSignInModel
	{
		[Required(ErrorMessage="Lütfen kullanıcı adını giriniz.")]
		public string UserName { get; set; }

		[Required(ErrorMessage = "Lütfen şifrenizi giriniz.")]
		public string Password { get; set; }

	}
}
