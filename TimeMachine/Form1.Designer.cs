namespace TimeMachine
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
			this.currentTimeBox = new System.Windows.Forms.GroupBox();
			this.currentTime = new System.Windows.Forms.Label();
			this.destinationTimeBox = new System.Windows.Forms.GroupBox();
			this.destinationTime = new System.Windows.Forms.Label();
			this.lastTimeBox = new System.Windows.Forms.GroupBox();
			this.lastTime = new System.Windows.Forms.Label();
			this.pad1 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.padGo = new System.Windows.Forms.Button();
			this.padCancel = new System.Windows.Forms.Button();
			this.padConfirm = new System.Windows.Forms.Button();
			this.pad0 = new System.Windows.Forms.Button();
			this.pad9 = new System.Windows.Forms.Button();
			this.pad8 = new System.Windows.Forms.Button();
			this.pad7 = new System.Windows.Forms.Button();
			this.pad6 = new System.Windows.Forms.Button();
			this.pad5 = new System.Windows.Forms.Button();
			this.pad4 = new System.Windows.Forms.Button();
			this.pad3 = new System.Windows.Forms.Button();
			this.pad2 = new System.Windows.Forms.Button();
			this.controlOutput = new System.Windows.Forms.RichTextBox();
			this.mainText = new System.Windows.Forms.RichTextBox();
			this.currentTimeBox.SuspendLayout();
			this.destinationTimeBox.SuspendLayout();
			this.lastTimeBox.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// currentTimeBox
			// 
			this.currentTimeBox.Controls.Add(this.currentTime);
			this.currentTimeBox.Location = new System.Drawing.Point(7, 81);
			this.currentTimeBox.Name = "currentTimeBox";
			this.currentTimeBox.Size = new System.Drawing.Size(305, 66);
			this.currentTimeBox.TabIndex = 1;
			this.currentTimeBox.TabStop = false;
			this.currentTimeBox.Text = "Current Time";
			// 
			// currentTime
			// 
			this.currentTime.Dock = System.Windows.Forms.DockStyle.Fill;
			this.currentTime.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
			this.currentTime.ForeColor = System.Drawing.Color.LimeGreen;
			this.currentTime.Location = new System.Drawing.Point(3, 18);
			this.currentTime.Name = "currentTime";
			this.currentTime.Size = new System.Drawing.Size(299, 45);
			this.currentTime.TabIndex = 0;
			this.currentTime.Text = "NOV 12 1955 10:04 PM";
			this.currentTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// destinationTimeBox
			// 
			this.destinationTimeBox.Controls.Add(this.destinationTime);
			this.destinationTimeBox.Location = new System.Drawing.Point(7, 12);
			this.destinationTimeBox.Name = "destinationTimeBox";
			this.destinationTimeBox.Size = new System.Drawing.Size(305, 66);
			this.destinationTimeBox.TabIndex = 2;
			this.destinationTimeBox.TabStop = false;
			this.destinationTimeBox.Text = "Destination Time";
			// 
			// destinationTime
			// 
			this.destinationTime.Dock = System.Windows.Forms.DockStyle.Fill;
			this.destinationTime.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
			this.destinationTime.ForeColor = System.Drawing.Color.Red;
			this.destinationTime.Location = new System.Drawing.Point(3, 18);
			this.destinationTime.Name = "destinationTime";
			this.destinationTime.Size = new System.Drawing.Size(299, 45);
			this.destinationTime.TabIndex = 0;
			this.destinationTime.Text = "NOV 12 1955 10:04 PM";
			this.destinationTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lastTimeBox
			// 
			this.lastTimeBox.BackColor = System.Drawing.SystemColors.Control;
			this.lastTimeBox.Controls.Add(this.lastTime);
			this.lastTimeBox.Location = new System.Drawing.Point(4, 153);
			this.lastTimeBox.Name = "lastTimeBox";
			this.lastTimeBox.Size = new System.Drawing.Size(305, 66);
			this.lastTimeBox.TabIndex = 2;
			this.lastTimeBox.TabStop = false;
			this.lastTimeBox.Text = "Last Time Departed";
			// 
			// lastTime
			// 
			this.lastTime.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lastTime.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
			this.lastTime.ForeColor = System.Drawing.Color.Gold;
			this.lastTime.Location = new System.Drawing.Point(3, 18);
			this.lastTime.Name = "lastTime";
			this.lastTime.Size = new System.Drawing.Size(299, 45);
			this.lastTime.TabIndex = 0;
			this.lastTime.Text = "NOV 12 1955 10:04 PM";
			this.lastTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pad1
			// 
			this.pad1.Location = new System.Drawing.Point(3, 3);
			this.pad1.Name = "pad1";
			this.pad1.Size = new System.Drawing.Size(30, 30);
			this.pad1.TabIndex = 3;
			this.pad1.Text = "1";
			this.pad1.UseVisualStyleBackColor = true;
			this.pad1.Click += new System.EventHandler(this.pad1_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Control;
			this.panel1.Controls.Add(this.padGo);
			this.panel1.Controls.Add(this.padCancel);
			this.panel1.Controls.Add(this.padConfirm);
			this.panel1.Controls.Add(this.pad0);
			this.panel1.Controls.Add(this.pad9);
			this.panel1.Controls.Add(this.pad8);
			this.panel1.Controls.Add(this.pad7);
			this.panel1.Controls.Add(this.pad6);
			this.panel1.Controls.Add(this.pad5);
			this.panel1.Controls.Add(this.pad4);
			this.panel1.Controls.Add(this.pad3);
			this.panel1.Controls.Add(this.pad2);
			this.panel1.Controls.Add(this.pad1);
			this.panel1.Location = new System.Drawing.Point(4, 225);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(164, 144);
			this.panel1.TabIndex = 4;
			// 
			// padGo
			// 
			this.padGo.BackColor = System.Drawing.Color.CadetBlue;
			this.padGo.Location = new System.Drawing.Point(121, 75);
			this.padGo.Name = "padGo";
			this.padGo.Size = new System.Drawing.Size(40, 66);
			this.padGo.TabIndex = 6;
			this.padGo.UseVisualStyleBackColor = false;
			this.padGo.Click += new System.EventHandler(this.padGo_Click);
			// 
			// padCancel
			// 
			this.padCancel.BackColor = System.Drawing.Color.Red;
			this.padCancel.Location = new System.Drawing.Point(121, 39);
			this.padCancel.Name = "padCancel";
			this.padCancel.Size = new System.Drawing.Size(40, 30);
			this.padCancel.TabIndex = 6;
			this.padCancel.UseVisualStyleBackColor = false;
			this.padCancel.Click += new System.EventHandler(this.padCancel_Click);
			// 
			// padConfirm
			// 
			this.padConfirm.BackColor = System.Drawing.Color.ForestGreen;
			this.padConfirm.Location = new System.Drawing.Point(121, 3);
			this.padConfirm.Name = "padConfirm";
			this.padConfirm.Size = new System.Drawing.Size(40, 30);
			this.padConfirm.TabIndex = 5;
			this.padConfirm.UseVisualStyleBackColor = false;
			this.padConfirm.Click += new System.EventHandler(this.padConfirm_Click);
			// 
			// pad0
			// 
			this.pad0.Location = new System.Drawing.Point(39, 111);
			this.pad0.Name = "pad0";
			this.pad0.Size = new System.Drawing.Size(30, 30);
			this.pad0.TabIndex = 5;
			this.pad0.Text = "0";
			this.pad0.UseVisualStyleBackColor = true;
			this.pad0.Click += new System.EventHandler(this.pad0_Click);
			// 
			// pad9
			// 
			this.pad9.Location = new System.Drawing.Point(75, 75);
			this.pad9.Name = "pad9";
			this.pad9.Size = new System.Drawing.Size(30, 30);
			this.pad9.TabIndex = 5;
			this.pad9.Text = "9";
			this.pad9.UseVisualStyleBackColor = true;
			this.pad9.Click += new System.EventHandler(this.pad9_Click);
			// 
			// pad8
			// 
			this.pad8.Location = new System.Drawing.Point(39, 75);
			this.pad8.Name = "pad8";
			this.pad8.Size = new System.Drawing.Size(30, 30);
			this.pad8.TabIndex = 5;
			this.pad8.Text = "8";
			this.pad8.UseVisualStyleBackColor = true;
			this.pad8.Click += new System.EventHandler(this.pad8_Click);
			// 
			// pad7
			// 
			this.pad7.Location = new System.Drawing.Point(3, 75);
			this.pad7.Name = "pad7";
			this.pad7.Size = new System.Drawing.Size(30, 30);
			this.pad7.TabIndex = 5;
			this.pad7.Text = "7";
			this.pad7.UseVisualStyleBackColor = true;
			this.pad7.Click += new System.EventHandler(this.pad7_Click);
			// 
			// pad6
			// 
			this.pad6.Location = new System.Drawing.Point(75, 39);
			this.pad6.Name = "pad6";
			this.pad6.Size = new System.Drawing.Size(30, 30);
			this.pad6.TabIndex = 5;
			this.pad6.Text = "6";
			this.pad6.UseVisualStyleBackColor = true;
			this.pad6.Click += new System.EventHandler(this.pad6_Click);
			// 
			// pad5
			// 
			this.pad5.Location = new System.Drawing.Point(39, 39);
			this.pad5.Name = "pad5";
			this.pad5.Size = new System.Drawing.Size(30, 30);
			this.pad5.TabIndex = 5;
			this.pad5.Text = "5";
			this.pad5.UseVisualStyleBackColor = true;
			this.pad5.Click += new System.EventHandler(this.pad5_Click);
			// 
			// pad4
			// 
			this.pad4.Location = new System.Drawing.Point(3, 39);
			this.pad4.Name = "pad4";
			this.pad4.Size = new System.Drawing.Size(30, 30);
			this.pad4.TabIndex = 5;
			this.pad4.Text = "4";
			this.pad4.UseVisualStyleBackColor = true;
			this.pad4.Click += new System.EventHandler(this.pad4_Click);
			// 
			// pad3
			// 
			this.pad3.Location = new System.Drawing.Point(75, 3);
			this.pad3.Name = "pad3";
			this.pad3.Size = new System.Drawing.Size(30, 30);
			this.pad3.TabIndex = 5;
			this.pad3.Text = "3";
			this.pad3.UseVisualStyleBackColor = true;
			this.pad3.Click += new System.EventHandler(this.pad3_Click);
			// 
			// pad2
			// 
			this.pad2.Location = new System.Drawing.Point(39, 3);
			this.pad2.Name = "pad2";
			this.pad2.Size = new System.Drawing.Size(30, 30);
			this.pad2.TabIndex = 4;
			this.pad2.Text = "2";
			this.pad2.UseVisualStyleBackColor = true;
			this.pad2.Click += new System.EventHandler(this.pad2_Click);
			// 
			// controlOutput
			// 
			this.controlOutput.Location = new System.Drawing.Point(174, 225);
			this.controlOutput.Name = "controlOutput";
			this.controlOutput.ReadOnly = true;
			this.controlOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
			this.controlOutput.Size = new System.Drawing.Size(135, 144);
			this.controlOutput.TabIndex = 5;
			this.controlOutput.Text = "";
			// 
			// mainText
			// 
			this.mainText.BackColor = System.Drawing.SystemColors.Desktop;
			this.mainText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mainText.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.mainText.Location = new System.Drawing.Point(322, 18);
			this.mainText.Name = "mainText";
			this.mainText.ReadOnly = true;
			this.mainText.Size = new System.Drawing.Size(454, 454);
			this.mainText.TabIndex = 6;
			this.mainText.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 526);
			this.Controls.Add(this.mainText);
			this.Controls.Add(this.controlOutput);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.lastTimeBox);
			this.Controls.Add(this.destinationTimeBox);
			this.Controls.Add(this.currentTimeBox);
			this.Name = "Form1";
			this.Text = "Time Machine Simulator";
			this.currentTimeBox.ResumeLayout(false);
			this.destinationTimeBox.ResumeLayout(false);
			this.lastTimeBox.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox currentTimeBox;
		private System.Windows.Forms.Label currentTime;
		private System.Windows.Forms.GroupBox destinationTimeBox;
		private System.Windows.Forms.Label destinationTime;
		private System.Windows.Forms.GroupBox lastTimeBox;
		private System.Windows.Forms.Label lastTime;
		private System.Windows.Forms.Button pad1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button padGo;
		private System.Windows.Forms.Button padCancel;
		private System.Windows.Forms.Button padConfirm;
		private System.Windows.Forms.Button pad0;
		private System.Windows.Forms.Button pad9;
		private System.Windows.Forms.Button pad8;
		private System.Windows.Forms.Button pad7;
		private System.Windows.Forms.Button pad6;
		private System.Windows.Forms.Button pad5;
		private System.Windows.Forms.Button pad4;
		private System.Windows.Forms.Button pad3;
		private System.Windows.Forms.Button pad2;
		private System.Windows.Forms.RichTextBox controlOutput;
		private System.Windows.Forms.RichTextBox mainText;
	}
}

