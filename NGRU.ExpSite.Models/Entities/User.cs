namespace NGRU.ExpSite.Models.Entities
{
	public class User : EntityBasedClass
	{
		public string Name { get; set; }

		public string PasswordHash { get; set; }

		public string Email { get; set; }

		public string Nickname { get; set; }

		public string AdditionalInfo { get; set; }
	}
}