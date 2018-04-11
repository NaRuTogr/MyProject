using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDLab
{
    public partial class Route : Form
    {
        public Route()
        {
            InitializeComponent();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            label1.Visible = true;
            label1.Text = "Пошук";
            textBox1.Focus();
        }

        private void btFilter_Click(object sender, EventArgs e)
        {

            if (btFilter.Checked)
            {
                textBox2.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label2.Text = "Введіть фільтр:<ім'я поля><логічний знак><значення>";
                label3.Text = "Enter";
            }
            else
            {
                textBox2.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                h.bs1.Filter = "";
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {

            InsertRoute f1add = new InsertRoute();
            f1add.ShowDialog();
            h.bs1.DataSource = h.DB("select * from Routes");
            dataGridView1.DataSource = h.bs1;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            h.curVa10 = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            h.keyName = dataGridView1.Columns[0].Name;

            DeleteRoute f3 = new DeleteRoute();
            f3.ShowDialog();

            h.bs1.DataSource = h.DB("SELECT * FROM Routes");
            dataGridView1.DataSource = h.bs1;
        }

        private void Update_Click(object sender, EventArgs e)
        {

            Edit f4 = new Edit();
            f4.ShowDialog();

            h.bs1.DataSource = h.DB("SELECT * FROM Routes");
            dataGridView1.DataSource = h.bs1;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
