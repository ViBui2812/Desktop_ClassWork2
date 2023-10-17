using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTL_Buoi2
{
    public partial class BTTL_Buoi2 : Form
    {
        public BTTL_Buoi2()
        {
            InitializeComponent();
            Init();
        }
        Diem a;
        Diem b;
        public void Init()
        {
            a = new Diem();
            b = new Diem();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNhapA_Click(object sender, EventArgs e)
        {
            a.x = double.Parse(txtAx.Text);
            a.y= double.Parse(txtAy.Text);
        }

        private void btnNhapB_Click(object sender, EventArgs e)
        {
            b.x = double.Parse(txtBx.Text);
            b.y = double.Parse(txtBy.Text);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add($"Điểm A ({a.x}, {a.y})");
            listBox1.Items.Add($"Điểm B ({b.x}, {b.y})");
            //Doanthang DT = new Doanthang();
            //DT.A = a;
            //DT.B = b;
            Doanthang DT = new Doanthang(a,b);
            listBox1.Items.Add($"Do dai = {DT.DoDai()}");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BTTL_Buoi2_Load(object sender, EventArgs e)
        {

        }

        private void txtAy_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
