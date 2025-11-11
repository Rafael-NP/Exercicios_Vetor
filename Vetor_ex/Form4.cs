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
    public partial class frmex3 : Form
    {
        public frmex3()
        {
            InitializeComponent();
        }

        double[] A = new double[30];
        double[] B = new double[30];
        int i = 0;

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtcubo.Clear();
            txtn.Clear();
            txtsearch.Clear();
            txtnum.Clear();
            txtnum.Enabled = true;
            txtnum.Focus();
            btnadd.Enabled = true;
            Array.Clear(A, 0, A.Length);
            Array.Clear(B, 0, B.Length);
            i = 0;
            txtaddnum.Text = i.ToString();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtcubo.Clear();
            txtn.Clear();
            txtsearch.Clear();
            txtnum.Clear();
            txtsearch.Focus();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (i <= 29)
            {
                A[i] = Convert.ToDouble(txtnum.Text);
                B[i] = Math.Pow(A[i], 3.0);
                txtnum.Clear();
                txtnum.Focus();
                txtaddnum.Text = (1 + i).ToString();
                i++;
            }
            if (i > 29)
            {
                txtnum.Enabled = false;
                btnadd.Enabled = false;
                txtsearch.Focus();
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            Int32 s;
            s = Convert.ToInt32(txtsearch.Text);
            if (s <= i)
            {
                txtcubo.Text = B[s - 1].ToString();
                txtn.Text = A[s - 1].ToString();
            }
            else
            {
                MessageBox.Show("Número não encontrado.");
                txtsearch.Clear();
                txtsearch.Focus();
            }
        }
    }
}
