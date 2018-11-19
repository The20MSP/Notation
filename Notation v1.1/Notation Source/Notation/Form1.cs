using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Notation
{
    public partial class Form1 : Form
    {
        string clipboardText;

        public Form1()
        {
            InitializeComponent();
            textBox7.ScrollBars = ScrollBars.Vertical;
        }

        private void button1_Click(object sender, EventArgs e) //Internal Button
        {
            listBox1.Items.Add(textBox14.Text);
            textBox14.Text = "";
        }

        private void button2_Click(object sender, EventArgs e) //External Button
        {
            listBox2.Items.Add(textBox14.Text);
            textBox14.Text = "";
        }

        private void button3_Click(object sender, EventArgs e) //Submit Button
        {

            string listOfITGLinks = "";
            string[] clist = listBox1.Items.OfType<string>().ToArray();
            foreach (string i in clist)
            {
                listOfITGLinks = listOfITGLinks + Environment.NewLine + i;
            }

            string listOfEXTLinks = "";
            string[] clist2 = listBox2.Items.OfType<string>().ToArray();
            foreach (string i in clist2)
            {
                listOfEXTLinks = listOfEXTLinks + Environment.NewLine + i;
            }

            clipboardText = "Company Name: " + textBox1.Text +
                    Environment.NewLine + "User Name: " + textBox2.Text +
                    Environment.NewLine + "User Contact #: " + textBox3.Text +
                    Environment.NewLine + "User E-mail: " + textBox4.Text +
                    Environment.NewLine + "User Location: " + textBox5.Text + Environment.NewLine +
                    Environment.NewLine + "Problem: " + textBox6.Text + Environment.NewLine +
                    Environment.NewLine + "Troubleshooting: " + Environment.NewLine + textBox7.Text + Environment.NewLine;

            if (checkBox8.Checked)
            {
                clipboardText += Environment.NewLine + "Next Steps: " + textBox8.Text + Environment.NewLine;
            }

            if (checkBox7.Checked)
            {
                clipboardText += Environment.NewLine + "Machine ID: " + textBox9.Text + Environment.NewLine;
            }

            if (checkBox6.Checked)
            {
                clipboardText += Environment.NewLine + "ITG Links Used: " + listOfITGLinks + Environment.NewLine;
            }

            if (checkBox5.Checked)
            {
                clipboardText += Environment.NewLine + "External Links Used: " + listOfEXTLinks + Environment.NewLine;
            }

            if (checkBox1.Checked)
            {
                clipboardText += Environment.NewLine + "E-mail: " + textBox11.Text;
            }

            if (checkBox2.Checked)
            {
                clipboardText += Environment.NewLine + "Password: " + textBox10.Text + Environment.NewLine;
            }

            if (checkBox3.Checked)
            {
                clipboardText += Environment.NewLine + "PC Username: " + textBox12.Text;
            }

            if (checkBox4.Checked)
            {
                clipboardText += Environment.NewLine + "PC Password: " + textBox13.Text;
            }

            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(mydocpath, "Notes.txt"), true))
            {
                outputFile.WriteLine(Environment.NewLine + "-----------------------" + Environment.NewLine + Environment.NewLine + clipboardText);
            }

            MessageBox.Show("Your notes have been successfully added to your clipboard!", "Message:");
                Clipboard.SetText(clipboardText);
        }

        private void button4_Click(object sender, EventArgs e) //Clear Button
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            checkBox1.CheckState = CheckState.Unchecked;
            checkBox2.CheckState = CheckState.Unchecked;
            checkBox3.CheckState = CheckState.Unchecked;
            checkBox4.CheckState = CheckState.Unchecked;
            checkBox5.CheckState = CheckState.Unchecked;
            checkBox6.CheckState = CheckState.Unchecked;
            checkBox7.CheckState = CheckState.Unchecked;
            checkBox8.CheckState = CheckState.Unchecked;
        }

        private void button5_Click(object sender, EventArgs e) //Check all button
        {
            checkBox1.CheckState = CheckState.Checked;
            checkBox2.CheckState = CheckState.Checked;
            checkBox3.CheckState = CheckState.Checked;
            checkBox4.CheckState = CheckState.Checked;
            checkBox5.CheckState = CheckState.Checked;
            checkBox6.CheckState = CheckState.Checked;
            checkBox7.CheckState = CheckState.Checked;
            checkBox8.CheckState = CheckState.Checked;
        }

        private void button6_Click(object sender, EventArgs e) //Uncheck all button
        {
            checkBox1.CheckState = CheckState.Unchecked;
            checkBox2.CheckState = CheckState.Unchecked;
            checkBox3.CheckState = CheckState.Unchecked;
            checkBox4.CheckState = CheckState.Unchecked;
            checkBox5.CheckState = CheckState.Unchecked;
            checkBox6.CheckState = CheckState.Unchecked;
            checkBox7.CheckState = CheckState.Unchecked;
            checkBox8.CheckState = CheckState.Unchecked;
        }

        private void textBox1_TextChanged(object sender, EventArgs e) //Company Name text box
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) //User Name text box
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e) //User Contact # text box
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e) //User e-mail text box
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e) //User location text box
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e) //Troubleshooting text box
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e) //Problem text box
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e) //Next steps text box
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e) //Machine ID text box
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e) //Paste Link Here Text
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) //ITG Links Used List Box
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e) //External Links Used List Box
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e) //E-mail text box
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e) //E-mail password Text box
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e) //PC Username Text box
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e) //PC Password Text Box
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e) //Include next steps
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e) //Include Machine ID
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e) //Include ITG Links
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e) //Include EXT Links
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) //Include E-mail 
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e) //Include E-mail Password
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e) //Include PC Username
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e) //Include PC Password
        {

        }

    }
}
