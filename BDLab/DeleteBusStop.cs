using MySql.Data.MySqlClient;
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
    public partial class DeleteBusStop : Form
    {
        public DeleteBusStop()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlStr = "DELETE FROM BusStops WHERE " + textBox1.Text;

            //MessageBox.Show(sqlStr);

            if (MessageBox.Show("Ви впевнені що хочете видалити запис", "Видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (MySqlConnection con = new MySqlConnection(h.conStr))
                {
                    MySqlCommand cmd = new MySqlCommand(sqlStr, con);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            this.Close();
        }
    }
}
