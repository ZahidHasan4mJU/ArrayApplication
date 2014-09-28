using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArraySample3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int count = 0;
        string[] name = new string[10];
        string[] rank = new string[10];


        private void addButton_Click(object sender, EventArgs e)
        {
            if(enterNameTextBox.Text != "" && rankTextBox.Text != ""){
                name[count] = enterNameTextBox.Text;
                enterNameTextBox.Text = "";
                rank[count] = rankTextBox.Text;
                rankTextBox.Text = "";
                count++;
                countTextBox.Text = count.ToString();
            }


        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            int i = 0;
            while (i < name.Length && i < rank.Length)
            {
                if(name[i] != null && rank[i] != null)
                listBox.Items.Add(name[i] + "->" +rank[i]);
                i++;
            }

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            countTextBox.Text = "0";
        }
    }
}
