using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace hesap_makinesi_form_ile
{
    public partial class Form1 : Form
    {
        private char _işlem;
        int _ilksayı;
        bool _ekrantemizlenecekmi;



        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                EkranLabel.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (EkranLabel.Text == "0") EkranLabel.Text = "";
            EkranLabel.Text += "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                EkranLabel.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (EkranLabel.Text == "0") EkranLabel.Text = "";
            EkranLabel.Text += "3";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                EkranLabel.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (EkranLabel.Text == "0") EkranLabel.Text = "";
            EkranLabel.Text += "2";
        }

        private void buttonARTI_Click(object sender, EventArgs e)
        {
            _işlem = '+';
            _ekrantemizlenecekmi = true;
            _ilksayı = Convert.ToInt32(EkranLabel.Text);
        }

        private void buttonEKSI_Click(object sender, EventArgs e)
        {
            _işlem = '-';
            _ekrantemizlenecekmi = true;
            _ilksayı = Convert.ToInt32(EkranLabel.Text);
        }

        private void buttoneşittir_Click(object sender, EventArgs e)
        {
            int _ikincisayı = Convert.ToInt32(EkranLabel.Text);
            int sonuç;
            switch (_işlem)
            {

                case '+':
                    sonuç = _ilksayı + _ikincisayı;
                    break;
                case '-':
                    sonuç = _ilksayı - _ikincisayı;
                    break;
                case '*':
                    sonuç = _ilksayı * _ikincisayı;
                    break;
                case '/':
                    sonuç = _ilksayı / _ikincisayı;
                    break;

                default:
                    sonuç = 0;
                    break;

            }
            EkranLabel.Text = Convert.ToString(sonuç);



        }

        private void buttonARTI_Click_1(object sender, EventArgs e)
        {
            _işlem = '+';
            _ekrantemizlenecekmi = true;
            _ilksayı = Convert.ToInt32(EkranLabel.Text);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

            if (_ekrantemizlenecekmi)
            {
                EkranLabel.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (EkranLabel.Text == "0") EkranLabel.Text = "";
            EkranLabel.Text += "4";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                EkranLabel.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (EkranLabel.Text == "0") EkranLabel.Text = "";
            EkranLabel.Text += "0";
        }

        private void buttonBÖLME_Click_1(object sender, EventArgs e)
        {
            _işlem = '/';
            _ekrantemizlenecekmi = true;
            _ilksayı = Convert.ToInt32(EkranLabel.Text);
        }

        private void buttonÇARPMA_Click_1(object sender, EventArgs e)
        {
            _işlem = '*';
            _ekrantemizlenecekmi = true;
            _ilksayı = Convert.ToInt32(EkranLabel.Text);
        }

        private void buttonEKSI_Click_1(object sender, EventArgs e)
        {
            _işlem = '-';
            _ekrantemizlenecekmi = true;
            _ilksayı = Convert.ToInt32(EkranLabel.Text);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                EkranLabel.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (EkranLabel.Text == "0") EkranLabel.Text = "";
            EkranLabel.Text += "5";
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                EkranLabel.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (EkranLabel.Text == "0") EkranLabel.Text = "";
            EkranLabel.Text += "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                EkranLabel.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (EkranLabel.Text == "0") EkranLabel.Text = "";
            EkranLabel.Text += "9";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                EkranLabel.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (EkranLabel.Text == "0") EkranLabel.Text = "";
            EkranLabel.Text += "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                EkranLabel.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (EkranLabel.Text == "0") EkranLabel.Text = "";
            EkranLabel.Text += "7";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            EkranLabel.Text = "0";
        }
    }
}
