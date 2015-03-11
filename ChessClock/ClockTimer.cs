using System;
using System.Threading;
using System.Collections.Generic;

namespace ChessClock
{
    public class ClockTimer : IClockTimer
    {
        private TimeSpan time;
        private TimeSpan timeleft;
        private bool active = true;
        List<Action<IClockTimer>> callbacks = new List<Action<IClockTimer>>();

        private ManualResetEventSlim pauseEvent = new ManualResetEventSlim(false);
        private AutoResetEvent updateEvent = new AutoResetEvent(false);

        /// <summary>
        /// Initializes a new instance of the <see cref="ClockTimer"/> class.
        /// </summary>
        /// <param name="hours">The hours.</param>
        public ClockTimer(double hours = 8)
        {
            this.time = TimeSpan.FromHours(hours);
            this.RestartTimer();

            Thread timerThread = new Thread(this.Run);
            timerThread.Start();

            Thread updatesThread = new Thread(this.MakeCallbacks);
            updatesThread.Start();
        }

        /// <summary>
        /// Gets the time string.
        /// </summary>
        public string TimeString
        {
            get
            {
                return string.Format("{0}:{1:00}:{2:00}", this.timeleft.Hours, this.timeleft.Minutes, this.timeleft.Seconds);
            }
        }

        /// <summary>
        /// Gets a copy of the time left.
        /// </summary>
        public TimeSpan TimeLeft
        {
            get
            {
                return TimeSpan.FromSeconds(this.timeleft.TotalSeconds);
            }
        }

        /// <summary>
        /// Gets a value indicating whether this instance is running.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this instance is running; otherwise, <c>false</c>.
        /// </value>
        public bool IsRunning
        {
            get
            {
                return this.pauseEvent.IsSet;
            }
        }

        /// <summary>
        /// Registers the callback.
        /// </summary>
        /// <param name="callback">The callback.</param>
        public void RegisterCallback(Action<IClockTimer> callback)
        {
            lock(this.callbacks)
            {
                this.callbacks.Add(callback);
            }
        }

        /// <summary>
        /// Adds the hours.
        /// </summary>
        /// <param name="hour">The hour.</param>
        public void AddHours(int hour)
        {
            lock (this)
            {
                this.time = this.time.Add(TimeSpan.FromHours(hour));
            }
        }

        /// <summary>
        /// Adds the minutes.
        /// </summary>
        /// <param name="minutes">The minutes.</param>
        public void AddMinutes(int minutes)
        {
            lock (this)
            {
                this.time = this.time.Add(TimeSpan.FromMinutes(minutes));
            }
        }

        /// <summary>
        /// Starts this instance.
        /// </summary>
        public void Start()
        {
            this.pauseEvent.Set();
        }

        /// <summary>
        /// Pauses this instance.
        /// </summary>
        public void Pause()
        {
            this.pauseEvent.Reset();
        }

        /// <summary>
        /// Resets this instance.
        /// </summary>
        public void Reset()
        {
            this.Pause();
            this.RestartTimer();
            this.UpdateClients();
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            this.active = false;
            this.updateEvent.Set();
            this.pauseEvent.Set();
        }

        /// <summary>
        /// Restarts the timer.
        /// </summary>
        private void RestartTimer()
        {
            this.timeleft = TimeSpan.FromSeconds(this.time.TotalSeconds);
        }

        private void Run()
        {
            TimeSpan frequency = TimeSpan.FromMilliseconds(500);
            do
            {
                Thread.Sleep(frequency);
                this.WaitIfTimerIsPaused();
                this.timeleft = this.timeleft.Subtract(frequency);
                this.WaitIfTimerIsPaused();
                this.UpdateClients();
            } while (this.active);
        }

        /// <summary>
        /// Makes the callbacks.
        /// </summary>
        private void MakeCallbacks()
        {
            do
            {
                this.updateEvent.WaitOne();
                foreach (var callback in this.callbacks)
                {
                    callback(this);
                }
            }
            while (this.active);
        }

        /// <summary>
        /// Waits if timer is paused.
        /// </summary>
        private void WaitIfTimerIsPaused()
        {
            this.pauseEvent.Wait();
        }

        /// <summary>
        /// Updates the clients.
        /// </summary>
        private void UpdateClients()
        {
            this.updateEvent.Set();
        }
    }
}
