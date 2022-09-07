using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
namespace QuanLyNhanSu.CT
{
    public partial class InHoaDon : UserControl
    {
        SqlConnection ketnoi = new SqlConnection();
        SqlCommand lenh = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        CauLenh cl = new CauLenh();
        tkCauLenh tkcl = new tkCauLenh();
        DataTable dt = new DataTable();
        public InHoaDon()
        {
            InitializeComponent();
            ketnoi.ConnectionString = Properties.Settings.Default.QlNhanSuConnectionString;
            ketnoi.Open();
            lenh.Connection = ketnoi;
            lenh.CommandType = CommandType.StoredProcedure;
        }
        void NapDSNV()
        {
            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void InHoaDon_Load(object sender, EventArgs e)
        {
            NapDSNV();
        }
    }
}
