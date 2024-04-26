namespace OptionsPattern.Options
{
    public class AuthOptions
    {
        public const string Auth = "Auth";
        public string IdentityServer { get; set; } = string.Empty;
        public IdentityKeys IdentityKeys { get; set; } = new();
    }
}
