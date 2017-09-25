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
        private BmrCalc bmrCalc = new BmrCalc();

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
            lblBmiRange.Text = "";
            grpBmiResults.Text = "Results for noname";
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
                lblFuelResKmLit.Text = kmPerLiter.ToString("0.##");
                lblFuelResLitKm.Text = litPerKm.ToString("0.##");
                lblFuelResLitMile.Text = litPerMile.ToString("0.##");
                lblFuelResMil.Text = litPerMil.ToString("0.##");
                lblFuelResCostKm.Text = costPerKm.ToString("0.##");
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
                lblBmiWeight.Text = "Weight (lb)";
                bmiCalc.setUnit(Unit.US);
                bmrCalc.setUnit(Unit.US);
            }
        }


        private void radMetric_CheckedChanged(object sender, EventArgs e)
        {
            if (radMetric.Checked == true)
            {
                lblBmiHeight.Text = "Height (cm)";
                lblBmiWeight.Text = "Weight (kg)";
                bmiCalc.setUnit(Unit.METRIC);
                bmrCalc.setUnit(Unit.METRIC);
            }
        }

        private void btnBmiCalc_Click(object sender, EventArgs e)
        {
            // Initialize result variables
            double bmi;
            string bmiCategory;
            string bmiRange;


            // Validate the input
            if (validateBmiInput())
            {
                // input is validated and ready for the fuelCalc
                bmi = bmiCalc.Calculate(out bmiRange, out bmiCategory);
                lblBmiResBmi.Text = bmi.ToString("0.#");
                lblBmiResCat.Text = bmiCategory;
                lblBmiRange.Text = "Range for category " + bmiCategory + " is " + bmiRange + "\nNormal BMI is between 18.5 and 30.";


                // update the groupbox with the username
                grpBmiResults.Text = ("Results for " + updateBmiUsername());
            }
            else
            {
                clearMbiResultFields();
                lboxBmr.ClearSelected();
                lboxBmr.Items.Clear();
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
            double bmiHeight = validateDouble(txtBmiHeight, lblBmiHeight);

            if (bmiHeight < 0)
                return false;

            bmiCalc.setHeight(bmiHeight);
            bmrCalc.setHeight(bmiHeight);

            if (bmiHeight == 0)
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
            bmrCalc.setWeight(bmiWeight);

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


        private bool validateBmrAge()
        {
            int val = -1;
            if (!int.TryParse(txtAge.Text.Trim(), out val) || val <= 0)
            {
                MessageBox.Show("Please check field age",
                    "Input validation error",
                    MessageBoxButtons.OK);
                txtAge.Select();
                lboxBmr.ClearSelected();
                lboxBmr.Items.Clear();
                return false;
            }
            bmrCalc.setAge(val);

            return true;
        }



        private bool validateBmrInput()
        {
            return (validateBmiHeight() && validateBmiWeight() && validateBmrAge());
        }

        private void btnBmrCalc_Click(object sender, EventArgs e)
        {
            if (validateBmrInput())
            {
                lboxBmr.ClearSelected();
                lboxBmr.Items.Clear();
                double bmr = bmrCalc.Calculate();
                lboxBmr.Items.Add("BMR RESULTS FOR " + updateBmiUsername().ToUpper());
                lboxBmr.Items.Add("");
                lboxBmr.Items.Add(string.Format("Your BMR (calories per day)\t\t{0}", bmr.ToString("0.#")));
                lboxBmr.Items.Add(string.Format("Calories to maintain weight\t\t{0}", bmrCalc.KeepWeight(bmr).ToString("0.#")));
                lboxBmr.Items.Add(string.Format("Calories to loose 0.5 kg/week\t\t{0}", (bmrCalc.KeepWeight(bmr) - 500).ToString("0.#")));
                lboxBmr.Items.Add(string.Format("Calories to loose 1 kg/week\t\t{0}", (bmrCalc.KeepWeight(bmr) - 1000).ToString("0.#")));
                lboxBmr.Items.Add(string.Format("Calories to gain 0.5 kg/week\t\t{0}", (bmrCalc.KeepWeight(bmr) + 500).ToString("0.#")));
                lboxBmr.Items.Add(string.Format("Calories to gain 1 kg/week\t\t{0}", (bmrCalc.KeepWeight(bmr) + 1000).ToString("0.#")));
                lboxBmr.Items.Add("");
                lboxBmr.Items.Add("Loosing more than 1000 calories per day is to be avoided");
            }
        }



        private void btnBrmUnselect_Click(object sender, EventArgs e)
        {
            lboxBmr.ClearSelected();
        }

        private void lboxBmr_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblBmrSelect.Text = "Selected index: " + lboxBmr.SelectedIndex.ToString();
        }

        private void radASedentary_CheckedChanged(object sender, EventArgs e)
        {
            if (radASedentary.Checked)
                bmrCalc.setActivityLevel(BmrActivityLevel.SEDENTARY);
        }

        private void radALight_CheckedChanged(object sender, EventArgs e)
        {
            if (radALight.Checked)
                bmrCalc.setActivityLevel(BmrActivityLevel.LIGHTLY);
        }

        private void radAModerate_CheckedChanged(object sender, EventArgs e)
        {
            if (radAModerate.Checked)
                bmrCalc.setActivityLevel(BmrActivityLevel.MODERATELY);
        }

        private void radAVery_CheckedChanged(object sender, EventArgs e)
        {
            if (radAVery.Checked)
                bmrCalc.setActivityLevel(BmrActivityLevel.VERY);
        }

        private void radAExtra_CheckedChanged(object sender, EventArgs e)
        {
            if (radAExtra.Checked)
                bmrCalc.setActivityLevel(BmrActivityLevel.EXTRA);
        }

        private void radFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (radFemale.Checked)
                bmrCalc.setGender(Gender.FEMALE);
        }

        private void radMale_CheckedChanged(object sender, EventArgs e)
        {
            if (radMale.Checked)
                bmrCalc.setGender(Gender.MALE);
        }
    }
}
