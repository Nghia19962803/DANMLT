using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DANMLT
{
    public partial class Form1 : Form
    {
        List<LoaiHang> loaiHangList = new List<LoaiHang>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoaiHang lh;
            lh = new LoaiHang() { tenLH = "nuoc ngot" };
            loaiHangList.Add(lh);
            lh = new LoaiHang() { tenLH = "hai san"};
            loaiHangList.Add(lh);
            lh = new LoaiHang() { tenLH = "thuc an"};
            loaiHangList.Add(lh);
            lh = new LoaiHang() { tenLH = "banh" };
            loaiHangList.Add(lh);
            lh = new LoaiHang() { tenLH = "trai cay"};
            loaiHangList.Add(lh);

            dataGridView1.DataSource = loaiHangList;
        }

        private void them_lhBtn_Click(object sender, EventArgs e)
        {
            LoaiHang lh;
            string s = lhText.Text;
            lh = new LoaiHang() { tenLH = s};
            loaiHangList.Add(lh);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = loaiHangList;
        }
        private void xoaBtn_Click(object sender, EventArgs e)
        {
            int x = dataGridView1.CurrentCell.RowIndex;
            loaiHangList.RemoveAt(x);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = loaiHangList;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchLHBtn_Click(object sender, EventArgs e)
        {
            string s = searchLHText.Text;
            bool exist = false;
            foreach (var ss in loaiHangList)
            {
                if (ss.tenLH == s)
                {
                    List<LoaiHang> a = new List<LoaiHang>();
                    a.Add(ss);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = a;
                    exist = true;
                    //BindingSource bts = new BindingSource();
                    //bts.DataSource = ss;
                    //dataGridView1.DataSource = null;
                    //dataGridView1.DataSource = bts;
                }
            }
            if (!exist)
            {
                MessageBox.Show("ko ton tai loai hang " + s);
            }
        }

        private void ListLHBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = loaiHangList;
        }

        private void suaBtn_Click(object sender, EventArgs e)
        {
            int row = dataGridView1.CurrentCell.RowIndex;
            int column = dataGridView1.CurrentCell.ColumnIndex;

            dataGridView1.Rows[row].Cells[column].Value = suaText.Text;
        }
    }
    struct LoaiHang
    {
        public string tenLH { get; set; }   
        //public int sl;
    }
}
