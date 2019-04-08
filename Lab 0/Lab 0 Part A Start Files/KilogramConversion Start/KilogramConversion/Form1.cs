using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KilogramConversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Display a list of all kilograms, pounds and ounces in
        // the outputListBox when the form is loaded. Use the
        // KgToPounds and PoundsToOunces methods to accomplish
        // the conversions.
        private void Form1_Load(object sender, EventArgs e)
        {
            double pounds, ounces;
            outputListBox.Items.Add("Kilograms    " + "Pounds    " + "Ounces");

            for (int kg = 10; kg <= 25; kg++)
            {
                pounds = KgToPounds(kg);
                ounces = PoundsToOunces(pounds);
                outputListBox.Items.Add(kg.ToString() + "               " + pounds.ToString("n2") + "       " + ounces.ToString("n2"));
            }
            
        }

        // This method called KgToPounds converts kilograms
        // to pounds given kilograms
        private double KgToPounds(double kg)
        {
            return kg * 2.20462;
        }

        // This method called PoundsToOunces converts pounds
        // to ounces given pounds
        private double PoundsToOunces(double pounds)
        {
            return pounds * 16;
        }
    }
}
