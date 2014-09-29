using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSVLib;



namespace DailyExpenseApplication
{
    public partial class dailyExpenseAppForm : Form
    {
        public dailyExpenseAppForm()
        {
            InitializeComponent();
        }
        private string fileLocation = @"dailyexpense.csv";

        private void saveButton_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(amountTextBox.Text);
            string category = categoryLeftComboBox.Text;
            string particular = particularTextBox.Text;

            FileStream aFileStream = new FileStream(fileLocation, FileMode.Append);
            CsvFileWriter aCsvFileWriter = new CsvFileWriter(aFileStream);
            List<string> expenseinfo = new List<string>();

            expenseinfo.Add(amount.ToString());
            expenseinfo.Add(category);

            expenseinfo.Add(particular);

            aCsvFileWriter.WriteRow(expenseinfo);
            MessageBox.Show("Information Saved Successfully");
            amountTextBox.Text = "";
            categoryLeftComboBox.Text = "";
            particularTextBox.Text = "";
            aFileStream.Close();

}

        private void showLeftButton_Click(object sender, EventArgs e)
        {
            FileStream aFileStream = new FileStream(fileLocation, FileMode.Open);
            CsvFileReader aStreamReader = new CsvFileReader(aFileStream);
            List<string> expenseinfo = new List<string>();

            //string maximum=expenseinfo.Max();
            //double max = Convert.ToDouble(maximum);
            //maximumexpenseTextBox.Text = max.ToString();

            double totalexpense = 0;
            while (aStreamReader.ReadRow(expenseinfo))
            {
                double amount = Convert.ToDouble(expenseinfo[0]);
                totalexpense += amount;

            }
            totalexpenseTextBox.Text = totalexpense.ToString();
            aFileStream.Close();
           
        }

   
   

     
    }
}
