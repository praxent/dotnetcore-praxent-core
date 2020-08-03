using Autofac;
using Praxent.Core.CodeGenerator;
using Praxent.Core.Encryption;
using Praxent.Core.IQueryable;

namespace Praxent.Core
{
    public static class Bootstrapper
    {
        public static ContainerBuilder AddCoreComponents(this ContainerBuilder builder)
        {
            builder.RegisterType<EncryptionContext>().As<IEncryptionContext>();
            builder.RegisterType<AesEncryptionProvider>().As<IEncryptionProvider>();
            builder.RegisterType<Sha512HashProvider>().As<IHashProvider>();
            builder.RegisterType<QueryProcessor>().As<IQueryProcessor>();
            builder.RegisterType<RandomCodeProvider>().As<IRandomCodeProvider>();

            return builder;
        }
    }
}