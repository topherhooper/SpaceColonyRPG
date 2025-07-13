using System;
using UnityEngine;

namespace SpaceColony.Core
{
    /// <summary>
    /// Reusable timer utility for countdowns and cooldowns
    /// </summary>
    [Serializable]
    public class Timer
    {
        [SerializeField] private float _duration;
        [SerializeField] private float _timeRemaining;
        [SerializeField] private bool _isRunning;
        [SerializeField] private bool _autoReset;

        /// <summary>
        /// Event fired when timer completes
        /// </summary>
        public event Action OnTimerComplete;

        /// <summary>
        /// Event fired on each tick with normalized progress (0-1)
        /// </summary>
        public event Action<float> OnTimerTick;

        public float Duration
        {
            get => _duration;
            set => _duration = Mathf.Max(0f, value);
        }

        public float TimeRemaining => _timeRemaining;
        public bool IsRunning => _isRunning;
        public bool IsComplete => _isRunning && _timeRemaining <= 0f;
        public float Progress => _duration > 0f ? 1f - (_timeRemaining / _duration) : 1f;
        public float ProgressInverse => _duration > 0f ? _timeRemaining / _duration : 0f;

        /// <summary>
        /// Create a new timer
        /// </summary>
        /// <param name="duration">Timer duration in seconds</param>
        /// <param name="autoReset">Whether timer should auto-restart when complete</param>
        public Timer(float duration, bool autoReset = false)
        {
            _duration = Mathf.Max(0f, duration);
            _autoReset = autoReset;
            _timeRemaining = _duration;
            _isRunning = false;
        }

        /// <summary>
        /// Start or restart the timer
        /// </summary>
        public void Start()
        {
            _timeRemaining = _duration;
            _isRunning = true;
        }

        /// <summary>
        /// Start timer with a specific duration
        /// </summary>
        public void Start(float duration)
        {
            _duration = Mathf.Max(0f, duration);
            Start();
        }

        /// <summary>
        /// Pause the timer
        /// </summary>
        public void Pause()
        {
            _isRunning = false;
        }

        /// <summary>
        /// Resume a paused timer
        /// </summary>
        public void Resume()
        {
            if (_timeRemaining > 0f)
            {
                _isRunning = true;
            }
        }

        /// <summary>
        /// Stop and reset the timer
        /// </summary>
        public void Stop()
        {
            _isRunning = false;
            _timeRemaining = _duration;
        }

        /// <summary>
        /// Update the timer (call in Update or FixedUpdate)
        /// </summary>
        /// <param name="deltaTime">Time since last update</param>
        public void Tick(float deltaTime)
        {
            if (!_isRunning || _timeRemaining <= 0f) return;

            _timeRemaining -= deltaTime;
            OnTimerTick?.Invoke(Progress);

            if (_timeRemaining <= 0f)
            {
                _timeRemaining = 0f;
                OnTimerComplete?.Invoke();

                if (_autoReset)
                {
                    Start();
                }
                else
                {
                    _isRunning = false;
                }
            }
        }

        /// <summary>
        /// Add time to the timer
        /// </summary>
        public void AddTime(float seconds)
        {
            _timeRemaining = Mathf.Max(0f, _timeRemaining + seconds);
        }

        /// <summary>
        /// Set the timer to a specific time
        /// </summary>
        public void SetTimeRemaining(float seconds)
        {
            _timeRemaining = Mathf.Clamp(seconds, 0f, _duration);
        }

        /// <summary>
        /// Force complete the timer
        /// </summary>
        public void ForceComplete()
        {
            if (_isRunning)
            {
                _timeRemaining = 0f;
                OnTimerComplete?.Invoke();
                
                if (_autoReset)
                {
                    Start();
                }
                else
                {
                    _isRunning = false;
                }
            }
        }

        /// <summary>
        /// Clear all event subscribers
        /// </summary>
        public void ClearEvents()
        {
            OnTimerComplete = null;
            OnTimerTick = null;
        }
    }

    /// <summary>
    /// MonoBehaviour wrapper for easy timer usage
    /// </summary>
    public class TimerBehaviour : MonoBehaviour
    {
        [SerializeField] private Timer _timer = new Timer(1f);
        
        public Timer Timer => _timer;

        public void StartTimer(float duration)
        {
            _timer.Start(duration);
        }

        private void Update()
        {
            _timer.Tick(Time.deltaTime);
        }

        private void OnDestroy()
        {
            _timer.ClearEvents();
        }
    }
}