using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTakingApp
{
    public partial class NoteTaker : Form
    {
        DataTable notes = new DataTable(); //det som en storage i grid form
        bool editing = false;
        public NoteTaker()
        {
            InitializeComponent();
        }

        private void NoteTaker_Load(object sender, EventArgs e)
        {
            notes.Columns.Add("Title");
            notes.Columns.Add("Note");

            previousNotes.DataSource = notes; //tillåtter databindning (datakoppling) till kontroller 
        }

        private void loadButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                notes.Rows[previousNotes.CurrentCell.RowIndex].Delete();// from rows, the selected cell, that has index in it gets deleted.
            }
            catch (Exception ex) {Console.WriteLine("Not a valid note"); } //se till att man inte deletar tomm sak

        }  

        private void saveButton_Click(object sender, EventArgs e)
        {
            string.saveButton = noteBox.Text;
            string.filePath = previousNotes;
        }

        private void addnewButton_Click(object sender, EventArgs e)
        {
            titleBox.Text = "";
            noteBox.Text = "";
        }

        private void previousNotes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
