/*
 * Created by SharpDevelop.
 * User: davidsonb
 * Date: 3/10/2016
 * Time: 8:45 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Cubic_Appmenu
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox serverBox;
		private System.Windows.Forms.Label severLabel;
		private System.Windows.Forms.TextBox userBox;
		private System.Windows.Forms.Label pwdLabel;
		private System.Windows.Forms.Button statusButton;
		private System.Windows.Forms.Label appLabel;
		private System.Windows.Forms.TextBox pwdBox;
		private System.Windows.Forms.Button stopButton;
		private System.Windows.Forms.Button startButton;
		private System.Windows.Forms.Button statusappButton;
		private System.Windows.Forms.Button killButton;
		private System.Windows.Forms.Button viewButton;
		private System.Windows.Forms.Label userLabel;
		private System.Windows.Forms.TextBox appBox;
		private System.Windows.Forms.Button viewdashButton;
		private System.Windows.Forms.Button pingButton;
		private System.Windows.Forms.Button cpingButton;
		private System.Windows.Forms.Button lookupButton;
		private System.Windows.Forms.Button trouteButton;
		private System.Windows.Forms.GroupBox NetworkBox;
		private System.Windows.Forms.Button ThreadDumpbutton;
		private System.Windows.Forms.GroupBox ApplicationBox;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button ClearCNGbutton;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.serverBox = new System.Windows.Forms.TextBox();
			this.severLabel = new System.Windows.Forms.Label();
			this.userBox = new System.Windows.Forms.TextBox();
			this.pwdLabel = new System.Windows.Forms.Label();
			this.statusButton = new System.Windows.Forms.Button();
			this.appLabel = new System.Windows.Forms.Label();
			this.pwdBox = new System.Windows.Forms.TextBox();
			this.stopButton = new System.Windows.Forms.Button();
			this.startButton = new System.Windows.Forms.Button();
			this.statusappButton = new System.Windows.Forms.Button();
			this.killButton = new System.Windows.Forms.Button();
			this.viewButton = new System.Windows.Forms.Button();
			this.userLabel = new System.Windows.Forms.Label();
			this.appBox = new System.Windows.Forms.TextBox();
			this.viewdashButton = new System.Windows.Forms.Button();
			this.pingButton = new System.Windows.Forms.Button();
			this.cpingButton = new System.Windows.Forms.Button();
			this.lookupButton = new System.Windows.Forms.Button();
			this.trouteButton = new System.Windows.Forms.Button();
			this.NetworkBox = new System.Windows.Forms.GroupBox();
			this.ThreadDumpbutton = new System.Windows.Forms.Button();
			this.ApplicationBox = new System.Windows.Forms.GroupBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.ClearCNGbutton = new System.Windows.Forms.Button();
			this.NetworkBox.SuspendLayout();
			this.ApplicationBox.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// serverBox
			// 
			this.serverBox.Location = new System.Drawing.Point(135, 7);
			this.serverBox.Margin = new System.Windows.Forms.Padding(4);
			this.serverBox.Name = "serverBox";
			this.serverBox.Size = new System.Drawing.Size(155, 22);
			this.serverBox.TabIndex = 0;
			// 
			// severLabel
			// 
			this.severLabel.Location = new System.Drawing.Point(0, 11);
			this.severLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.severLabel.Name = "severLabel";
			this.severLabel.Size = new System.Drawing.Size(133, 28);
			this.severLabel.TabIndex = 20;
			this.severLabel.Text = "Server Name:";
			this.severLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// userBox
			// 
			this.userBox.Location = new System.Drawing.Point(135, 55);
			this.userBox.Margin = new System.Windows.Forms.Padding(4);
			this.userBox.Name = "userBox";
			this.userBox.Size = new System.Drawing.Size(155, 22);
			this.userBox.TabIndex = 1;
			// 
			// pwdLabel
			// 
			this.pwdLabel.Location = new System.Drawing.Point(0, 100);
			this.pwdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.pwdLabel.Name = "pwdLabel";
			this.pwdLabel.Size = new System.Drawing.Size(133, 28);
			this.pwdLabel.TabIndex = 18;
			this.pwdLabel.Text = "Password:";
			this.pwdLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// statusButton
			// 
			this.statusButton.Location = new System.Drawing.Point(11, 26);
			this.statusButton.Margin = new System.Windows.Forms.Padding(4);
			this.statusButton.Name = "statusButton";
			this.statusButton.Size = new System.Drawing.Size(152, 28);
			this.statusButton.TabIndex = 4;
			this.statusButton.Text = "Check Status - All ";
			this.statusButton.UseVisualStyleBackColor = true;
			this.statusButton.Click += new System.EventHandler(this.statusButtonClick);
			// 
			// appLabel
			// 
			this.appLabel.Location = new System.Drawing.Point(0, 150);
			this.appLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.appLabel.Name = "appLabel";
			this.appLabel.Size = new System.Drawing.Size(133, 28);
			this.appLabel.TabIndex = 17;
			this.appLabel.Text = "Application Name:";
			this.appLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// pwdBox
			// 
			this.pwdBox.Location = new System.Drawing.Point(135, 100);
			this.pwdBox.Margin = new System.Windows.Forms.Padding(4);
			this.pwdBox.Name = "pwdBox";
			this.pwdBox.PasswordChar = '*';
			this.pwdBox.Size = new System.Drawing.Size(155, 22);
			this.pwdBox.TabIndex = 2;
			// 
			// stopButton
			// 
			this.stopButton.Location = new System.Drawing.Point(183, 62);
			this.stopButton.Margin = new System.Windows.Forms.Padding(4);
			this.stopButton.Name = "stopButton";
			this.stopButton.Size = new System.Drawing.Size(152, 28);
			this.stopButton.TabIndex = 7;
			this.stopButton.Text = "Stop Application";
			this.stopButton.UseVisualStyleBackColor = true;
			this.stopButton.Click += new System.EventHandler(this.stopButtonClick);
			// 
			// startButton
			// 
			this.startButton.Location = new System.Drawing.Point(183, 26);
			this.startButton.Margin = new System.Windows.Forms.Padding(4);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(152, 28);
			this.startButton.TabIndex = 5;
			this.startButton.Text = "Start Application";
			this.startButton.UseVisualStyleBackColor = true;
			this.startButton.Click += new System.EventHandler(this.startButtonClick);
			// 
			// statusappButton
			// 
			this.statusappButton.Location = new System.Drawing.Point(11, 62);
			this.statusappButton.Margin = new System.Windows.Forms.Padding(4);
			this.statusappButton.Name = "statusappButton";
			this.statusappButton.Size = new System.Drawing.Size(152, 28);
			this.statusappButton.TabIndex = 6;
			this.statusappButton.Text = "Check Status - App";
			this.statusappButton.UseVisualStyleBackColor = true;
			this.statusappButton.Click += new System.EventHandler(this.statusappButtonClick);
			// 
			// killButton
			// 
			this.killButton.Location = new System.Drawing.Point(183, 97);
			this.killButton.Margin = new System.Windows.Forms.Padding(4);
			this.killButton.Name = "killButton";
			this.killButton.Size = new System.Drawing.Size(152, 28);
			this.killButton.TabIndex = 9;
			this.killButton.Text = "Kill Application";
			this.killButton.UseVisualStyleBackColor = true;
			this.killButton.Click += new System.EventHandler(this.killButtonClick);
			// 
			// viewButton
			// 
			this.viewButton.Location = new System.Drawing.Point(11, 97);
			this.viewButton.Margin = new System.Windows.Forms.Padding(4);
			this.viewButton.Name = "viewButton";
			this.viewButton.Size = new System.Drawing.Size(152, 28);
			this.viewButton.TabIndex = 8;
			this.viewButton.Text = "View Log";
			this.viewButton.UseVisualStyleBackColor = true;
			this.viewButton.Click += new System.EventHandler(this.viewButtonClick);
			// 
			// userLabel
			// 
			this.userLabel.Location = new System.Drawing.Point(0, 59);
			this.userLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.userLabel.Name = "userLabel";
			this.userLabel.Size = new System.Drawing.Size(133, 28);
			this.userLabel.TabIndex = 19;
			this.userLabel.Text = "User Name:";
			this.userLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// appBox
			// 
			this.appBox.Location = new System.Drawing.Point(135, 146);
			this.appBox.Margin = new System.Windows.Forms.Padding(4);
			this.appBox.Name = "appBox";
			this.appBox.Size = new System.Drawing.Size(155, 22);
			this.appBox.TabIndex = 3;
			// 
			// viewdashButton
			// 
			this.viewdashButton.Location = new System.Drawing.Point(11, 135);
			this.viewdashButton.Margin = new System.Windows.Forms.Padding(4);
			this.viewdashButton.Name = "viewdashButton";
			this.viewdashButton.Size = new System.Drawing.Size(152, 28);
			this.viewdashButton.TabIndex = 10;
			this.viewdashButton.Text = "View Dashboard";
			this.viewdashButton.UseVisualStyleBackColor = true;
			this.viewdashButton.Click += new System.EventHandler(this.viewdashButtonClick);
			// 
			// pingButton
			// 
			this.pingButton.Location = new System.Drawing.Point(11, 26);
			this.pingButton.Margin = new System.Windows.Forms.Padding(4);
			this.pingButton.Name = "pingButton";
			this.pingButton.Size = new System.Drawing.Size(152, 28);
			this.pingButton.TabIndex = 12;
			this.pingButton.Text = "Ping";
			this.pingButton.UseVisualStyleBackColor = true;
			this.pingButton.Click += new System.EventHandler(this.pingButtonClick);
			// 
			// cpingButton
			// 
			this.cpingButton.Location = new System.Drawing.Point(183, 26);
			this.cpingButton.Margin = new System.Windows.Forms.Padding(4);
			this.cpingButton.Name = "cpingButton";
			this.cpingButton.Size = new System.Drawing.Size(152, 28);
			this.cpingButton.TabIndex = 13;
			this.cpingButton.Text = "Continuous Ping";
			this.cpingButton.UseVisualStyleBackColor = true;
			this.cpingButton.Click += new System.EventHandler(this.CpingButtonClick);
			// 
			// lookupButton
			// 
			this.lookupButton.Location = new System.Drawing.Point(11, 62);
			this.lookupButton.Margin = new System.Windows.Forms.Padding(4);
			this.lookupButton.Name = "lookupButton";
			this.lookupButton.Size = new System.Drawing.Size(152, 28);
			this.lookupButton.TabIndex = 14;
			this.lookupButton.Text = "NS Lookup";
			this.lookupButton.UseVisualStyleBackColor = true;
			this.lookupButton.Click += new System.EventHandler(this.LookupButtonClick);
			// 
			// trouteButton
			// 
			this.trouteButton.Location = new System.Drawing.Point(183, 62);
			this.trouteButton.Margin = new System.Windows.Forms.Padding(4);
			this.trouteButton.Name = "trouteButton";
			this.trouteButton.Size = new System.Drawing.Size(152, 28);
			this.trouteButton.TabIndex = 15;
			this.trouteButton.Text = "Trace Route";
			this.trouteButton.UseVisualStyleBackColor = true;
			this.trouteButton.Click += new System.EventHandler(this.TrouteButtonClick);
			// 
			// NetworkBox
			// 
			this.NetworkBox.BackColor = System.Drawing.SystemColors.Control;
			this.NetworkBox.Controls.Add(this.pingButton);
			this.NetworkBox.Controls.Add(this.trouteButton);
			this.NetworkBox.Controls.Add(this.cpingButton);
			this.NetworkBox.Controls.Add(this.lookupButton);
			this.NetworkBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.NetworkBox.Location = new System.Drawing.Point(315, 202);
			this.NetworkBox.Margin = new System.Windows.Forms.Padding(4);
			this.NetworkBox.Name = "NetworkBox";
			this.NetworkBox.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
			this.NetworkBox.Size = new System.Drawing.Size(345, 105);
			this.NetworkBox.TabIndex = 22;
			this.NetworkBox.TabStop = false;
			this.NetworkBox.Text = "Network ";
			// 
			// ThreadDumpbutton
			// 
			this.ThreadDumpbutton.Location = new System.Drawing.Point(183, 135);
			this.ThreadDumpbutton.Margin = new System.Windows.Forms.Padding(4);
			this.ThreadDumpbutton.Name = "ThreadDumpbutton";
			this.ThreadDumpbutton.Size = new System.Drawing.Size(152, 28);
			this.ThreadDumpbutton.TabIndex = 11;
			this.ThreadDumpbutton.Text = "Thread Dump";
			this.ThreadDumpbutton.UseVisualStyleBackColor = true;
			this.ThreadDumpbutton.Click += new System.EventHandler(this.ThreadDumpbuttonClick);
			// 
			// ApplicationBox
			// 
			this.ApplicationBox.BackColor = System.Drawing.SystemColors.Control;
			this.ApplicationBox.Controls.Add(this.statusButton);
			this.ApplicationBox.Controls.Add(this.ThreadDumpbutton);
			this.ApplicationBox.Controls.Add(this.statusappButton);
			this.ApplicationBox.Controls.Add(this.startButton);
			this.ApplicationBox.Controls.Add(this.stopButton);
			this.ApplicationBox.Controls.Add(this.killButton);
			this.ApplicationBox.Controls.Add(this.viewButton);
			this.ApplicationBox.Controls.Add(this.viewdashButton);
			this.ApplicationBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.ApplicationBox.Location = new System.Drawing.Point(315, 7);
			this.ApplicationBox.Margin = new System.Windows.Forms.Padding(4);
			this.ApplicationBox.Name = "ApplicationBox";
			this.ApplicationBox.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
			this.ApplicationBox.Size = new System.Drawing.Size(345, 185);
			this.ApplicationBox.TabIndex = 21;
			this.ApplicationBox.TabStop = false;
			this.ApplicationBox.Text = "Application";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.ClearCNGbutton);
			this.groupBox1.Location = new System.Drawing.Point(56, 202);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox1.Size = new System.Drawing.Size(187, 65);
			this.groupBox1.TabIndex = 23;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "CNG Message Queue";
			this.groupBox1.Visible = false;
			// 
			// ClearCNGbutton
			// 
			this.ClearCNGbutton.Location = new System.Drawing.Point(11, 26);
			this.ClearCNGbutton.Margin = new System.Windows.Forms.Padding(4);
			this.ClearCNGbutton.Name = "ClearCNGbutton";
			this.ClearCNGbutton.Size = new System.Drawing.Size(152, 28);
			this.ClearCNGbutton.TabIndex = 16;
			this.ClearCNGbutton.Text = "Clear ActiveMQ";
			this.ClearCNGbutton.UseVisualStyleBackColor = true;
			this.ClearCNGbutton.Visible = false;
			this.ClearCNGbutton.Click += new System.EventHandler(this.ClearCNGbuttonClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(689, 314);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.ApplicationBox);
			this.Controls.Add(this.appBox);
			this.Controls.Add(this.userLabel);
			this.Controls.Add(this.pwdBox);
			this.Controls.Add(this.appLabel);
			this.Controls.Add(this.pwdLabel);
			this.Controls.Add(this.userBox);
			this.Controls.Add(this.severLabel);
			this.Controls.Add(this.serverBox);
			this.Controls.Add(this.NetworkBox);
			this.HelpButton = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.Text = "Cubic Appmenu";
			this.TransparencyKey = System.Drawing.Color.Navy;
			this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.MainFormHelpButtonClicked);
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.NetworkBox.ResumeLayout(false);
			this.ApplicationBox.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		
		void MainFormLoad(object sender, System.EventArgs e)
		{
			
		}
		}
	}
