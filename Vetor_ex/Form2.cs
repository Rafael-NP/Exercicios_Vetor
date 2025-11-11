using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vetor_ex
{
    public partial class frmex1 : Form
    {
        public frmex1()
        {
            InitializeComponent();
        }
        double[] A = new double[15];
        double[] B = new double[15];
        int i = 0;

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (i <= 14)
            {
                A[i] = Convert.ToDouble(txtnum.Text);
                B[i] = A[i] * A[i];
                txtnum.Clear();
                txtnum.Focus();
                txtaddnum.Text = (1 + i).ToString();
                i++;
            }
            if (i > 14)
            {
                btnmostrar.Enabled = true;
                btnadd.Enabled = false;
                txtnum.Enabled = false;
            }
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            for (i = 0; i <= 14; i++)
            {
                txtA.AppendText($"{A[i]:0.##}\r\n");
                txtB.AppendText($"{B[i]:0.##}\r\n");
            }
            btnmostrar.Enabled = false;
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtnum.Clear();
            txtnum.Enabled = true;
            txtnum.Focus();
            btnadd.Enabled = true;
            Array.Clear(A, 0, A.Length);
            Array.Clear(B, 0, B.Length);
            i = 0;
            txtaddnum.Text = i.ToString();
        }
    }
}
