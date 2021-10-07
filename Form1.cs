using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double bill_value = Convert.ToDouble(bill.Text);
            double tip_PERC = Convert.ToDouble(tip_perc.Value);
            double people = Convert.ToDouble(no_of_people.Value);
            if (people == 0)
                people = 1;
            double tip = (tip_PERC * bill_value) / (100*people);
            double total = (bill_value / people) + tip;
            tip_person.Text = "$" + Convert.ToString(tip);
            total_bill.Text = "$" + Convert.ToString(total);
        }

        
    }
}
