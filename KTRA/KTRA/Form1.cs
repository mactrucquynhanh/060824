using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTRA
{
    public partial class frmSanPham : Form

    {
        string strConnectionString = "Data Source=MSI\\SQLEXPRESS24\\SQLEXPRESS;Initial Catalog =QLSanPham; Integrated Security = True";
        // Đối tượng kết nối
        SqlConnection conn = null;
        // Đối tượng đưa dữ liệu vào DataTable dtTABLENAME
        SqlDataAdapter daSP = null;
        // Đối tượng hiển thị dữ liệu lên Form
        DataTable dtSP = null;


        public frmSanPham()
        {
            InitializeComponent();
        }
    }
    private void Label2_Click(object sender, EventArgs e)
    {

    }

    private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void Form_Load(object sender, EventArgs e)








}

