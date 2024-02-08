using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Order
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            /*listBox2.Items.Add(listBox1.SelectedItem.ToString());*/

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int x = listBox2.SelectedIndices.Count - 1; x >= 0; x--)
            {
                int idx = listBox2.SelectedIndices[x];
                listBox2.Items.RemoveAt(idx);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int x = listBox1.SelectedIndices.Count - 1; x >= 0; x--)
            {
                int idx = listBox1.SelectedIndices[x];
                listBox2.Items.Add(listBox1.Items[idx]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }
    }
}
