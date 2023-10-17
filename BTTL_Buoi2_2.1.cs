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
    public partial class BTTL_Buoi2_2 : Form
    {
        public BTTL_Buoi2_2()
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
    }
}
