namespace Praxent.Core.Encryption
{
    public interface IHashProvider
    {
        string Hash(string value);
    }
}