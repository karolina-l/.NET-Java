using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleApp;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cap, num, see;
            cap = int.Parse(tBCapacity.Text);
            num = int.Parse(tBNumber.Text);
            see = int.Parse(tBSeed.Text);

            List<Item> items = new List<Item>();
            Problem p = new Problem(num, see, cap);
            p.Elements();
            items = p.Solution();
            listBox1.Items.Clear();
            foreach(Item item in items)
            {
                listBox1.Items.Add(item.ToString());
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox box = sender as TextBox;
            int x;
            if(int.TryParse(box.Text, out x))
                box.BackColor = Color.GreenYellow;
            else box.BackColor = Color.Red;
        }

        private void tBResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
