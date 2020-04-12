using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClientWCF
{
    public partial class Form1 : Form
    {
        APIClient proxy = new APIClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != null && textBox1 != null && textBox7.Text != null)
                proxy.AddTables(comboBox1.Text, textBox7.Text, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // test pentru cautarea dupa nume 
            pictureBox1.Image = Image.FromFile(proxy.SearchElementByName(comboBox1.Text, textBox1.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            proxy.ModifyElementName(comboBox1.Text, textBox1.Text, textBox8.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
           // proxy.DeleteElement(proxy.ReturnIdOfElement(textBox7.Text), comboBox1.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
