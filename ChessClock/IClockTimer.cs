using System;

namespace ChessClock
{
    public interface IClockTimer : IDisposable
    {
        /// <summary>
        /// Adds the hours.
        /// </summary>
        /// <param name="hour">The hour.</param>
        void AddHours(int hour);

        /// <summary>
        /// Adds the minutes.
        /// </summary>
        /// <param name="minutes">The minutes.</param>
        void AddMinutes(int minutes);

        /// <summary>
        /// Starts this instance.
        /// </summary>
        void Start();

        /// <summary>
        /// Pauses this instance.
        /// </summary>
        void Pause();

        /// <summary>
        /// Resets this instance.
        /// </summary>
        void Reset();

        /// <summary>
        /// Gets the time string.
        /// </summary>
        string TimeString { get; }

        /// <summary>
        /// Gets the time left.
        /// </summary>
        TimeSpan TimeLeft { get; }

        /// <summary>
        /// Registers the callback.
        /// </summary>
        /// <param name="callback">The callback.</param>
        void RegisterCallback(Action<IClockTimer> callback);

        /// <summary>
        /// Gets a value indicating whether this instance is running.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this instance is running; otherwise, <c>false</c>.
        /// </value>
        bool IsRunning { get; }
    }
}
