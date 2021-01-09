using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextSummarizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void summarizeButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(headerTextBox.Text) || string.IsNullOrEmpty(bodyTextBox.Text))
            {
                MessageBox.Show("Please fill header and body!");
                return;
            }

            string summary = Summarizer.Execute(headerTextBox.Text, bodyTextBox.Text);

            MessageBox.Show("Summarizing done! Check summary.");

            summaryTextBox.Enabled = true;
            summaryTextBox.ReadOnly = true;
            summaryTextBox.Text = summary;
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            summaryTextBox.Enabled = false;
            summaryTextBox.ReadOnly = false;
            headerTextBox.Text = "";
            bodyTextBox.Text = "";
            summaryTextBox.Text = "";

            MessageBox.Show("Restarted");
        }
    }
}
