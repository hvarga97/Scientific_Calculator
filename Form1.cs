using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analiza_6
{
    public partial class Form1 : Form
    {
        public string no1, constfun;
        public bool inputstatus;
        public Form1()
        {
            InitializeComponent();
        }

        private void bizlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void b0_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
               tbunos.Text += b0.Text;
            }
            else
            {
                tbunos.Text = b0.Text;
                inputstatus = true;
            }
        }

        private void b1_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                tbunos.Text += b1.Text;
            }
            else
            {
                tbunos.Text = b1.Text;
                inputstatus = true;
            }
        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                tbunos.Text += b2.Text;
            }
            else
            {
                tbunos.Text = b2.Text;
                inputstatus = true;
            }
        }

        private void b3_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                tbunos.Text += b3.Text;
            }
            else
            {
                tbunos.Text = b3.Text;
                inputstatus = true;
            }
        }

        private void b4_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                tbunos.Text += b4.Text;
            }
            else
            {
                tbunos.Text = b4.Text;
                inputstatus = true;
            }
        }

        private void b5_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                tbunos.Text += b5.Text;
            }
            else
            {
                tbunos.Text = b5.Text;
                inputstatus = true;
            }
        }

        private void b6_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                tbunos.Text += b6.Text;
            }
            else
            {
                tbunos.Text = b6.Text;
                inputstatus = true;
            }
        }

        private void b7_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                tbunos.Text += b7.Text;
            }
            else
            {
                tbunos.Text = b7.Text;
                inputstatus = true;
            }
        }

        private void b8_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                tbunos.Text += b8.Text;
            }
            else
            {
                tbunos.Text = b8.Text;
                inputstatus = true;
            }
        }

        private void b9_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                tbunos.Text += b9.Text;
            }
            else
            {
                tbunos.Text = b9.Text;
                inputstatus = true;
            }
        }

        private void bzbrajanje_Click(object sender, EventArgs e)
        {
            no1 = tbunos.Text;
            tbunos.Text = "";
            constfun = "+";
        }

        private void buoduzimanje_Click(object sender, EventArgs e)
        {
            no1 = tbunos.Text;
            tbunos.Text = "";
            constfun = "-";
        }

        private void bumnozak_Click(object sender, EventArgs e)
        {
            no1 = tbunos.Text;
            tbunos.Text = "";
            constfun = "*";
        }

        private void bpodjeljeno_Click(object sender, EventArgs e)
        {
            no1 = tbunos.Text;
            tbunos.Text = "";
            constfun = "/";
        }
        private void funcal()
        {
            switch (constfun)
            {
                case "+":
                    tbunos.Text = Convert.ToString(Convert.ToInt32(no1) + Convert.ToInt32(tbunos.Text));
                    break;
                case "-":
                    tbunos.Text = Convert.ToString(Convert.ToInt32(no1) - Convert.ToInt32(tbunos.Text));
                    break;
                case "*":
                    tbunos.Text = Convert.ToString(Convert.ToInt32(no1) * Convert.ToInt32(tbunos.Text));
                    break;
                case "/":
                    if (tbunos.Text == "0")
                    {
                        tbunos.Text = "infinity";
                    }
                    else
                    {
                        tbunos.Text = Convert.ToString(Convert.ToInt32(no1) / Convert.ToInt32(tbunos.Text));
                    }
                    break;
            }
        }

        private void bizracun_Click(object sender, EventArgs e)
        {
            funcal();
            inputstatus = false;
        }

        private void bac_Click(object sender, EventArgs e)
        {
            tbunos.Enabled = true;
            tbunos.Text = "0";
        }

        private void bsqrt_Click(object sender, EventArgs e)
        {
            tbunos.Text = Convert.ToString(System.Math.Sqrt(Convert.ToDouble(tbunos.Text)));
            inputstatus = false;
        }

        private void bce_Click(object sender, EventArgs e)
        {
            tbunos.Text = String.Empty;
            inputstatus = true;
        }

        private void bpi_Click(object sender, EventArgs e)
        {
            tbunos.Text = "3.141592654";
        }

        private void bsin_Click(object sender, EventArgs e)
        {
            tbunos.Text = Convert.ToString(System.Math.Sin((Convert.ToDouble(System.Math.PI) / 180) * (Convert.ToDouble(tbunos.Text))));
            inputstatus = false;
        }

        private void bcos_Click(object sender, EventArgs e)
        {
            tbunos.Text = Convert.ToString(System.Math.Cos((Convert.ToDouble(System.Math.PI) / 180) * (Convert.ToDouble(tbunos.Text))));
            inputstatus = false;
        }

        private void btan_Click(object sender, EventArgs e)
        {
            tbunos.Text = Convert.ToString(System.Math.Tan((Convert.ToDouble(System.Math.PI) / 180) * (Convert.ToDouble(tbunos.Text))));
            inputstatus = false;
        }

        private void blog_Click(object sender, EventArgs e)
        {
            tbunos.Text = Convert.ToString(System.Math.Log(Convert.ToDouble(tbunos.Text)));
            inputstatus = false;
        }

        private void bbackspace_Click(object sender, EventArgs e)
        {
            no1 = tbunos.Text;
            int n = no1.Length;
            tbunos.Text = (no1.Substring(0, n - 1));
        }

        private void bdecimal_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                tbunos.Text += bdecimal.Text;
            }
            else
            {
                tbunos.Text = bdecimal.Text;
                inputstatus = true;
            }
        }
    }
}
