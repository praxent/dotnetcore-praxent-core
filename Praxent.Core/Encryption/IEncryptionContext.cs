namespace Praxent.Core.Encryption
{
    public interface IEncryptionContext
    {
        string Key { get; }
        string Salt { get; }
    }
}