using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Generator
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;


            //ALL EVENTS 
            //BUTTONS
            this.btngenerate.Click += Btngenerate_Click;
            this.btncopy.Click += Btncopy_Click;
        }

        private void Btncopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtbox.Text))
            {
                Clipboard.SetText(txtbox.Text);
                MessageBox.Show("Message Copied Successfully", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No Password to Copy", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Btngenerate_Click(object sender, EventArgs e)
        {
            bool includeDigit = chkboxDigit.Checked;
            bool includeSymbol = chkboxSymbol.Checked;
            bool includeUpper = chkboxUpper.Checked;
            bool includeLower = chkboxlower.Checked;


            if (chkboxDigit.Checked|| chkboxlower.Checked || chkboxSymbol.Checked || chkboxUpper.Checked)
            {
                txtbox.Text = GeneratePassword(10, includeDigit, includeUpper, includeLower, includeSymbol);
            }
            else
            {
                txtbox.Text = string.Empty;
            }
        }


        public string GeneratePassword(int Passlength,bool includeDigit, bool includeUpper, bool includeLower, bool includeSymbol)
        {
            const string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string lowerCase = "abcdefghijklmnopqrstuvwxyz";
            const string digits = "0123456789";
            const string symbols = "!@#$%^&*()_+-=[]{}|;:'\",.<>?";

            StringBuilder result = new StringBuilder();

            if (includeDigit)
            {
                result.Append(digits);
            }
            if (includeUpper)
            {
                result.Append(uppercase);
            }
            if (includeLower)
            {
                result.Append(lowerCase);
            }
            if (includeSymbol)
            {
                result.Append(symbols);
            }

            char[] password = new char[Passlength];
            Random random = new Random();  

            for(int i = 0; i < Passlength; i++)
            {
                int indexposition = random.Next(result.Length);

                password[i] = result[indexposition];
            }

            return new string(password);
        }
    }

}
