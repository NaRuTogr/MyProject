using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDLab
{
    public partial class Driver : Form
    {
        public Driver()
        {
            InitializeComponent();
        }

     

        private void Driver_Load(object sender, EventArgs e)
        {
            h.bs1 = new BindingSource();
            h.bs1.DataSource = h.DB("SELECT * FROM Driver");
            bindingNavigator1.BindingSource = h.bs1;
            dataGridView1.DataSource = h.bs1;

            h.bs1.Sort = "idDriver";

            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.White;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;

            dataGridView1.RowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Silver;

        }

          

        private void bindingNavigatorSearch_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            label1.Visible = true;
            label1.Text = "Пошук";
            textBox1.Focus();

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            label1.Visible = false;
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

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                h.bs1.Filter = textBox2.Text;
                textBox2.Visible = false;
                label2.Visible = false;
                label3.Visible = false;

            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            h.bs1.Filter = textBox2.Text;
            textBox2.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            h.bs1.Filter = textBox2.Text;
            textBox2.Visible = false;
            label2.Visible = false;
            label3.Visible = false;

        }

        private void Search_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            label1.Visible = true;
            label1.Text = "Пошук";
            textBox1.Focus();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }

            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Insert f1add = new Insert();
            f1add.ShowDialog();
            h.bs1.DataSource = h.DB("select * from Driver");
            dataGridView1.DataSource = h.bs1;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            h.curVa10 = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            h.keyName = dataGridView1.Columns[0].Name;

            Delete f3 = new Delete();
            f3.ShowDialog();

            h.bs1.DataSource = h.DB("SELECT * FROM Driver");
            dataGridView1.DataSource = h.bs1;
        }

        private void Update_Click(object sender, EventArgs e)
        {
            Edit f4 = new Edit();
            f4.ShowDialog();

            h.bs1.DataSource = h.DB("SELECT * FROM Driver");
            dataGridView1.DataSource = h.bs1;
        }
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int rIndx = dataGridView1.CurrentCell.RowIndex;
            if (rIndx < dataGridView1.RowCount - 1)
            {
                byte[] a = (byte[])dataGridView1.Rows[rIndx].Cells[7].Value;
                MemoryStream memImage = new MemoryStream(a);
                pictureBox1.Image = Image.FromStream(memImage);
                memImage.Close();
            }
            else
            {
                pictureBox1.Image = null;
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
