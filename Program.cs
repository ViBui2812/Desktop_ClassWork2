using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTL_Buoi2
{
    static class Program
    {
        static public Diem a;
        static public Diem b;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BTTL_Buoi2());
            //Application.Run(new BTTL_Buoi2_2());
        }
    }
    public class Diem
    {
        private double _x;
        private double _y;
        public double x
        {
            get { return _x; }
            set { _x = value; }
        }
        public double y
        {
            get { return _y; }
            set { _y= value; }
        }
        public Diem()
        {  
            x=0;
            y=0;
        }
        public Diem(double x_init, double y_init)
        {
            x = x_init;
            y = y_init;
        }
    }
    class Doanthang
    {
        private Diem _a;
        private Diem _b;
        public Diem A
        {
            get { return _a; }
            set { _a = value; }
        }
        public Diem B
        { 
            get { return  _b; }
            set {  _b = value; }
        }
        public Doanthang()
        {
            A.x = 0;
            A.y = 0;
            B.x = 0;
            B.y = 0;
        }
        public Doanthang(Diem A_init, Diem B_init )
        {
            A = A_init;
            B = B_init;
        }
        public double DoDai()
        {
            return Math.Sqrt(Math.Pow(A.x - B.x, 2) + Math.Pow(A.y - B.y, 2));
        }
    }
}

