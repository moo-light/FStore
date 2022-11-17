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
using Xamarin.Forms;

namespace SalesWinApp
{
    public partial class frmOrders : Form
    {
        string path = @"Data Sourc=(local); Initial Catalog = FStoreDB; Integrated Security=True";
        public frmOrders()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (SqlConnection sqlConnect = new SqlConnection(path))
            {
                sqlConnect.Open();
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM OrderDetial", sqlConnect);
                DataTable dt = new DataTable();
                sqlData.Fill(dt);

                DataView dv = new DataView(dt);
                dataGridView1.DataSource = dv;
                
            }
        }

        private void btnClose1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
