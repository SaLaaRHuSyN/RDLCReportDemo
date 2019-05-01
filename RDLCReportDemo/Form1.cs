using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RDLCReportDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DsSales.tbl_FullSales' table. You can move, or remove it, as needed.
            this.tbl_FullSalesTableAdapter.Fill(this.DsSales.tbl_FullSales);

            this.reportViewer1.RefreshReport();
        }
    }
}
