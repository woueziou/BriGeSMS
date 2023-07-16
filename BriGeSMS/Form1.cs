
using SmSGateWay_Framework;
using System;
using System.Windows.Forms;

namespace BriGeSMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = "";
            textBox1.Focus();
        }

        private void button2_ClickAsync(object sender, EventArgs e)
        {

            try
            {
                if ((textBox1.Text != "") && (textBox2.Text != "") && (textBox3.Text != ""))
                {
                    //MessageBox.Show("Envoi de message réussi", "BriGeSMS");
                   

                    LampushGateWay gateway = new LampushGateWay("AhloncoTogo", "e7jnZF6BjU3X9a7", textBox1.Text);
                    // await gateway.SendMessage("Test from console", "+22890913661");
                    //var t = "";
                    //await Task.Run(t);
                    gateway.SendMessage("test from ahlonco","+22890913661").GetAwaiter().GetResult();
                    button1.PerformClick();
                }
                else
                {
                    MessageBox.Show("Renseignez tous les champs", "BriGeSMS");
                }
            }
            catch (Exception r)
            {
                MessageBox.Show(r.Message, "BriGeSMS");
            }
        }



        private void button4_Click(object sender, EventArgs e)
        {
            LampushGateWay gateway = new LampushGateWay("", "", textBox1.Text);
        }
    }
}
