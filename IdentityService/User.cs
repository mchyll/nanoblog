namespace Mchyll.IdentityService
{
	public class User
	{
		public int Id { get; set; }
		public string Username { get; set; }
		public string FullName { get; set; }
		public string PasswordHash { get; set; }
	}
}
