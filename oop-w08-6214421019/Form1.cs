using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_6214421019_w08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string[] row0 = { "11/22/1968", "29", "Revolution 9",
            "Beatles", "The Beatles [White Album]" };
            string[] row1 = { "1960", "6", "Fools Rush In",
            "Frank Sinatra", "Nice 'N' Easy" };
            string[] row2 = { "11/11/1971", "1", "One of These Days",
            "Pink Floyd", "Meddle" };
            string[] row3 = { "1988", "7", "Where Is My Mind?",
            "Pixies", "Surfer Rosa" };
            string[] row4 = { "5/1981", "9", "Can't Find My Mind",
            "Cramps", "Psychedelic Jungle" };
            string[] row5 = { "6/10/2003", "13",
            "Scatterbrain. (As Dead As Leaves.)",
            "Radiohead", "Hail to the Thief" };
            string[] row6 = { "6/30/1992", "3", "Dress", "P J Harvey", "Dry" };

            DataGridViewDemo.Rows.Add(row0);
            DataGridViewDemo.Rows.Add(row1);
            DataGridViewDemo.Rows.Add(row2);
            DataGridViewDemo.Rows.Add(row3);
            DataGridViewDemo.Rows.Add(row4);
            DataGridViewDemo.Rows.Add(row5);
            DataGridViewDemo.Rows.Add(row6);

            DataGridViewDemo.Columns[0].DisplayIndex = 3;
            DataGridViewDemo.Columns[1].DisplayIndex = 4;
            DataGridViewDemo.Columns[2].DisplayIndex = 0;
            DataGridViewDemo.Columns[3].DisplayIndex = 1;
            DataGridViewDemo.Columns[4].DisplayIndex = 2;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.DataGridViewDemo.Rows.Add();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.DataGridViewDemo.SelectedRows.Count > 0 &&
                this.DataGridViewDemo.SelectedRows[0].Index !=
                this.DataGridViewDemo.Rows.Count - 1)
            {
                this.DataGridViewDemo.Rows.RemoveAt(
                    this.DataGridViewDemo.SelectedRows[0].Index);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Album a1 = new Album();

            DataGridViewDemo.Rows.Add(a1.a0);
            DataGridViewDemo.Rows.Add(a1.a1);
            DataGridViewDemo.Rows.Add(a1.a2);
            DataGridViewDemo.Rows.Add(a1.a3);
            DataGridViewDemo.Rows.Add(a1.a4);
            DataGridViewDemo.Rows.Add(a1.a5);
            DataGridViewDemo.Rows.Add(a1.a6);
        }
    }
}
