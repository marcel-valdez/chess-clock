namespace ChessClock
{
    partial class ChessClock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChessClock));
            this.gaugeControl3 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.digitalTimeLeft = new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge();
            this.digitalBackgroundLayerComponent1 = new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent();
            this.gaugeControl4 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.digitalTimeRight = new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge();
            this.digitalBackgroundLayerComponent2 = new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent();
            this.btnSwitchClock = new DevExpress.XtraEditors.SimpleButton();
            this.btnResetTimers = new DevExpress.XtraEditors.SimpleButton();
            this.timeControlLeft = new DevExpress.XtraEditors.DataNavigator();
            this.timeControlRight = new DevExpress.XtraEditors.DataNavigator();
            this.btnPause = new DevExpress.XtraEditors.SimpleButton();
            this.gaugeControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.digitalTimeLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalBackgroundLayerComponent1)).BeginInit();
            this.gaugeControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.digitalTimeRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalBackgroundLayerComponent2)).BeginInit();
            this.SuspendLayout();
            // 
            // gaugeControl3
            // 
            this.gaugeControl3.AutoLayout = false;
            this.gaugeControl3.Controls.Add(this.timeControlLeft);
            this.gaugeControl3.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.digitalTimeLeft});
            this.gaugeControl3.Location = new System.Drawing.Point(35, 30);
            this.gaugeControl3.Name = "gaugeControl3";
            this.gaugeControl3.Size = new System.Drawing.Size(260, 143);
            this.gaugeControl3.TabIndex = 2;
            // 
            // digitalTimeLeft
            // 
            this.digitalTimeLeft.AppearanceOff.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#0FD4F2FF");
            this.digitalTimeLeft.AppearanceOn.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#D4F2FF");
            this.digitalTimeLeft.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent[] {
            this.digitalBackgroundLayerComponent1});
            this.digitalTimeLeft.Bounds = new System.Drawing.Rectangle(1, -3, 257, 108);
            this.digitalTimeLeft.DigitCount = 5;
            this.digitalTimeLeft.DisplayMode = DevExpress.XtraGauges.Core.Model.DigitalGaugeDisplayMode.SevenSegment;
            this.digitalTimeLeft.Name = "digitalTimeLeft";
            this.digitalTimeLeft.OptionsToolTip.TooltipFormat = "{1:F3}";
            this.digitalTimeLeft.Text = "00:00:00";
            // 
            // digitalBackgroundLayerComponent1
            // 
            this.digitalBackgroundLayerComponent1.BottomRight = new DevExpress.XtraGauges.Core.Base.PointF2D(251.375F, 106.075F);
            this.digitalBackgroundLayerComponent1.Name = "b1";
            this.digitalBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style2;
            this.digitalBackgroundLayerComponent1.TopLeft = new DevExpress.XtraGauges.Core.Base.PointF2D(20F, 0F);
            this.digitalBackgroundLayerComponent1.ZOrder = 1000;
            // 
            // gaugeControl4
            // 
            this.gaugeControl4.AutoLayout = false;
            this.gaugeControl4.Controls.Add(this.timeControlRight);
            this.gaugeControl4.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.digitalTimeRight});
            this.gaugeControl4.Location = new System.Drawing.Point(423, 30);
            this.gaugeControl4.Name = "gaugeControl4";
            this.gaugeControl4.Size = new System.Drawing.Size(260, 143);
            this.gaugeControl4.TabIndex = 3;
            // 
            // digitalTimeRight
            // 
            this.digitalTimeRight.AppearanceOff.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#0FD4F2FF");
            this.digitalTimeRight.AppearanceOn.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#D4F2FF");
            this.digitalTimeRight.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent[] {
            this.digitalBackgroundLayerComponent2});
            this.digitalTimeRight.Bounds = new System.Drawing.Rectangle(1, 0, 259, 101);
            this.digitalTimeRight.DigitCount = 5;
            this.digitalTimeRight.DisplayMode = DevExpress.XtraGauges.Core.Model.DigitalGaugeDisplayMode.SevenSegment;
            this.digitalTimeRight.Name = "digitalTimeRight";
            this.digitalTimeRight.Text = "0:00:00";
            // 
            // digitalBackgroundLayerComponent2
            // 
            this.digitalBackgroundLayerComponent2.BottomRight = new DevExpress.XtraGauges.Core.Base.PointF2D(251.375F, 106.075F);
            this.digitalBackgroundLayerComponent2.Name = "b1";
            this.digitalBackgroundLayerComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style2;
            this.digitalBackgroundLayerComponent2.TopLeft = new DevExpress.XtraGauges.Core.Base.PointF2D(20F, 0F);
            this.digitalBackgroundLayerComponent2.ZOrder = 1000;
            // 
            // btnSwitchClock
            // 
            this.btnSwitchClock.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwitchClock.Appearance.Options.UseFont = true;
            this.btnSwitchClock.Location = new System.Drawing.Point(35, 180);
            this.btnSwitchClock.Name = "btnSwitchClock";
            this.btnSwitchClock.Size = new System.Drawing.Size(648, 34);
            this.btnSwitchClock.TabIndex = 4;
            this.btnSwitchClock.Text = "Switch";
            this.btnSwitchClock.Click += new System.EventHandler(this.btnSwitchClock_Click);
            // 
            // btnResetTimers
            // 
            this.btnResetTimers.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetTimers.Appearance.Options.UseFont = true;
            this.btnResetTimers.Location = new System.Drawing.Point(301, 41);
            this.btnResetTimers.Name = "btnResetTimers";
            this.btnResetTimers.Size = new System.Drawing.Size(116, 34);
            this.btnResetTimers.TabIndex = 5;
            this.btnResetTimers.Text = "Reset Timers";
            this.btnResetTimers.Click += new System.EventHandler(this.btnResetTimers_Click);
            // 
            // timeControlLeft
            // 
            this.timeControlLeft.Buttons.Append.Visible = false;
            this.timeControlLeft.Buttons.CancelEdit.Visible = false;
            this.timeControlLeft.Buttons.EndEdit.Visible = false;
            this.timeControlLeft.Buttons.Remove.Visible = false;
            this.timeControlLeft.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.timeControlLeft.Location = new System.Drawing.Point(0, 112);
            this.timeControlLeft.Name = "timeControlLeft";
            this.timeControlLeft.Size = new System.Drawing.Size(260, 24);
            this.timeControlLeft.TabIndex = 0;
            this.timeControlLeft.Text = "dataNavigator1";
            this.timeControlLeft.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.timeControlLeft_ButtonClick);
            // 
            // timeControlRight
            // 
            this.timeControlRight.Buttons.Append.Visible = false;
            this.timeControlRight.Buttons.CancelEdit.Visible = false;
            this.timeControlRight.Buttons.EndEdit.Visible = false;
            this.timeControlRight.Buttons.Remove.Visible = false;
            this.timeControlRight.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.timeControlRight.Location = new System.Drawing.Point(0, 112);
            this.timeControlRight.Name = "timeControlRight";
            this.timeControlRight.Size = new System.Drawing.Size(260, 24);
            this.timeControlRight.TabIndex = 1;
            this.timeControlRight.Text = "dataNavigator1";
            this.timeControlRight.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.timeControlRight_ButtonClick);
            // 
            // btnPause
            // 
            this.btnPause.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.Appearance.Options.UseFont = true;
            this.btnPause.Location = new System.Drawing.Point(301, 90);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(115, 27);
            this.btnPause.TabIndex = 6;
            this.btnPause.Text = "Pause";
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // ChessClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 226);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnResetTimers);
            this.Controls.Add(this.btnSwitchClock);
            this.Controls.Add(this.gaugeControl4);
            this.Controls.Add(this.gaugeControl3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChessClock";
            this.Text = "Simple Chess Clock v 0.1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChessClock_FormClosing);
            this.gaugeControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.digitalTimeLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalBackgroundLayerComponent1)).EndInit();
            this.gaugeControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.digitalTimeRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalBackgroundLayerComponent2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl3;
        private DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge digitalTimeLeft;
        private DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent digitalBackgroundLayerComponent1;
        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl4;
        private DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge digitalTimeRight;
        private DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent digitalBackgroundLayerComponent2;
        private DevExpress.XtraEditors.SimpleButton btnSwitchClock;
        private DevExpress.XtraEditors.SimpleButton btnResetTimers;
        private DevExpress.XtraEditors.DataNavigator timeControlLeft;
        private DevExpress.XtraEditors.DataNavigator timeControlRight;
        private DevExpress.XtraEditors.SimpleButton btnPause;
    }
}