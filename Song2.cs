using System;
using System.Windows.Forms;

namespace Projekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load (object sender, EventArgs e)
        {
            Song song = new Song();
            song.Genre = ("Popsong");
            song.artist_name = ("by.Selena Gomez");
            song.name = ("Calm Down");
            song.release_date = ("2023.07,23");
            song.listeners = ("630 Million listeners");

            song.info();
        }
    }
}