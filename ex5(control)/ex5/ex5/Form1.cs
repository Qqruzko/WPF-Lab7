using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace ex5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

        }
        string result;
        public void Proc()
        {
                Thread.Sleep(1000);
                int maxValue = 0;
                System.Text.StringBuilder resultText = new
                System.Text.StringBuilder();
                if (int.TryParse(Input.Text, out maxValue))
                {
                    for (int trial = 2; trial <= maxValue; trial++)
                    {
                        bool isPrime = true;
                        for (int divisor = 2; divisor <= Math.Sqrt(trial); divisor++)
                        {
                            if (trial % divisor == 0)

                            {

                                isPrime = false;

                                break;

                            }
                        }
                        if (isPrime)
                        {
                            resultText.AppendFormat("{0} ", trial);
                        
                        }
                    }
                result = resultText.ToString();
            }
            

                else
                {
                    resultText.Append("Unable to parse maximum value.");
                }
            


        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(Proc));
            thread.Start();
            Proc();
            Output.Text = result;
        }
    }
}
