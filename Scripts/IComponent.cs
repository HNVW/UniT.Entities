#nullable enable
namespace UniT.Entities
{
    using UniT.DI;
    using UnityEngine;

    public interface IComponent : IComponentLifecycle
    {
        public IDependencyContainer Container { set; }

        public IEntityManager Manager { get; set; }

        public IEntity Entity { get; set; }

#pragma warning disable IDE1006 // Naming Styles
        // ReSharper disable once InconsistentNaming
        public GameObject gameObject { get; }
#pragma warning restore IDE1006 // Naming Styles
    }
}