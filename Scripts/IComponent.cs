#nullable enable
namespace UniT.Entities
{
    using System.Diagnostics.CodeAnalysis;
    using System.Threading;
    using DI;
    using UnityEngine;

    public interface IComponent : IComponentLifecycle
    {
        public IDependencyContainer Container { set; }

        public IEntityManager Manager { get; set; }

        public IEntity Entity { get; set; }

        public GameObject gameObject { get; }

        public Transform transform { get; }

        #region Extensions

        public T? GetComponentOrDefault<T>() where T : notnull;

        public T GetComponent<T>() where T : notnull;

        public T[] GetComponents<T>() where T : notnull;

        public bool HasComponent<T>() where T : notnull;

        public bool TryGetComponent<T>([MaybeNullWhen(false)] out T component) where T : notnull;

        public T? GetComponentInChildrenOrDefault<T>(bool includeInactive = false) where T : notnull;

        public T GetComponentInChildren<T>(bool includeInactive = false) where T : notnull;

        public T[] GetComponentsInChildren<T>(bool includeInactive = false) where T : notnull;

        public bool HasComponentInChildren<T>(bool includeInactive = false) where T : notnull;

        public bool TryGetComponentInChildren<T>([MaybeNullWhen(false)] out T component, bool includeInactive = false) where T : notnull;

        public T? GetComponentInParentOrDefault<T>(bool includeInactive = false) where T : notnull;

        public T GetComponentInParent<T>(bool includeInactive = false) where T : notnull;

        public T[] GetComponentsInParent<T>(bool includeInactive = false) where T : notnull;

        public bool HasComponentInParent<T>(bool includeInactive = false) where T : notnull;

        public bool TryGetComponentInParent<T>([MaybeNullWhen(false)] out T component, bool includeInactive = false) where T : notnull;

        public CancellationToken GetCancellationTokenOnDisable();

        #endregion
    }
}