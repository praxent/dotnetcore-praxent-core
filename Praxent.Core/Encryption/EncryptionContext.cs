using Microsoft.Extensions.Configuration;

namespace Praxent.Core.Encryption
{
    public class EncryptionContext : IEncryptionContext
    {
        private readonly IConfiguration _configuration;

        public EncryptionContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string Key { get { return _configuration.GetValue("ENCRYPTION_KEY", string.Empty); } }
        public string Salt { get { return _configuration.GetValue("ENCRYPTION_SALT", string.Empty); } }
    }
}