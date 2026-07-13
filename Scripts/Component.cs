#nullable enable
namespace UniT.Entities
{
    using System.Diagnostics.CodeAnalysis;
    using System.Threading;
    using DI;
    using Extensions;
    using UnityEngine;

    public abstract class Component : MonoBehaviour, IComponent
    {
        IDependencyContainer IComponent.Container { set => this.Container = value; }

        IEntityManager IComponent.Manager { get => this.Manager; set => this.Manager = value; }

        IEntity IComponent.Entity { get => this.Entity; set => this.Entity = value; }

        protected IDependencyContainer Container { get; private set; } = null!;

        public IEntityManager Manager { get; private set; } = null!;

        public IEntity Entity { get; private set; } = null!;

        void IComponentLifecycle.OnInstantiate() => this.OnInstantiate();

        void IComponentLifecycle.OnSpawn() => this.OnSpawn();

        void IComponentLifecycle.OnRecycle() => this.OnRecycle();

        void IComponentLifecycle.OnCleanup() => this.OnCleanup();

        protected virtual void OnInstantiate() { }

        protected virtual void OnSpawn() { }

        protected virtual void OnRecycle() { }

        protected virtual void OnCleanup() { }

        public T? GetComponentOrDefault<T>() where T : notnull => UnityExtensions.GetComponentOrDefault<T>(this);

        public new T GetComponent<T>() where T : notnull => UnityExtensions.GetComponentOrThrow<T>(this);

        public bool HasComponent<T>() where T : notnull => UnityExtensions.HasComponent<T>(this);

        public T? GetComponentInChildrenOrDefault<T>(bool includeInactive = false) where T : notnull => UnityExtensions.GetComponentInChildrenOrDefault<T>(this, includeInactive);

        public new T GetComponentInChildren<T>(bool includeInactive = false) where T : notnull => UnityExtensions.GetComponentInChildrenOrThrow<T>(this, includeInactive);

        public bool HasComponentInChildren<T>(bool includeInactive = false) where T : notnull => UnityExtensions.HasComponentInChildren<T>(this, includeInactive);

        public bool TryGetComponentInChildren<T>([MaybeNullWhen(false)] out T component, bool includeInactive = false) where T : notnull => UnityExtensions.TryGetComponentInChildren(this, out component, includeInactive);

        public T? GetComponentInParentOrDefault<T>(bool includeInactive = false) where T : notnull => UnityExtensions.GetComponentInParentOrDefault<T>(this, includeInactive);

        public new T GetComponentInParent<T>(bool includeInactive = false) where T : notnull => UnityExtensions.GetComponentInParentOrThrow<T>(this, includeInactive);

        public bool HasComponentInParent<T>(bool includeInactive = false) where T : notnull => UnityExtensions.HasComponentInParent<T>(this, includeInactive);

        public bool TryGetComponentInParent<T>([MaybeNullWhen(false)] out T component, bool includeInactive = false) where T : notnull => UnityExtensions.TryGetComponentInParent(this, out component, includeInactive);

        public CancellationToken GetCancellationTokenOnDisable() => UnityUniTaskExtensions.GetCancellationTokenOnDisable(this);
    }
}