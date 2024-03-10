using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23MY03009_odev_no02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void hesapla_Click(object sender, EventArgs e)
        {
            try
            {
                double boydouble = Convert.ToDouble(boyunuzgir.Text)/100;
                double kilo = Convert.ToDouble(kilonuzgir.Text);
                int yas = Convert.ToInt32(yasinizgir.Text);

                double endekshesap = kilo / (boydouble * boydouble);

                if (yas<=24)
                {
                    if (endekshesap < 19)
                    {
                        endeks.Text = Convert.ToString(endekshesap);
                        durumunuz.Text = "Normal Kilonun Altındasınız.";
                    }
                    else if (endekshesap >= 19 && endekshesap<=24)
                    {
                        endeks.Text = Convert.ToString(endekshesap);
                        durumunuz.Text = "İdeal Kilodasınız.";
                    }
                    else if(endekshesap > 24)
                    {
                        endeks.Text = Convert.ToString(endekshesap);
                        durumunuz.Text = "İdeal Kilonun Üzerindesiniz.";
                    }
                }
                else if (yas > 24 && yas <= 34)
                {
                    if (endekshesap < 20)
                    {
                        endeks.Text = Convert.ToString(endekshesap);
                        durumunuz.Text = "Normal Kilonun Altındasınız.";
                    }
                    else if (endekshesap >= 20 && endekshesap <= 25)
                    {
                        endeks.Text = Convert.ToString(endekshesap);
                        durumunuz.Text = "İdeal Kilodasınız.";
                    }
                    else if (endekshesap > 25)
                    {
                        endeks.Text = Convert.ToString(endekshesap);
                        durumunuz.Text = "İdeal Kilonun Üzerindesiniz.";
                    }
                }
                else if (yas > 34 && yas <= 44)
                {
                    if (endekshesap < 21)
                    {
                        endeks.Text = Convert.ToString(endekshesap);
                        durumunuz.Text = "Normal Kilonun Altındasınız.";
                    }
                    else if (endekshesap >= 21 && endekshesap <= 26)
                    {
                        endeks.Text = Convert.ToString(endekshesap);
                        durumunuz.Text = "İdeal Kilodasınız.";
                    }
                    else if (endekshesap > 26)
                    {
                        endeks.Text = Convert.ToString(endekshesap);
                        durumunuz.Text = "İdeal Kilonun Üzerindesiniz.";
                    }
                }
                else if (yas > 44 && yas <= 54)
                {
                    if (endekshesap < 22)
                    {
                        endeks.Text = Convert.ToString(endekshesap);
                        durumunuz.Text = "Normal Kilonun Altındasınız.";
                    }
                    else if (endekshesap >= 22 && endekshesap <= 27)
                    {
                        endeks.Text = Convert.ToString(endekshesap);
                        durumunuz.Text = "İdeal Kilodasınız.";
                    }
                    else if (endekshesap > 27)
                    {
                        endeks.Text = Convert.ToString(endekshesap);
                        durumunuz.Text = "İdeal Kilonun Üzerindesiniz.";
                    }
                }
                else if (yas > 55 && yas <= 64)
                {
                    if (endekshesap < 23)
                    {
                        endeks.Text = Convert.ToString(endekshesap);
                        durumunuz.Text = "Normal Kilonun Altındasınız.";
                    }
                    else if (endekshesap >= 23 && endekshesap <= 28)
                    {
                        endeks.Text = Convert.ToString(endekshesap);
                        durumunuz.Text = "İdeal Kilodasınız.";
                    }
                    else if (endekshesap > 28)
                    {
                        endeks.Text = Convert.ToString(endekshesap);
                        durumunuz.Text = "İdeal Kilonun Üzerindesiniz.";
                    }
                }
                else if (yas >= 65)
                {
                    if (endekshesap < 24)
                    {
                        endeks.Text = Convert.ToString(endekshesap);
                        durumunuz.Text = "Normal Kilonun Altındasınız.";
                    }
                    else if (endekshesap >= 24 && endekshesap <= 29)
                    {
                        endeks.Text = Convert.ToString(endekshesap);
                        durumunuz.Text = "İdeal Kilodasınız.";
                    }
                    else if (endekshesap > 29)
                    {
                        endeks.Text = Convert.ToString(endekshesap);
                        durumunuz.Text = "İdeal Kilonun Üzerindesiniz.";
                    }
                }
            }

            catch (Exception ex) {
                MessageBox.Show("Lütfen Bilgileriniz Doğru Girdiğinizden Emin Olunuz.");
            }
            

        }
    }
}
