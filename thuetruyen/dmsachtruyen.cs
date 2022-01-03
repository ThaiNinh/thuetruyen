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
using System.Text.RegularExpressions;
namespace thuetruyen
{
    public partial class dmsachtruyen : Form
    {
        public dmsachtruyen()
        {
            InitializeComponent();
        }
        DataTable tbltt;
        private void dmsachtruyen_Load(object sender, EventArgs e)
        {
            txtmasach.Enabled = false;
            btnluu.Enabled = false;
            btnboqua.Enabled = false;
            loaddatagrid();
            function.ketnoi();
            function.fillcombo("select manxb, tennxb from tblnxb", cbonxb, " manxb", "tennxb");
            cbonxb.SelectedIndex = -1;
        }
        private void loaddatagrid()
        {
            string sql;
            sql = "select masach, tensach, manxb, giasach, soluong from tblsachtruyen";
            tbltt = function.getdatatotable(sql);
            dtgrsachtruyen.DataSource = tbltt;
            dtgrsachtruyen.Columns[0].HeaderText = "Mã sách";
            dtgrsachtruyen.Columns[1].HeaderText = "Tên sách";
            dtgrsachtruyen.Columns[2].HeaderText = "Mã NXB";
            dtgrsachtruyen.Columns[3].HeaderText = "Giá sách";
            dtgrsachtruyen.Columns[4].HeaderText = "Số lượng";

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            resetvalue();
            btnthem.Enabled = false;
            btnluu.Enabled = true;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnboqua.Enabled = true;
            cbonxb.SelectedIndex = -1;
            txtmasach.Enabled = true;
            txtmasach.Focus();

        }
        private void resetvalue()
        {
            txtmasach.Text = "";
            txttensach.Text = "";
            txtsoluong.Text = "0";
            txtgiasach.Text = "0";
            cbonxb.Text = "";

        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            btnthem.Enabled = true;
            btnluu.Enabled = false;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnboqua.Enabled = false;
            txtmasach.Enabled = false;
            resetvalue();
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                Application.Exit();
        }

        private void dtgrsachtruyen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgrsachtruyen_Click(object sender, EventArgs e)
        {
            string ma;
            if (btnthem.Enabled == false)
            {
                MessageBox.Show("Bạn đang ở chế độ thêm sách mới", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmasach.Focus();
                return;
            }
            if (dtgrsachtruyen.Rows.Count == 0)
            {
                MessageBox.Show("không có dữ liệu", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //đủ
            txtmasach.Text = dtgrsachtruyen.CurrentRow.Cells["masach"].Value.ToString();
            txttensach.Text = dtgrsachtruyen.CurrentRow.Cells["tensach"].Value.ToString();
            ma = dtgrsachtruyen.CurrentRow.Cells["manxb"].Value.ToString();
            cbonxb.Text = function.GetFieldValues("select tennxb from tblnxb where manxb = N'" + ma + "'");
            txtgiasach.Text = dtgrsachtruyen.CurrentRow.Cells["giasach"].Value.ToString();
            txtsoluong.Text = dtgrsachtruyen.CurrentRow.Cells["soluong"].Value.ToString();

       
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnboqua.Enabled = true;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (txtmasach.Text == "")
            {
                MessageBox.Show("bạn phải nhập mã sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmasach.Focus();
                return;
            }
            if (txttensach.Text == "")
            {
                MessageBox.Show("bạn phải nhập tên sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txttensach.Focus();
                return;
            }
            if (txtsoluong.Text == "")
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtsoluong.Focus();
                return;
            }
            if (cbonxb.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn Nhà xuất bản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbonxb.Focus();
                return;
            }
            if (txtgiasach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giá sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtgiasach.Focus();
                return;
            }
            string sql;
            sql = "select masach from tblsachtruyen where masach=N'" + txtmasach.Text.Trim() + "'";
            if (function.ktratrungma(sql))
            {
                MessageBox.Show("bị trùng mã sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmasach.Text = "";
                txtmasach.Focus();
                return;
            }
            //đủ
            sql = "insert into tblsachtruyen(masach,tensach, manxb,soluong, giasach) values (N'" +
            txtmasach.Text.Trim() + "',N'" + txttensach.Text.Trim() + "',N'" + cbonxb.SelectedValue  + "',N'" + txtsoluong.Text.Trim() + "',N'" + txtgiasach.Text.Trim() + "')";
            function.Runsql(sql);
            loaddatagrid();
            resetvalue();
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnboqua.Enabled = false;
            btnluu.Enabled = false;
            txtmasach.Enabled = false;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tbltt.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmasach.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txttensach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttensach.Focus();
                return;
            }
            if (cbonxb.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn mã Nhà xuất bản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbonxb.Focus();
                return;
            }
            if (txtsoluong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtsoluong.Focus();
                return;
            }
            if (txtgiasach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giá sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtgiasach.Focus();
                return;
            }
            //đủ
            sql = "update tblsachtruyen set  tensach=N'" + txttensach.Text.Trim().ToString() + "',manxb='" + cbonxb.SelectedValue + "',soluong=N'" + txtsoluong.Text
                  + "',giasach=N'" + txtgiasach.Text.ToString()   + "' where masach=N'" + txtmasach.Text + "'";
            function.Runsql(sql);
            loaddatagrid();
            resetvalue();
            btnboqua.Enabled = false;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tbltt.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmasach.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "delete tblsachtruyen where masach=N'" + txtmasach.Text + "'";
                function.Runsql(sql);
                loaddatagrid();
                resetvalue();
            }
        }
        private static bool IsNumber(string val)
        {
            if (val != "")
                return Regex.IsMatch(val, "[0-9]");
            else return true;
        }



  

        private void txtsoluong_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(txtsoluong.Text) != true)
            {
                MessageBox.Show("Hãy nhập số nguyên dương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtsoluong.Text = "";
            }
        }

        private void txtgiasach_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(txtgiasach.Text) != true)
            {
                MessageBox.Show("Hãy nhập số nguyên dương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtgiasach.Text = "";
            }
        }
    }
}
