using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    /// <summary>
    /// Mainform
    /// </summary>
    public partial class MainForm : Form
    {

        // Instance variables
        private FuelCalc fuelCalc = new FuelCalc();
        private BmiCalc bmiCalc = new BmiCalc();
        private BmrCalc bmrCalc = new BmrCalc();

        /// <summary>
        /// Constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            InitializeGui();
        }

        /// <summary>
        /// Initialize
        /// </summary>
        private void InitializeGui()
        {
            // Default variables
            bmrCalc.setActivityLevel(BmrActivityLevel.SEDENTARY);
            bmrCalc.SetGender(Gender.FEMALE);
            bmiCalc.SetUnit(Unit.METRIC);

            // Clear fields
            ClearFuelFields();
            ClearMbiFields();
            ClearBmrFields();
        }

        /// <summary>
        /// Clear fields
        /// </summary>
        private void ClearMbiFields()
        {
            txtBmiHeight.Text = "";
            txtBmiWeight.Text = "";
            txtBmiName.Text = "";
            grpBmiResults.Text = "Results for noname";
            lblBmiHeight.Text = "Height (cm)";
            lblBmiWeight.Text = "Weight (kg)";
            radMetric.Checked = true;
            radUs.Checked = false;
            ClearMbiResultFields();
        }

        /// <summary>
        /// Clear fields
        /// </summary>
        private void ClearMbiResultFields()
        {
            lblBmiResBmi.Text = "";
            lblBmiResCat.Text = "";
            lblBmiRange.Text = "";
            grpBmiResults.Text = "Results for noname";
        }

        /// <summary>
        /// Clear fields
        /// </summary>
        private void ClearBmrFields()
        {
            lboxBmr.ClearSelected();
            lboxBmr.Items.Clear();
        }

        /// <summary>
        /// Clear fields
        /// </summary>
        private void ClearFuelFields()
        {
            txtCurrentKm.Text = "";
            txtPrevKm.Text = "0";
            txtAmount.Text = "";
            txtFuelPrice.Text = "";
            txtCurrentKm.Select();
            ClearFuelResultFields();
        }

        /// <summary>
        /// Clear fields
        /// </summary>
        private void ClearFuelResultFields()
        {
            lblFuelResKmLit.Text = "";
            lblFuelResLitKm.Text = "";
            lblFuelResLitMile.Text = "";
            lblFuelResMil.Text = "";
            lblFuelResCostKm.Text = "";
        }


        /// <summary>
        /// Validate that a textbox contains a double value
        /// </summary>
        /// <param name="textbox"></param>
        /// <param name="label"></param>
        /// <returns></returns>
        private double ValidateDouble(TextBox textbox, Label label)
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

        /// <summary>
        /// Validate odometer inputs are correct
        /// </summary>
        /// <returns></returns>
        private bool ValidateOdometer()
        {
            double currentKm = ValidateDouble(txtCurrentKm, lblCurrentKm);
            if (currentKm < 0)
                return false;
            fuelCalc.SetCurrentKm(currentKm);

            double previousKm = ValidateDouble(txtPrevKm, lblPrevKm);
            if (previousKm < 0)
                return false;
            fuelCalc.SetPreviousKm(previousKm);

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

        /// <summary>
        /// Validate fuel amount input are correct
        /// </summary>
        /// <returns></returns>
        private bool ValidateFuelAmount()
        {
            double fuelAmount = ValidateDouble(txtAmount, lblAmount);

            if (fuelAmount < 0)
                return false;

            fuelCalc.SetFuelAmount(fuelAmount);

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

        /// <summary>
        /// Validate fuel price inputs are correct
        /// </summary>
        /// <returns></returns>
        private bool ValidateFuelPrice()
        {
            double fuelPrice = ValidateDouble(txtFuelPrice, lblFuelPrice);

            if (fuelPrice < 0)
                return false;

            fuelCalc.SetPricePerLiter(fuelPrice);

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

        /// <summary>
        /// Validate all fuel fields
        /// </summary>
        /// <returns></returns>
        private bool ValidateFuelInput()
        {
            return (ValidateOdometer() && ValidateFuelAmount() && ValidateFuelPrice());
        }

        /// <summary>
        /// Validate and calculate fuel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnFuelCalc_Click(object sender, EventArgs e)
        {
            // Initialize result variables
            double kmPerLiter = 0;
            double litPerKm = 0;
            double litPerMile = 0;
            double litPerMil = 0;
            double costPerKm = 0;

            // Validate the input
            if (ValidateFuelInput())
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

            // if the input is incorrect, clear the fuel result
            else
                ClearFuelResultFields();
        }


        /// <summary>
        /// Handle US metric change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadUs_CheckedChanged(object sender, EventArgs e)
        {
            if (radUs.Checked == true)
            {
                lblBmiHeight.Text = "Height (inch)";
                lblBmiWeight.Text = "Weight (lb)";
                bmiCalc.SetUnit(Unit.US);
                bmrCalc.SetUnit(Unit.US);
            }
        }

        /// <summary>
        /// Handle metric change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadMetric_CheckedChanged(object sender, EventArgs e)
        {
            if (radMetric.Checked == true)
            {
                lblBmiHeight.Text = "Height (cm)";
                lblBmiWeight.Text = "Weight (kg)";
                bmiCalc.SetUnit(Unit.METRIC);
                bmrCalc.SetUnit(Unit.METRIC);
            }
        }

        /// <summary>
        /// Calculate BMI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBmiCalc_Click(object sender, EventArgs e)
        {
            // Initialize result variables
            double bmi;
            string bmiCategory;
            string bmiRange;


            // Validate the input
            if (ValidateBmiInput())
            {
                // input is validated and ready for the fuelCalc
                bmi = bmiCalc.Calculate(out bmiRange, out bmiCategory);
                lblBmiResBmi.Text = bmi.ToString("0.#");
                lblBmiResCat.Text = bmiCategory;
                lblBmiRange.Text = "Range for category " + bmiCategory + " is " + bmiRange + "\nNormal BMI is between 18.5 and 30.";

                // update the groupbox with the username
                grpBmiResults.Text = ("Results for " + UpdateBmiUsername());
            }
            else
            {
                ClearMbiResultFields();
                ClearBmrFields();
            }
        }

        /// <summary>
        ///  Validate the username is correct
        /// </summary>
        /// <returns></returns>
        private string UpdateBmiUsername()
        {
            string name = txtBmiName.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                name = "noname";
            }

            return name;
        }

        /// <summary>
        /// validate BMI input fields
        /// </summary>
        /// <returns></returns>
        private bool ValidateBmiInput()
        {
            return (ValidateBmiHeight() && ValidateBmiWeight());
        }

        /// <summary>
        ///  Valdiate height
        /// </summary>
        /// <returns></returns>
        private bool ValidateBmiHeight()
        {
            double bmiHeight = ValidateDouble(txtBmiHeight, lblBmiHeight);

            if (bmiHeight < 0)
                return false;

            bmiCalc.SetHeight(bmiHeight);
            bmrCalc.SetHeight(bmiHeight);

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

        /// <summary>
        ///  Validate weight
        /// </summary>
        /// <returns></returns>
        private bool ValidateBmiWeight()
        {
            double bmiWeight = ValidateDouble(txtBmiWeight, lblBmiWeight);

            if (bmiWeight < 0)
                return false;

            bmiCalc.SetWeight(bmiWeight);
            bmrCalc.SetWeight(bmiWeight);

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

        /// <summary>
        /// Validate age is integer
        /// </summary>
        /// <returns></returns>
        private bool ValidateBmrAge()
        {
            int val = -1;
            if (!int.TryParse(txtAge.Text.Trim(), out val) || val <= 0)
            {
                MessageBox.Show("Please check field age",
                    "Input validation error",
                    MessageBoxButtons.OK);
                txtAge.Select();
                ClearBmrFields();
                return false;
            }
            bmrCalc.SetAge(val);

            return true;
        }


        /// <summary>
        /// Validate all BMR fields
        /// </summary>
        /// <returns></returns>
        private bool ValidateBmrInput()
        {
            return (ValidateBmiHeight() && ValidateBmiWeight() && ValidateBmrAge());
        }

        /// <summary>
        ///  Calculate BMR
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBmrCalc_Click(object sender, EventArgs e)
        {
            if (ValidateBmrInput())
            {
                ClearBmrFields();
                double bmr = bmrCalc.Calculate();
                lboxBmr.Items.Add("BMR RESULTS FOR " + UpdateBmiUsername().ToUpper());
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

        /// <summary>
        /// Unselect listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBrmUnselect_Click(object sender, EventArgs e)
        {
            lboxBmr.ClearSelected();
        }

        /// <summary>
        /// Handle listbox changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LboxBmr_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblBmrSelect.Text = "Selected index: " + lboxBmr.SelectedIndex.ToString();
        }

        /// <summary>
        /// Handle change of radiobuttonactivity level
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadASedentary_CheckedChanged(object sender, EventArgs e)
        {
            if (radASedentary.Checked)
                bmrCalc.setActivityLevel(BmrActivityLevel.SEDENTARY);
        }

        /// <summary>
        /// Handle change of radiobuttonactivity level
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadALight_CheckedChanged(object sender, EventArgs e)
        {
            if (radALight.Checked)
                bmrCalc.setActivityLevel(BmrActivityLevel.LIGHTLY);
        }

        /// <summary>
        /// Handle change of radiobuttonactivity level
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadAModerate_CheckedChanged(object sender, EventArgs e)
        {
            if (radAModerate.Checked)
                bmrCalc.setActivityLevel(BmrActivityLevel.MODERATELY);
        }

        /// <summary>
        /// Handle change of radiobuttonactivity level
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadAVery_CheckedChanged(object sender, EventArgs e)
        {
            if (radAVery.Checked)
                bmrCalc.setActivityLevel(BmrActivityLevel.VERY);
        }

        /// <summary>
        /// Handle change of radiobuttonactivity level
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadAExtra_CheckedChanged(object sender, EventArgs e)
        {
            if (radAExtra.Checked)
                bmrCalc.setActivityLevel(BmrActivityLevel.EXTRA);
        }

        /// <summary>
        /// Handle change of gender
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (radFemale.Checked)
                bmrCalc.SetGender(Gender.FEMALE);
        }

        /// <summary>
        /// Handle change of gender
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadMale_CheckedChanged(object sender, EventArgs e)
        {
            if (radMale.Checked)
                bmrCalc.SetGender(Gender.MALE);
        }
    }
}
