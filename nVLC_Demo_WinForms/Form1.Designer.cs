namespace nVLC_Demo_WinForms
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rtspPlayer4 = new SDK.Player.RTSPPlayer();
            this.rtspPlayer3 = new SDK.Player.RTSPPlayer();
            this.rtspPlayer2 = new SDK.Player.RTSPPlayer();
            this.rtspPlayer1 = new SDK.Player.RTSPPlayer();
            this.rtspPlayer5 = new SDK.Player.RTSPPlayer();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(480, 22);
            this.textBox2.TabIndex = 15;
            this.textBox2.Text = "rtsp://10.100.36.4:8554/K66_306Y2.mkv";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 42);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 16;
            this.button6.Text = "Play";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(744, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(253, 148);
            this.listBox1.TabIndex = 17;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 12;
            this.listBox2.Location = new System.Drawing.Point(495, 21);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(245, 148);
            this.listBox2.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(744, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 12);
            this.label1.TabIndex = 19;
            this.label1.Text = "MediaStatusEvent";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(493, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 12);
            this.label2.TabIndex = 20;
            this.label2.Text = "PlayerEvent";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(174, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Stop";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Pause";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 26;
            this.button3.Text = "Auto";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rtspPlayer4
            // 
            this.rtspPlayer4.Autoconnect = true;
            this.rtspPlayer4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtspPlayer4.Location = new System.Drawing.Point(413, 414);
            this.rtspPlayer4.Name = "rtspPlayer4";
            this.rtspPlayer4.Size = new System.Drawing.Size(395, 233);
            this.rtspPlayer4.TabIndex = 25;
            // 
            // rtspPlayer3
            // 
            this.rtspPlayer3.Autoconnect = true;
            this.rtspPlayer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtspPlayer3.Location = new System.Drawing.Point(12, 414);
            this.rtspPlayer3.Name = "rtspPlayer3";
            this.rtspPlayer3.Size = new System.Drawing.Size(395, 233);
            this.rtspPlayer3.TabIndex = 24;
            // 
            // rtspPlayer2
            // 
            this.rtspPlayer2.Autoconnect = true;
            this.rtspPlayer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtspPlayer2.Location = new System.Drawing.Point(413, 175);
            this.rtspPlayer2.Name = "rtspPlayer2";
            this.rtspPlayer2.Size = new System.Drawing.Size(395, 233);
            this.rtspPlayer2.TabIndex = 23;
            // 
            // rtspPlayer1
            // 
            this.rtspPlayer1.Autoconnect = true;
            this.rtspPlayer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtspPlayer1.Location = new System.Drawing.Point(12, 175);
            this.rtspPlayer1.Name = "rtspPlayer1";
            this.rtspPlayer1.Size = new System.Drawing.Size(395, 233);
            this.rtspPlayer1.TabIndex = 14;
            this.rtspPlayer1.OnPlayerEvent += new SDK.Player.RTSPPlayer.Handler_rtspPlayer<SDK.Player.RTSPPlayer.PlayerState>(this.rtspPlayer1_OnPlayerEvent);
            this.rtspPlayer1.OnMediaStatusEvent += new SDK.Player.RTSPPlayer.Handler_rtspPlayer<Declarations.MediaState>(this.rtspPlayer1_OnMediaStatusEvent);
            // 
            // rtspPlayer5
            // 
            this.rtspPlayer5.Autoconnect = true;
            this.rtspPlayer5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtspPlayer5.Location = new System.Drawing.Point(255, 40);
            this.rtspPlayer5.Name = "rtspPlayer5";
            this.rtspPlayer5.Size = new System.Drawing.Size(234, 129);
            this.rtspPlayer5.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 656);
            this.Controls.Add(this.rtspPlayer5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.rtspPlayer4);
            this.Controls.Add(this.rtspPlayer3);
            this.Controls.Add(this.rtspPlayer2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.rtspPlayer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "nVLC Windows Forms Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox2;
        private SDK.Player.RTSPPlayer rtspPlayer1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private SDK.Player.RTSPPlayer rtspPlayer2;
        private SDK.Player.RTSPPlayer rtspPlayer3;
        private SDK.Player.RTSPPlayer rtspPlayer4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
        private SDK.Player.RTSPPlayer rtspPlayer5;
    }
}

