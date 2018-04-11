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
    public partial class Zvit : Form
    {
        public Zvit()
        {
            InitializeComponent();
        }

        

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.DataSet1.DataTable1);

            this.reportViewer1.RefreshReport();
        }

        private void Zvit_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "DataSet1.DataTable1". При необходимости она может быть перемещена или удалена.
            this.DataTable1TableAdapter.Fill(this.DataSet1.DataTable1);

            this.reportViewer1.RefreshReport();
        }
    }
}
