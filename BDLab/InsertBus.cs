using MySql.Data.MySqlClient;
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
    public partial class InsertBus : Form
    {
        public InsertBus()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(h.conStr))
            {
                string tb1 = textBox1.Text;
                string tb2 = textBox2.Text;
                string tb3 = textBox3.Text;
                string tb4 = textBox4.Text;
                string tb5 = textBox5.Text;
                string tb6 = textBox6.Text;
              

                int FileSize;
                byte[] rawData;
                FileStream fs;
                string strFileName;

                     strFileName = h.pathToFoto;
                     fs = new FileStream(strFileName, FileMode.Open, FileAccess.Read);
                     FileSize = (Int32)fs.Length;
                     rawData = new byte[FileSize];
                     fs.Read(rawData, 0, FileSize);
                     fs.Close();
                     


                string sql = "INSERT INTO Bus (idBus, NumberBus, Model, Color, NumberOfSeats, idDriver, BusPhoto)" + "VALUES (@TK1, @TK2, @TK3, @TK4, @TK5, @TK6, @File)"; // добавити @File
                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@TK1", tb1);
                cmd.Parameters.AddWithValue("@TK2", tb2);
                cmd.Parameters.AddWithValue("@TK3", tb3);
                cmd.Parameters.AddWithValue("@TK4", tb4);
                cmd.Parameters.AddWithValue("@TK5", tb5);
                cmd.Parameters.AddWithValue("@TK6", tb6);
             

                 cmd.Parameters.AddWithValue("@File", rawData);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Додавання запису пройшло вдало");
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Виберіть файл";
            openFileDialog1.Filter = "img files (*.jpg)|*.jpg|bmp file (*.bmp)|*.bmp|All files (*.*)|*.*";
            openFileDialog1.InitialDirectory = Application.StartupPath;

            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            {
                h.pathToFoto = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(h.pathToFoto);
            }
        }
    }
    }

