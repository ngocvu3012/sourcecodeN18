using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Store_Manager
{
    public partial class InReportForm : Form
    {
        public InReportForm()
        {
            InitializeComponent();

        }

        SqlConnection dataList;

        private void resetSQL(SqlConnection sql)
        {
            sql = null;
        }

        private string conn = @"Data Source = MSI\SQLEXPRESS; Initial Catalog = Project; Integrated Security = True";

        private void InReportForm_Load(object sender, EventArgs e)
        {
            dataList = new SqlConnection(conn);

            this.dataListTableAdapter.Fill(this.ProjectDataSet.dataList);

            this.reportViewer1.RefreshReport();

            dataList.Open();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            dataList.Close();
            dataList.ResetStatistics();
        }
    }
}
