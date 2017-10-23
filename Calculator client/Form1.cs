using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator_client.CalculatorServiceReference;
using System.ServiceModel;

namespace Calculator_client
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            CalcClient client = new CalcClient();
            double a, b;
            double.TryParse(tbA.Text, out a);
            double.TryParse(tbB.Text, out b);

            tbResult.Text = client.Add(a, b).ToString();

            try
            {
                client.Close();
            }
            catch (Exception)
            {
                client.Abort();
            }
        }

        private void bSub_Click(object sender, EventArgs e)
        {
            CalcClient client = new CalcClient();
            double a, b;
            double.TryParse(tbA.Text, out a);
            double.TryParse(tbB.Text, out b);

            tbResult.Text = client.Sub(a, b).ToString();

            try
            {
                client.Close();
            }
            catch (Exception)
            {
                client.Abort();
            }
        }

        private void bMulti_Click(object sender, EventArgs e)
        {
            CalcClient client = new CalcClient();
            double a, b;
            double.TryParse(tbA.Text, out a);
            double.TryParse(tbB.Text, out b);

            tbResult.Text = client.Mult(a, b).ToString();

            try
            {
                client.Close();
            }
            catch (Exception)
            {
                client.Abort();
            }
        }

        private void bDiv_Click(object sender, EventArgs e)
        {
            CalcClient client = new CalcClient();
            double a, b;
            double.TryParse(tbA.Text, out a);
            double.TryParse(tbB.Text, out b);

            try
            {
                client.Open();
                double res = client.Div(a, b);
                tbResult.Text = res.ToString();
            }
            catch (FaultException ex)
            {
                MessageBox.Show(ex.Message);
            }
           

            try
            {
                client.Close();
            }
            catch (Exception)
            {
                client.Abort();
            }
        }

        private void bAddComplex_Click(object sender, EventArgs e)
        {
            CalcClient client = new CalcClient();
            double aReal, aImagine, bReal, bImagine;
            double.TryParse(tbAReal.Text, out aReal);
            double.TryParse(tbAImagine.Text, out aImagine);
            double.TryParse(tbBReal.Text, out bReal);
            double.TryParse(tbBImagine.Text, out bImagine);

            Complex a = new Complex();
            Complex b = new Complex();
            a._real = aReal;
            a._imag = aImagine;
            b._real = bReal;
            b._imag = bImagine;
            Complex result = client.ComplexAdd(a, b);

            tbResultComplex.Text = result._real + " + i" + result._imag;

            try
            {
                client.Close();
            }
            catch (Exception)
            {
                client.Abort();
            }
        }

        private void bSubComplex_Click(object sender, EventArgs e)
        {
            CalcClient client = new CalcClient();
            double aReal, aImagine, bReal, bImagine;
            double.TryParse(tbAReal.Text, out aReal);
            double.TryParse(tbAImagine.Text, out aImagine);
            double.TryParse(tbBReal.Text, out bReal);
            double.TryParse(tbBImagine.Text, out bImagine);

            Complex a = new Complex();
            Complex b = new Complex();
            a._real = aReal;
            a._imag = aImagine;
            b._real = bReal;
            b._imag = bImagine;
            Complex result = client.ComplexSub(a, b);

            tbResultComplex.Text = result._real + " + i" + result._imag;

            try
            {
                client.Close();
            }
            catch (Exception)
            {
                client.Abort();
            }
        }

        private void bMultiComplex_Click(object sender, EventArgs e)
        {
            CalcClient client = new CalcClient();
            double aReal, aImagine, bReal, bImagine;
            double.TryParse(tbAReal.Text, out aReal);
            double.TryParse(tbAImagine.Text, out aImagine);
            double.TryParse(tbBReal.Text, out bReal);
            double.TryParse(tbBImagine.Text, out bImagine);

            Complex a = new Complex();
            Complex b = new Complex();
            a._real = aReal;
            a._imag = aImagine;
            b._real = bReal;
            b._imag = bImagine;
            Complex result = client.ComplexMult(a, b);

            tbResultComplex.Text = result._real + " + i" + result._imag;

            try
            {
                client.Close();
            }
            catch (Exception)
            {
                client.Abort();
            }
        }

        private void bDivComplex_Click(object sender, EventArgs e)
        {
            CalcClient client = new CalcClient();
            double aReal, aImagine, bReal, bImagine;
            double.TryParse(tbAReal.Text, out aReal);
            double.TryParse(tbAImagine.Text, out aImagine);
            double.TryParse(tbBReal.Text, out bReal);
            double.TryParse(tbBImagine.Text, out bImagine);

            Complex a = new Complex();
            Complex b = new Complex();
            a._real = aReal;
            a._imag = aImagine;
            b._real = bReal;
            b._imag = bImagine;

            try
            {
                Complex result = client.ComplexDiv(a, b);
                tbResultComplex.Text = result._real + " + i" + result._imag;
                client.Close();
            }
            catch (FaultException ex)
            {
                MessageBox.Show(ex.Message);
                client.Abort();
            }
            catch (Exception)
            {
                client.Abort();
            }
        }
    }
}
