using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP_Z4_WinForms_
{
    public partial class Practica_4 : Form
    {
        public Practica_4()
        {
            InitializeComponent();
        }
        static double Func(int N, int Begin = 0)
        {
            if (Begin == 0)
            {
                return N / Math.Sqrt(Func(N, ++Begin));
            }
            else
            {
                return N == Begin ? N : Begin + Math.Sqrt(Func(N, ++Begin));
            }
        }
        private void Result_Click(object sender, EventArgs e)
        {
            int x = int.Parse(enter_N.Text);
            double a = Func(x);
            function_call.Text = a.ToString();
        }
        static void notation(int i, ref string s)
        {
            if (i > 0)
            {
                notation(i / 2, ref s);
                s += (i % 2).ToString();
            }
        }

        private void Transfer_Click(object sender, EventArgs e)
        {
            int val_10 = int.Parse(num.Text);
            string val_2 = "";
            notation(val_10, ref val_2);
            number.Text = val_10.ToString();
            rez.Text = val_2.ToString();
        }
    }
}
