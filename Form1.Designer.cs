namespace AnalogIn_toMeter_SW_Timed
{
    partial class Form1
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
        	this.components = new System.ComponentModel.Container();
        	this.Label6 = new System.Windows.Forms.Label();
        	this.txtADValue = new System.Windows.Forms.TextBox();
        	this.cbRate = new System.Windows.Forms.ComboBox();
        	this.Label5 = new System.Windows.Forms.Label();
        	this.btnStartStop = new System.Windows.Forms.Button();
        	this.Button6 = new System.Windows.Forms.Button();
        	this.Label3 = new System.Windows.Forms.Label();
        	this.cmboAInRange = new System.Windows.Forms.ComboBox();
        	this.Label23 = new System.Windows.Forms.Label();
        	this.Label1 = new System.Windows.Forms.Label();
        	this.nudAInChannel = new System.Windows.Forms.NumericUpDown();
        	this.lblAIMode = new System.Windows.Forms.Label();
        	this.tmrAnalogIn = new System.Windows.Forms.Timer(this.components);
        	this.analogMeter1 = new BERGtools.AnalogMeter();
        	this.label2 = new System.Windows.Forms.Label();
        	this.time_label = new System.Windows.Forms.Label();
        	((System.ComponentModel.ISupportInitialize)(this.nudAInChannel)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// Label6
        	// 
        	this.Label6.AutoSize = true;
        	this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.Label6.Location = new System.Drawing.Point(168, 142);
        	this.Label6.Name = "Label6";
        	this.Label6.Size = new System.Drawing.Size(81, 15);
        	this.Label6.TabIndex = 206;
        	this.Label6.Text = "Напряжение";
        	// 
        	// txtADValue
        	// 
        	this.txtADValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.txtADValue.Location = new System.Drawing.Point(266, 136);
        	this.txtADValue.Name = "txtADValue";
        	this.txtADValue.Size = new System.Drawing.Size(128, 21);
        	this.txtADValue.TabIndex = 205;
        	this.txtADValue.TextChanged += new System.EventHandler(this.TxtADValueTextChanged);
        	// 
        	// cbRate
        	// 
        	this.cbRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.cbRate.Location = new System.Drawing.Point(237, 102);
        	this.cbRate.Name = "cbRate";
        	this.cbRate.Size = new System.Drawing.Size(76, 23);
        	this.cbRate.TabIndex = 203;
        	this.cbRate.SelectedIndexChanged += new System.EventHandler(this.CbRateSelectedIndexChanged);
        	// 
        	// Label5
        	// 
        	this.Label5.AutoSize = true;
        	this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.Label5.Location = new System.Drawing.Point(168, 110);
        	this.Label5.Name = "Label5";
        	this.Label5.Size = new System.Drawing.Size(53, 15);
        	this.Label5.TabIndex = 202;
        	this.Label5.Text = "Выб/сек";
        	// 
        	// btnStartStop
        	// 
        	this.btnStartStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnStartStop.Location = new System.Drawing.Point(168, 236);
        	this.btnStartStop.Name = "btnStartStop";
        	this.btnStartStop.Size = new System.Drawing.Size(75, 23);
        	this.btnStartStop.TabIndex = 201;
        	this.btnStartStop.Text = "Старт";
        	this.btnStartStop.UseVisualStyleBackColor = true;
        	this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
        	// 
        	// Button6
        	// 
        	this.Button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        	this.Button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.Button6.Location = new System.Drawing.Point(168, 265);
        	this.Button6.Name = "Button6";
        	this.Button6.Size = new System.Drawing.Size(88, 27);
        	this.Button6.TabIndex = 195;
        	this.Button6.Text = "Выход";
        	this.Button6.UseVisualStyleBackColor = true;
        	this.Button6.Click += new System.EventHandler(this.Button6_Click);
        	// 
        	// Label3
        	// 
        	this.Label3.AutoSize = true;
        	this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.Label3.Location = new System.Drawing.Point(168, 168);
        	this.Label3.Name = "Label3";
        	this.Label3.Size = new System.Drawing.Size(50, 15);
        	this.Label3.TabIndex = 199;
        	this.Label3.Text = "Статус:";
        	// 
        	// cmboAInRange
        	// 
        	this.cmboAInRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.cmboAInRange.FormattingEnabled = true;
        	this.cmboAInRange.Location = new System.Drawing.Point(238, 67);
        	this.cmboAInRange.Name = "cmboAInRange";
        	this.cmboAInRange.Size = new System.Drawing.Size(100, 23);
        	this.cmboAInRange.TabIndex = 198;
        	// 
        	// Label23
        	// 
        	this.Label23.AutoSize = true;
        	this.Label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.Label23.Location = new System.Drawing.Point(168, 39);
        	this.Label23.Name = "Label23";
        	this.Label23.Size = new System.Drawing.Size(46, 15);
        	this.Label23.TabIndex = 194;
        	this.Label23.Text = "Канал:";
        	// 
        	// Label1
        	// 
        	this.Label1.AutoSize = true;
        	this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.Label1.Location = new System.Drawing.Point(168, 75);
        	this.Label1.Name = "Label1";
        	this.Label1.Size = new System.Drawing.Size(64, 15);
        	this.Label1.TabIndex = 197;
        	this.Label1.Text = "Диапазон";
        	// 
        	// nudAInChannel
        	// 
        	this.nudAInChannel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.nudAInChannel.Location = new System.Drawing.Point(237, 33);
        	this.nudAInChannel.Maximum = new decimal(new int[] {
			8,
			0,
			0,
			0});
        	this.nudAInChannel.Name = "nudAInChannel";
        	this.nudAInChannel.Size = new System.Drawing.Size(46, 21);
        	this.nudAInChannel.TabIndex = 196;
        	// 
        	// lblAIMode
        	// 
        	this.lblAIMode.AutoSize = true;
        	this.lblAIMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lblAIMode.Location = new System.Drawing.Point(237, 168);
        	this.lblAIMode.Name = "lblAIMode";
        	this.lblAIMode.Size = new System.Drawing.Size(67, 15);
        	this.lblAIMode.TabIndex = 193;
        	this.lblAIMode.Text = "Ожидание";
        	// 
        	// tmrAnalogIn
        	// 
        	this.tmrAnalogIn.Tick += new System.EventHandler(this.tmrAnalogIn_Tick);
        	// 
        	// analogMeter1
        	// 
        	this.analogMeter1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
        	this.analogMeter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        	this.analogMeter1.FontColor = System.Drawing.Color.Blue;
        	this.analogMeter1.Location = new System.Drawing.Point(418, 47);
        	this.analogMeter1.Margin = new System.Windows.Forms.Padding(4);
        	this.analogMeter1.Maximum = 10D;
        	this.analogMeter1.Minimum = 0D;
        	this.analogMeter1.Name = "analogMeter1";
        	this.analogMeter1.PointerColor = System.Drawing.Color.Red;
        	this.analogMeter1.ScaleColor = System.Drawing.Color.Blue;
        	this.analogMeter1.ShowValue = true;
        	this.analogMeter1.Size = new System.Drawing.Size(177, 136);
        	this.analogMeter1.TabIndex = 209;
        	this.analogMeter1.Ticks = 10;
        	this.analogMeter1.Value = 0;
        	this.analogMeter1.Load += new System.EventHandler(this.AnalogMeter1Load);
        	// 
        	// label2
        	// 
        	this.label2.Location = new System.Drawing.Point(168, 197);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(64, 16);
        	this.label2.TabIndex = 210;
        	this.label2.Text = "Время:";
        	this.label2.Click += new System.EventHandler(this.Label2Click);
        	// 
        	// time_label
        	// 
        	this.time_label.Location = new System.Drawing.Point(266, 197);
        	this.time_label.Name = "time_label";
        	this.time_label.Size = new System.Drawing.Size(100, 16);
        	this.time_label.TabIndex = 211;
        	this.time_label.Click += new System.EventHandler(this.Time_labelClick);
        	// 
        	// Form1
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(647, 317);
        	this.Controls.Add(this.time_label);
        	this.Controls.Add(this.label2);
        	this.Controls.Add(this.analogMeter1);
        	this.Controls.Add(this.Label6);
        	this.Controls.Add(this.txtADValue);
        	this.Controls.Add(this.cbRate);
        	this.Controls.Add(this.Label5);
        	this.Controls.Add(this.btnStartStop);
        	this.Controls.Add(this.Button6);
        	this.Controls.Add(this.Label3);
        	this.Controls.Add(this.cmboAInRange);
        	this.Controls.Add(this.Label23);
        	this.Controls.Add(this.Label1);
        	this.Controls.Add(this.nudAInChannel);
        	this.Controls.Add(this.lblAIMode);
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
        	this.MinimizeBox = false;
        	this.Name = "Form1";
        	this.Text = "Form1";
        	this.Load += new System.EventHandler(this.Form1_Load);
        	((System.ComponentModel.ISupportInitialize)(this.nudAInChannel)).EndInit();
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.TextBox txtADValue;
        private System.Windows.Forms.ComboBox cbRate;
        private System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Button btnStartStop;
        internal System.Windows.Forms.Button Button6;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.ComboBox cmboAInRange;
        internal System.Windows.Forms.Label Label23;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.NumericUpDown nudAInChannel;
        internal System.Windows.Forms.Label lblAIMode;
        internal System.Windows.Forms.Timer tmrAnalogIn;
        private BERGtools.AnalogMeter analogMeter1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label time_label;
    }
}

