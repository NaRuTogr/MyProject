using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BDLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            h.conStr = "server = 193.93.216.145; user = sqlkns17_2_srm; database =sqlkns17_2_srm ; password = kns17_srm;";
        }

        
      

        private void маршруткаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bus bus = new Bus();
            bus.Show();
            h.bs1 = new BindingSource();
            h.bs1.DataSource = h.DB("SELECT * FROM Bus");
            bus.dataGridView1.DataSource = h.bs1;
        }

        private void калькуляторToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();

        }
      

        private void маршрутToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Route route = new Route();
            route.Show();
            h.bs1 = new BindingSource();
            h.bs1.DataSource = h.DB("SELECT * FROM Routes");
            route.dataGridView1.DataSource = h.bs1;

        }

        private void водійToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Driver driver = new Driver();
            driver.Show();
            h.bs1 = new BindingSource();
            h.bs1.DataSource = h.DB("SELECT * FROM Driver");
            driver.dataGridView1.DataSource = h.bs1;

        }

        private void зупинкаToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            BusStop busStop = new BusStop();
            busStop.Show();
            h.bs1 = new BindingSource();
            h.bs1.DataSource = h.DB("SELECT * FROM BusStops");
            busStop.dataGridView1.DataSource = h.bs1;

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

            Hide();
            Form4 form4 = new Form4();
            form4.ShowDialog();
            form4 = null;
            Show();

        }

        private void вийтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
           
        }

        private void звітToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zvit zvit = new Zvit();
            zvit.ShowDialog();
            zvit = null;
            Show();
        }
    }
    static class h
    {
        public static BindingSource bs1 { get; set; }
        public static string conStr { get; set; }

        public static string curVa10 { get; set; }
        public static string keyName { get; set; }
        public static string pathToFoto { get; set; }

        public static string typeuser { get; set; }
       
        public static DataTable DB(string sqlStr)

        {
            DataTable dt = new DataTable();
            using (MySqlConnection con = new MySqlConnection(h.conStr))
            {
                MySqlCommand com = new MySqlCommand(sqlStr, con);
                try
                {
                    con.Open();
                    using (MySqlDataReader dr = com.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            dt.Load(dr);

                        }
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return dt;

        }
    }
}
