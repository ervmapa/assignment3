using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class MainForm : Form
    {
        private FuelCalc fuelCalc = new FuelCalc();
        private BmiCalc bmiCalc = new BmiCalc();

        public MainForm()
        {
            InitializeComponent();
            InitializeGui();
        }

        private void InitializeGui()
        {
            clearFuelFields();
            clearMbiFields();
        }

        private void clearMbiFields()
        {
            txtBmiHeight.Text = "";
            txtBmiWeight.Text = "";
            txtBmiName.Text = "";
            grpBmiResults.Text = "Results for noname";
            lblBmiHeight.Text = "Height (cm)";
            lblBmiWeight.Text = "Weight (kg)";
            radMetric.Checked = true;
            radUs.Checked = false;
            clearMbiResultFields();
        }

        private void clearMbiResultFields()
        {
            lblBmiResBmi.Text = "";
            lblBmiResCat.Text = "";
        }

        private void clearFuelFields()
        {
            txtCurrentKm.Text = "";
            txtPrevKm.Text = "0";
            txtAmount.Text = "";
            txtFuelPrice.Text = "";
            txtCurrentKm.Select();
            clearFuelResultFields();
        }

        private void clearFuelResultFields()
        {
            lblFuelResKmLit.Text = "";
            lblFuelResLitKm.Text = "";
            lblFuelResLitMile.Text = "";
            lblFuelResMil.Text = "";
            lblFuelResCostKm.Text = "";

        }




        private double validateDouble(TextBox textbox, Label label)
        {
            double val = -1;
            if (!double.TryParse(textbox.Text.Trim(), out val) || val < 0)
            {
                MessageBox.Show(string.Format("Please check field '{0}'", label.Text),
                    "Input validation error",
                    MessageBoxButtons.OK);
                textbox.Select();
                val = -1;
            }
            return val;
        }



        private bool validateOdometer()
        {
            double currentKm = validateDouble(txtCurrentKm, lblCurrentKm);
            if (currentKm < 0)
                return false;
            fuelCalc.setCurrentKm(currentKm);

            double previousKm = validateDouble(txtPrevKm, lblPrevKm);
            if (previousKm < 0)
                return false;
            fuelCalc.setPreviousKm(previousKm);

            if (previousKm >= currentKm)
            {
                MessageBox.Show(string.Format("Previous odometer reading must be less than the current "),
                                "Input validation error",
                                MessageBoxButtons.OK);
                txtPrevKm.Select();
                return false;
            }

            else return true;

        }

        private bool validateFuelAmount()
        {
            double fuelAmount = validateDouble(txtAmount, lblAmount);

            if (fuelAmount < 0)
                return false;

            fuelCalc.setFuelAmount(fuelAmount);

            if (fuelAmount == 0)
            {
                MessageBox.Show(string.Format("Fuel amount must be a > 0"),
                "Input validation error",
                MessageBoxButtons.OK);
                txtAmount.Select();
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool validateFuelPrice()
        {
            double fuelPrice = validateDouble(txtFuelPrice, lblFuelPrice);

            if (fuelPrice < 0)
                return false;

            fuelCalc.setPricePerLiter(fuelPrice);

            if (fuelPrice == 0)
            {
                MessageBox.Show(string.Format("Fuel price must be a > 0"),
                "Input validation error", MessageBoxButtons.OK);
                return false;
            }
            else
            {
                return true;
            }
        }



        private bool validateFuelInput()
        {
            return (validateOdometer() && validateFuelAmount() && validateFuelPrice());
        }


        private void btnFuelCalc_Click(object sender, EventArgs e)
        {
            // Initialize result variables
            double kmPerLiter = 0;
            double litPerKm = 0;
            double litPerMile = 0;
            double litPerMil = 0;
            double costPerKm = 0;

            // Validate the input
            if (validateFuelInput())
            {
                // input is validated and ready for the fuelCalc
                fuelCalc.Calculate(out kmPerLiter, out litPerKm, out litPerMile, out litPerMil, out costPerKm);

                // Update the GUI with the result 
                lblFuelResKmLit.Text = kmPerLiter.ToString();
                lblFuelResLitKm.Text = litPerKm.ToString();
                lblFuelResLitMile.Text = litPerMile.ToString();
                lblFuelResMil.Text = litPerMil.ToString();
                lblFuelResCostKm.Text = costPerKm.ToString();
            }

            // if the input is incorrect, clear the
            else
                clearFuelResultFields();


        }



        private void radUs_CheckedChanged(object sender, EventArgs e)
        {

            if (radUs.Checked == true)
            {
                lblBmiHeight.Text = "Height (inch)";
                lblBmiWeight.Text = "Weight (oc)";
                bmiCalc.setUnit(Unit.US);
            }
        }


        private void radMetric_CheckedChanged(object sender, EventArgs e)
        {
            if (radMetric.Checked == true)
            {
                lblBmiHeight.Text = "Height (cm)";
                lblBmiWeight.Text = "Weight (kg)";
                bmiCalc.setUnit(Unit.METRIC);
            }
        }

        private void btnBmiCalc_Click(object sender, EventArgs e)
        {
            // Initialize result variables
            double bmi = 0;

            // Validate the input
            if (validateBmiInput())
            {
                // input is validated and ready for the fuelCalc
                bmiCalc.Calculate(out bmi);

                grpBmiResults.Text = ("Results for " + updateBmiUsername());


            }
            else
            {
                clearMbiResultFields();
            }
        }

        private string updateBmiUsername()
        {
            string name = txtBmiName.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                name = "noname";
            }

            return name;
        }

        private bool validateBmiInput()
        {
            return (validateBmiHeight() && validateBmiWeight());
        }

        private bool validateBmiHeight()
        {
            double bmiheight = validateDouble(txtBmiHeight, lblBmiHeight);

            if (bmiheight < 0)
                return false;

            bmiCalc.setHeight(bmiheight);

            if (bmiheight == 0)
            {
                MessageBox.Show(string.Format("Height must be a > 0"),
                "Input validation error", MessageBoxButtons.OK);
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool validateBmiWeight()
        {
            double bmiWeight = validateDouble(txtBmiWeight, lblBmiWeight);

            if (bmiWeight < 0)
                return false;

            bmiCalc.setWeight(bmiWeight);

            if (bmiWeight == 0)
            {
                MessageBox.Show(string.Format("Weight must be a > 0"),
                "Input validation error", MessageBoxButtons.OK);
                return false;
            }
            else
            {
                return true;
            }
        }




    }
}
