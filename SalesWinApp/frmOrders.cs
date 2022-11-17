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
using Microsoft.Data.SqlClient;

namespace SalesWinApp
{
    public partial class frmOrders : Form
    {
        string connectionString = @"Data Sourc=(local); Initial Catalog = FStoreDB; Integrated Security=True";
        public frmOrders()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM OrderDetial", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
            }
        }
    }
}
