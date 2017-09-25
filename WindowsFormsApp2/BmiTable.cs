namespace WindowsFormsApp2
{

    /// <summary>
    /// This class is used by the BmiCalc.
    /// </summary>
    public static class BmiTable
    {

        /// <summary>
        /// From a bmi, get the range and catogory for that bmi
        /// </summary>
        /// <param name="bmi"></param>
        /// <param name="category"></param>
        /// <returns></returns>
        public static string GetBmiRange(double bmi, out string category)
        {
            string bmiRange; 

            if (bmi<18.5)
            {
                bmiRange = "below 18.5";
                category = "Underweight"; 
            }
            else if (bmi<25)
            {
                bmiRange = "18.5 - 24.9";
                category = "Normal weight";
            }
            else if (bmi < 30)
            {
                bmiRange = "25 - 29.5";
                category = "Overweight (preobesity)";
            }
            else if (bmi < 35)
            {
                bmiRange = "30 - 34.9";
                category = "Obesity class I";
            }
            else if (bmi < 40)
            {
                bmiRange = "35 - 39.9";
                category = "Obesity class II";
            }
            else
            {
                bmiRange = "Above 40";
                category = "Obesity class III";
            }

            return bmiRange;
        }
        
    }
}
