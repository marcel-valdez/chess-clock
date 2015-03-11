using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Diagnostics.Contracts;
namespace ChessClock
{
    public partial class ChessClock : XtraForm
    {
        private readonly Binding leftClockBinding;
        private readonly IClockTimer leftClock = new ClockTimer();
        private readonly Binding rightClockBinding;
        private readonly IClockTimer rightClock = new ClockTimer();
        private bool IsResetState = true;

        public ChessClock()
        {
            this.InitializeComponent();
            this.leftClockBinding = this.InitClockBinding(this.digitalTimeLeft.DataBindings, leftClock);
            this.rightClockBinding = this.InitClockBinding(this.digitalTimeRight.DataBindings, rightClock);
            this.InitNavigator(this.timeControlRight);
            this.InitNavigator(this.timeControlLeft);
        }

        private void ChessClock_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DisposeClocks();
        }

        private void InitNavigator(DataNavigator nav)
        {
            List<string> dummyList = new List<string>() { "uno", "dos", "tres", "cuatro" };
            nav.DataSource = dummyList;
            nav.Position = 2;
        }

        private Binding InitClockBinding(ControlBindingsCollection bindings, IClockTimer timer)
        {
            Binding clockBinding = new Binding("Text", timer, "TimeString", true) 
            { 
                ControlUpdateMode = ControlUpdateMode.OnPropertyChanged,
                DataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged 
            };

            bindings.Add(clockBinding);
            Action<IClockTimer> callback = (clockTimer) =>
                {
                    clockBinding.ReadValue();
                };

            timer.RegisterCallback(callback);
            return clockBinding;
        }

        private void DisposeClocks()
        {
            leftClock.Dispose();
            rightClock.Dispose();
        }

        private void timeControlLeft_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (this.IsResetState)
            {
                this.HandleClockButton(e.Button, leftClock);
            }

            e.Handled = true;
        }

        private void timeControlRight_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (this.IsResetState)
            {
                this.HandleClockButton(e.Button, rightClock);
            }

            e.Handled = true;
        }

        private void HandleClockButton(NavigatorButtonBase button, IClockTimer clock)
        {
            switch (button.ButtonType)
            {
                case NavigatorButtonType.Next:
                    clock.AddMinutes(1);
                    break;
                case NavigatorButtonType.Prev:
                    clock.AddMinutes(-1);
                    break;
                case NavigatorButtonType.NextPage:
                    clock.AddMinutes(10);
                    break;
                case NavigatorButtonType.PrevPage:
                    clock.AddMinutes(-10);
                    break;
                case NavigatorButtonType.First:
                    clock.AddHours(-1);
                    break;
                case NavigatorButtonType.Last:
                    clock.AddHours(1);
                    break;
            }

            clock.Reset();
        }

        private void btnSwitchClock_Click(object sender, EventArgs e)
        {
            this.IsResetState = false;

            if (leftClock.IsRunning)
            {
                leftClock.Pause();
                rightClock.Start();
            }
            else
            {
                leftClock.Start();
                rightClock.Pause();
            }
        }

        private void btnResetTimers_Click(object sender, EventArgs e)
        {
            if (!this.IsResetState)
            {
                leftClock.Pause();
                rightClock.Pause();
                leftClock.Reset();
                rightClock.Reset();
                this.IsResetState = true;
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (!this.IsResetState)
            {
                leftClock.Pause();
                rightClock.Pause();
            }
        }

        [ContractInvariantMethod]
        private void Invariant()
        {
            Contract.Invariant(leftClock != null);
            Contract.Invariant(rightClock != null);
        }
    }
}