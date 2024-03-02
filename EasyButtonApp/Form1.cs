using System;
using System.Media;
using System.Windows.Forms;

namespace EasyButtonApp
{
    public partial class Form1 : Form
    {
        private readonly SoundPlayer soundPlayer;
        public Form1()
        {
            InitializeComponent();
            // Audio for the Easy Button
            soundPlayer = new SoundPlayer();
            soundPlayer.Stream = EasyButtonApp.Properties.Resources.TWE;
        }

        private void button1_Click(object sender, EventArgs e) // The Easy Button
        {
            soundPlayer.Play();
        }
    }
}

// Made by August Wolf :3 - 2024