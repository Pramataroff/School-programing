using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_reservation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("18:00");
            comboBox1.Items.Add("18:30");
            comboBox1.Items.Add("19:00");
            comboBox1.Items.Add("19:30");
            comboBox1.Items.Add("20:00");
            comboBox1.Items.Add("20:30");
            comboBox1.Items.Add("21:00");
            comboBox1.Items.Add("21:30");
            comboBox1.Items.Add("22:00");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter your name.");
                textBox1.Focus();
                return;
            }

            if (numericUpDown1.Value < 1)
            {
                MessageBox.Show("Please enter a valid number of guests.");
                numericUpDown1.Focus();
                return;
            }

            if (dateTimePicker.Value.Date < DateTime.Today)
            {
                MessageBox.Show("Please select a valid date.");
                dateTimePicker.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("Please select an hour.");
                comboBox1.Focus();
                return;
            }

            if (!string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show(
                    $"You made a reservation for {numericUpDown1.Value} people on the name: {textBox1.Text} for {dateTimePicker.Value.ToShortDateString()} at {comboBox1.Text} with special option: {textBox2.Text}.","Well done you did a great job!!!");
                textBox1.Clear();
                numericUpDown1.ResetText();
                dateTimePicker.ResetText();
                comboBox1.ResetText();
                textBox2.ResetText();
            }
            else
            {
                MessageBox.Show(
                    $"You made a reservation for {numericUpDown1.Value} people on the name: {textBox1.Text} for {dateTimePicker.Value.ToShortDateString()} at {comboBox1.Text}.", "Well done you did a great job!!!");
                textBox1.Clear();
                numericUpDown1.ResetText();
                dateTimePicker.ResetText();
                comboBox1.ResetText();
                textBox2.ResetText();
            }
        }
    }

}
