#nullable enable
namespace UniT.Entities.DI
{
    using InternalDI;

    public static class EntityManagerInternalDI
    {
        public static void AddEntityManager(this DependencyContainer container)
        {
            container.AddInterfaces<EntityManager>();
        }
    }
}