using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scientific_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double input = Convert.ToDouble(textInput.Text); 
                string selectedFunction = comboBoxFunctions.SelectedItem.ToString(); 
                double result = 0;

                switch (selectedFunction)
                {
                    case "Sine":
                        result = Math.Sin(DegreeToRadian(input));
                        dataGridView1.Rows.Add("Sine", input, result);
                        break;
                    case "Cosine":
                        result = Math.Cos(DegreeToRadian(input));
                        dataGridView1.Rows.Add("Cosine", input, result);
                        break;
                    case "Tangent":
                        result = Math.Tan(DegreeToRadian(input));
                        dataGridView1.Rows.Add("Tangent", input, result);
                        break;
                    case "Logarithm (Base 10)":
                        result = Math.Log10(input);
                        dataGridView1.Rows.Add("Log10", input, result);
                        break;
                }

                dataGridView1.ClearSelection();
                dataGridView1.Rows[dataGridView1.RowCount - 1].Selected = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input! Please enter a valid number.");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            dataGridView1.Columns.Add("Function", "Function");
            dataGridView1.Columns.Add("Input", "Input");
            dataGridView1.Columns.Add("Result", "Result");

        
            comboBoxFunctions.Items.Add("Sine");
            comboBoxFunctions.Items.Add("Cosine");
            comboBoxFunctions.Items.Add("Tangent");
            comboBoxFunctions.Items.Add("Logarithm (Base 10)");

            comboBoxFunctions.SelectedIndex = 0;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            
        }

    
        private double DegreeToRadian(double degree)
        {
            return degree * (Math.PI / 180);
        }

        private void textInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    
