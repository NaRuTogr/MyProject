using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace BDLab
{
    public partial class Form4 : Form
    {

  
    public string[,] matrix;
        public Form4()
        {

            InitializeComponent();

            textBox1.UseSystemPasswordChar = true;
            h.conStr = "server = 193.93.216.145; user = sqlkns17_2_srm; database = sqlkns17_2_srm; password = kns17_srm;";

            DataTable dt = h.DB("select * from myUser order by Type asc");

            int count = dt.Rows.Count;

            matrix = new string[count, 4];
            for (int i = 0; i < count; i++)
            {
                matrix[i, 0] = dt.Rows[i].Field<int>("Id").ToString();
                matrix[i, 1] = dt.Rows[i].Field<string>("UserName");
                matrix[i, 2] = dt.Rows[i].Field<int>("Type").ToString();
                matrix[i, 3] = dt.Rows[i].Field<string>("Password");

                comboBox1.Items.Add(matrix[i, 1]);
            }
            comboBox1.Text = matrix[0, 1];
        }

        public static string EncryptedPassword(string s)
        {
            if (string.Compare(s, "null", true) == 0)
                return "NULL";

            byte[] bytes = Encoding.Unicode.GetBytes(s);

            MD5CryptoServiceProvider CSP = new MD5CryptoServiceProvider();

            byte[] byteHash = CSP.ComputeHash(bytes);

            string hash = string.Empty;

            foreach (byte b in byteHash)
                hash += string.Format("{0:x2}", b);

            return hash;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
                if (String.Equals(comboBox1.Text, matrix[i, 1]))
                    if (String.Equals(textBox1.Text, matrix[i, 3]))
                    {
                        h.typeuser = matrix[1, 2];
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Введіть правильний пароль!");
                    }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
