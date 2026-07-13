#nullable enable
namespace UniT.Entities.DI
{
    using VContainer;

    public static class EntityManagerVContainer
    {
        public static void RegisterEntityManager(this IContainerBuilder builder)
        {
            builder.Register<EntityManager>(Lifetime.Singleton).AsImplementedInterfaces();
        }
    }
}