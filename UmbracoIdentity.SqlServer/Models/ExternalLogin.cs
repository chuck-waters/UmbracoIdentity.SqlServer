namespace UmbracoIdentity.SqlServer.Models
{
    internal class ExternalLogin
    {
        public int ExternalLoginId { get; set; }
        public int UserId { get; set; }
        public string LoginProvider { get; set; }
        public string ProviderKey { get; set; }
    }
}
