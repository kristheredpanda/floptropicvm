using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace floptropicvm
{
    public partial class Form1 : Form
    {
        class MediaPlayer
        {
            System.Media.SoundPlayer soundPlayer;
            public MediaPlayer(byte[] buffer)
            {
                MemoryStream memoryStream = new MemoryStream(buffer, true);
                soundPlayer = new System.Media.SoundPlayer(memoryStream);
            }
            public void Play() { soundPlayer.Play(); }

            public void Play(byte[] buffer)
            {
                soundPlayer.Stream.Seek(0, SeekOrigin.Begin);
                soundPlayer.Stream.Write(buffer, 0, buffer.Length);
                soundPlayer.PlayLooping();
            }

            public void Stop()
            {
                soundPlayer.Stop();
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            File.WriteAllBytes("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\Temp\\p22jsanma.wav", Properties.Resources.p22jsanma);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
            string file1 = "C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\Temp\\p22jsanma.wav";
            List<byte> soundBytes = new List<byte>(File.ReadAllBytes(file1));
            MediaPlayer mPlayer = new MediaPlayer(soundBytes.ToArray());
            mPlayer.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("too bad. jiafei is queen.", "floptropicvm", MessageBoxButtons.OK, MessageBoxIcon.Hand) == DialogResult.OK)
            {
                this.Hide();
                Form2 f2 = new Form2();
                f2.Show();
                string file1 = "C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\Temp\\p22jsanma.wav";
                List<byte> soundBytes = new List<byte>(File.ReadAllBytes(file1));
                MediaPlayer mPlayer = new MediaPlayer(soundBytes.ToArray());
                mPlayer.Play();
            }
        }
    }
}
