using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_CS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void licz_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(TextBoxWartosc1.Text);
                double b = double.Parse(TextBoxWartosc2.Text);
                double c=0;
                String operacja = DropDownListDzialanie.SelectedItem.ToString();
                String dzieleniePrzezZero = "Nie można dzielić przez 0";


                switch (operacja)
                {
                    case "+":
                        c = a + b;
                        break;
                    case "-":
                        c = a - b;
                        break;
                    case "*":
                        c = a * b;
                        break;
                    case "/":
                        if (b != 0)
                        {
                            c = a / b;
                        }

                        break;
                }

                if (operacja == "/" && b == 0)
                {
                    TextBoxWynik.Text = dzieleniePrzezZero;
                }
                else
                {
                    TextBoxWynik.Text = c.ToString();
                }
                

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                //throw;
            }
        }

        private void DropDownListDzialanie_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
