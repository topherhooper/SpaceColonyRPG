using UnityEngine;

namespace SpaceColony.Core
{
    /// <summary>
    /// Generic singleton base class for manager instances
    /// Ensures only one instance exists and persists between scenes
    /// </summary>
    public abstract class Singleton<T> : MonoBehaviour where T : MonoBehaviour
    {
        private static T _instance;
        private static readonly object _lock = new object();
        private static bool _applicationIsQuitting = false;

        public static T Instance
        {
            get
            {
                if (_applicationIsQuitting)
                {
                    Debug.LogWarning($"[Singleton] Instance of {typeof(T)} already destroyed. Returning null.");
                    return null;
                }

                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = FindObjectOfType<T>();

                        if (_instance == null)
                        {
                            GameObject singletonObject = new GameObject();
                            _instance = singletonObject.AddComponent<T>();
                            singletonObject.name = $"{typeof(T).Name} (Singleton)";

                            DontDestroyOnLoad(singletonObject);
                            Debug.Log($"[Singleton] Created new instance of {typeof(T)}");
                        }
                        else
                        {
                            Debug.Log($"[Singleton] Using existing instance of {typeof(T)}");
                        }
                    }

                    return _instance;
                }
            }
        }

        protected virtual void Awake()
        {
            if (_instance == null)
            {
                _instance = this as T;
                DontDestroyOnLoad(gameObject);
                OnAwakeSetup();
            }
            else if (_instance != this)
            {
                Debug.LogWarning($"[Singleton] Duplicate instance of {typeof(T)} found. Destroying...");
                Destroy(gameObject);
            }
        }

        protected virtual void OnDestroy()
        {
            if (_instance == this)
            {
                _applicationIsQuitting = true;
            }
        }

        /// <summary>
        /// Override this for initialization code instead of using Awake
        /// </summary>
        protected virtual void OnAwakeSetup()
        {
            // Override in derived classes
        }
    }
}
