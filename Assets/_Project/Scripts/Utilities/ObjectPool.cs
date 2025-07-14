using System.Collections.Generic;
using UnityEngine;

namespace SpaceColony.Core
{
    /// <summary>
    /// Generic object pool for frequently spawned objects
    /// Reduces garbage collection by reusing objects
    /// </summary>
    public class ObjectPool<T> where T : Component
    {
        private readonly Queue<T> _pool = new Queue<T>();
        private readonly T _prefab;
        private readonly Transform _parent;
        private readonly int _initialSize;
        private readonly bool _expandable;
        private int _currentSize;

        /// <summary>
        /// Create a new object pool
        /// </summary>
        /// <param name="prefab">The prefab to instantiate</param>
        /// <param name="initialSize">Number of objects to pre-instantiate</param>
        /// <param name="parent">Parent transform for organization</param>
        /// <param name="expandable">Whether pool can grow beyond initial size</param>
        public ObjectPool(T prefab, int initialSize, Transform parent = null, bool expandable = true)
        {
            _prefab = prefab;
            _initialSize = initialSize;
            _parent = parent;
            _expandable = expandable;

            PreWarm();
        }

        /// <summary>
        /// Pre-instantiate objects for the pool
        /// </summary>
        private void PreWarm()
        {
            for (int i = 0; i < _initialSize; i++)
            {
                CreateNewObject();
            }
        }

        /// <summary>
        /// Create a new object for the pool
        /// </summary>
        private T CreateNewObject()
        {
            T newObject = GameObject.Instantiate(_prefab, _parent);
            newObject.gameObject.SetActive(false);
            _currentSize++;
            return newObject;
        }

        /// <summary>
        /// Get an object from the pool
        /// </summary>
        public T Get()
        {
            T obj;

            if (_pool.Count > 0)
            {
                obj = _pool.Dequeue();
            }
            else if (_expandable)
            {
                obj = CreateNewObject();
                Debug.LogWarning($"[ObjectPool] Pool expanded. Current size: {_currentSize}");
            }
            else
            {
                Debug.LogError($"[ObjectPool] Pool exhausted and not expandable!");
                return null;
            }

            obj.gameObject.SetActive(true);
            return obj;
        }

        /// <summary>
        /// Get an object and set its position/rotation
        /// </summary>
        public T Get(Vector3 position, Quaternion rotation)
        {
            T obj = Get();
            if (obj != null)
            {
                obj.transform.position = position;
                obj.transform.rotation = rotation;
            }
            return obj;
        }

        /// <summary>
        /// Return an object to the pool
        /// </summary>
        public void Return(T obj)
        {
            if (obj == null) return;

            obj.gameObject.SetActive(false);

            // Reset transform
            if (_parent != null)
            {
                obj.transform.SetParent(_parent);
            }
            obj.transform.localPosition = Vector3.zero;
            obj.transform.localRotation = Quaternion.identity;

            _pool.Enqueue(obj);
        }

        /// <summary>
        /// Return an object to the pool after a delay
        /// </summary>
        public void ReturnDelayed(T obj, float delay)
        {
            if (obj == null) return;

            // In a real implementation, you'd use a coroutine or timer
            // For now, just return immediately
            Return(obj);
        }

        /// <summary>
        /// Clear the pool and destroy all objects
        /// </summary>
        public void Clear()
        {
            while (_pool.Count > 0)
            {
                T obj = _pool.Dequeue();
                if (obj != null)
                {
                    GameObject.Destroy(obj.gameObject);
                }
            }
            _currentSize = 0;
        }

        /// <summary>
        /// Get current pool statistics
        /// </summary>
        public (int available, int total) GetStats()
        {
            return (_pool.Count, _currentSize);
        }
    }

    /// <summary>
    /// Interface for poolable objects that need reset logic
    /// </summary>
    public interface IPoolable
    {
        void OnSpawnFromPool();
        void OnReturnToPool();
    }
}
