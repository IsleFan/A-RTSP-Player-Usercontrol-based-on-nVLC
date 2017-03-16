//    nVLC
//    
//    Author:  Roman Ginzburg
//
//    nVLC is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    nVLC is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
//    GNU General Public License for more details.
//     
// ========================================================================

using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Linq;

namespace nVLC_Demo_WinForms
{
    public partial class Form1 : Form
    {
        string[] stream1 = new string[]  {
                "rtsp://10.100.36.4:8554/iWatch_L1.mkv",
                "rtsp://10.100.36.4:8554/iWatch_L3.mkv",
                "rtsp://10.100.36.4:8554/iWatch_L4.mkv",
                "rtsp://10.100.36.4:8554/DL_Day_Cloud_FullEvent1.mkv",
                "rtsp://10.100.36.4:8554/DL_Day_Sunny_Shadow.mkv",
                "rtsp://10.100.36.4:8554/DL_Night_Pedestrin.mkv",
                "rtsp://10.100.36.4:8554/NVR2_20161021Rainning_Night.mkv",
                "rtsp://10.100.36.4:8554/NVR1.mkv",
                "rtsp://10.100.36.4:8554/K74_295G.mkv" };
        int streamIndex = 0;
        SDK.Player.RTSPPlayer[] rtspPlayer = new SDK.Player.RTSPPlayer[4];

        public Form1()
        {
            InitializeComponent();
            UISync.Init(this);
            rtspPlayer[0] = rtspPlayer1;
            rtspPlayer[1] = rtspPlayer2;
            rtspPlayer[2] = rtspPlayer3;
            rtspPlayer[3] = rtspPlayer4;
        }

        private class UISync
        {
            private static ISynchronizeInvoke Sync;

            public static void Init(ISynchronizeInvoke sync)
            {
                Sync = sync;
            }

            public static void Execute(Action action)
            {
                Sync.BeginInvoke(action, null);
            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            rtspPlayer5.Play(textBox2.Text);
        }

        object Lock4InsertItem2Listbox = new object();
        
        private void InsertItem2Listbox(ListBox Box, string Item)
        {
            System.Threading.Monitor.Enter(Lock4InsertItem2Listbox);
            Box.SuspendLayout();
            try
            {
                while (Box.Items.Count >= 500)
                {
                    Box.Items.RemoveAt(Box.Items.Count - 1);
                }
                Box.Items.Insert(0, Item);
            }
            finally
            {
                System.Threading.Monitor.Exit(Lock4InsertItem2Listbox);
                Box.ResumeLayout();
            }
        }

        private void rtspPlayer1_OnMediaStatusEvent(object sender, Declarations.MediaState Status)
        {
            UISync.Execute(new Action(() => InsertItem2Listbox(listBox1, DateTime.Now.ToLongTimeString() + ": " + Status.ToString())));
        }

        private void rtspPlayer1_OnPlayerEvent(object sender, SDK.Player.RTSPPlayer.PlayerState Status)
        {
            UISync.Execute(new Action(() => InsertItem2Listbox(listBox2, DateTime.Now.ToLongTimeString() + ": " + Status.ToString())));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rtspPlayer1.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rtspPlayer1.Pause();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = timer1.Enabled ? false : true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                try
                {
                    string rtsp = stream1[streamIndex++].Trim();
                    streamIndex = streamIndex % (stream1.Length);

                    //rtspPlayer[i].Stop();
                    rtspPlayer[i].Play(rtsp);
                }
                catch (Exception err)
                {
                    listBox1.Items.Add(err.StackTrace);
                }
            }
        }
    }
}
