using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using fivemLuncher;
using System.Diagnostics;

namespace LeaksRP
{
    public partial class Form1 : Form
    {
        public string Ip { get; set; }
        public int Port { get; set; }

        ayarlar LeaksRP = new ayarlar();
        public Form1()
        {
            InitializeComponent();
            Ip = "31.214.243.215";
            Port = 30120;

            InitializeComponent();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            { 
            System.Diagnostics.Process.Start($"fivem://connect/{Ip}:{Port}");

                foreach (var islem in Process.GetProcessesByName("cmd"))
                {
                    islem.Kill();
                }

            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LeaksRP.hileDurdur();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            LeaksRP.linkac("https://discordapp.com/channels/713870918786744371/713870919340261498/716581664054312961");
        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("ts3server://borp");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var islem in Process.GetProcessesByName("FiveM"))
            {
                islem.Kill();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            LeaksRP.kapatProgrami();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            foreach (Process p in Process.GetProcesses()) 
            {
                if (p.ProcessName == "cmd")
                {
                    Process.GetProcessById(p.Id).Kill();
                }

            }
        }
    }
}
