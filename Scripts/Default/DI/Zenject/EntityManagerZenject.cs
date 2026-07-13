#nullable enable
namespace UniT.Entities.DI
{
    using Zenject;

    public static class EntityManagerZenject
    {
        public static void BindEntityManager(this DiContainer container)
        {
            container.BindInterfacesTo<EntityManager>().AsSingle();
        }
    }
}