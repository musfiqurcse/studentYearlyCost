using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculatorApp
{
    public partial class CalculatorSalaryUI : Form
    {
        public CalculatorSalaryUI()
        {
            InitializeComponent();
        }
        Employee aEmployee = new Employee();
        private void showButton_Click(object sender, EventArgs e)
        {
            aEmployee.employeeName=nameTextBox.Text;
            aEmployee.amount = Convert.ToDouble(amountTextBox.Text);
            aEmployee.rent=Convert.ToDouble(rentTextBox.Text);
            aEmployee.medicalAllowence = Convert.ToDouble(medicalTextBox.Text);

            double salary = (aEmployee.CalculateSalary());
            MessageBox.Show(aEmployee.employeeName + " Your total salary Is : " +salary);


            nameTextBox.Clear();
            rentTextBox.Clear();
            amountTextBox.Clear();
            medicalTextBox.Clear();
        }
    }
}
