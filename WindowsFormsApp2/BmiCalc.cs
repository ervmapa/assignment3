using System;

namespace WindowsFormsApp2
{
    /// <summary>
    /// This class will calcuate the bmi
    /// </summary>
    class BmiCalc
    {
        // Instance variables
        private double weight;
        private double height;
        private Unit unit = Unit.METRIC;

        /// <summary>
        /// Setter method
        /// </summary>
        /// <param name="weight"></param>
        public void SetWeight(double weight)
        {
            this.weight = weight;
        }

        /// <summary>
        /// setter method
        /// </summary>
        /// <param name="height"></param>
        public void SetHeight(double height)
        {
            this.height = height;
        }

        /// <summary>
        /// Setter method
        /// </summary>
        /// <param name="unit"></param>
        public void SetUnit(Unit unit)
        {
            this.unit = unit;
            Console.WriteLine(unit.ToString());
        }

        /// <summary>
        /// Calculate the bmi. 
        /// </summary>
        /// <param name="range">A string with the range for the bmi</param>
        /// <param name="category">category for the bmi</param>
        /// <returns></returns>
        public double Calculate(out string range, out string category)
        {
            double bmi;

            if (unit == Unit.METRIC)
                bmi = CalculateBmiMetric();
            else
                bmi = CalculateBmiUs();

            range = BmiTable.GetBmiRange(bmi, out category);

            return bmi;
        }

        /// <summary>
        /// Return BMI US system
        /// BMI = (	Weight in Pounds / (Height in inches) x (Height in inches)	) x 703
        /// </summary>
        /// <returns>bmi</returns>
        private double CalculateBmiUs()
        {
            double bmi = 703.0 * weight / Math.Pow(height, 2);
            return Math.Round(bmi, 1);
        }

        /// <summary>
        /// BMI =	Weight in Kilograms / (Height in Meters) x (Height in Meters)
        /// </summary>
        /// <returns>bmi</returns>
        public double CalculateBmiMetric()
        {
            double bmi = weight / Math.Pow(height * 0.01, 2);
            return Math.Round(bmi, 1);
        }

    }
}
