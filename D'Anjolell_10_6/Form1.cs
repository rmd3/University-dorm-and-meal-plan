using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D_Anjolell_10_6
{
    public partial class CalculateTotal : Form
    {
        public CalculateTotal()
        {
            InitializeComponent();
        }

        //Declare public variable
        public int dormMealTotal;

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //Richard D'Anjolell
            //Declare variables
            int dormPlan = 0;
            int mealPlan = 0;

            //If else statements to set the prices of the dorm and meal plans
            if (comboxDorm.Text == "Allen Hall") 
            {
                dormPlan = 1500;
            }
            else if (comboxDorm.Text == "Pike Hall")
            {
                dormPlan = 1600;
            }
            else if (comboxDorm.Text == "Farthing Hall")
            {
                dormPlan = 1800;
            }
            else if (comboxDorm.Text == "University Suites")
            {
                dormPlan = 2500;
            }
            if (comboxMeal.Text == "7 meals per week")
            {
                mealPlan = 600;
            }
            else if (comboxMeal.Text == "14 meals per week")
            {
                mealPlan = 1200;
            }
            else if (comboxMeal.Text == "Unlimited meals")
            {
                mealPlan = 1700;
            }

            //Calculate total of both plans
            dormMealTotal = dormPlan + mealPlan;

            //Create instance of second form in the first one
            DisplayUniPlan DormMealPlan = new DisplayUniPlan();

            //Display total cost of the plans on the second form
            DormMealPlan.txtTotal.Text = "$" + dormMealTotal.ToString();

            //Shows the second form
            DormMealPlan.ShowDialog();
        }
    }
}
