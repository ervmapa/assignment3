namespace WindowsFormsApp2
{
    /// <summary>
    /// Calculator for Bmr
    /// </summary>
    class BmrCalc
    {
        // Instance variable default input value
        double bmrActivityLevel; 
        double weight;
        double height;
        int age;
        Gender gender;
        Unit unit = Unit.METRIC;

        /// <summary>
        /// setter
        /// </summary>
        /// <param name="weight"></param>
        public void SetWeight(double weight)
        {
            this.weight = weight;
        }

        /// <summary>
        /// setter
        /// </summary>
        /// <param name="height"></param>
        public void SetHeight(double height)
        {
            this.height = height;
        }

        /// <summary>
        /// setter
        /// </summary>
        /// <param name="age"></param>
        public void SetAge(int age)
        {
            this.age = age;
        }

        /// <summary>
        /// setter
        /// </summary>
        /// <param name="gender"></param>
        public void SetGender(Gender gender)
        {
            this.gender = gender;
        }

        /// <summary>
        /// setter
        /// </summary>
        /// <param name="unit"></param>
        public void SetUnit(Unit unit)
        {
            this.unit = unit;
        }

        /// <summary>
        /// setter
        /// </summary>
        /// <param name="bmrActivityLevel"></param>
        public void setActivityLevel(double bmrActivityLevel)
        {
            this.bmrActivityLevel = bmrActivityLevel;
        }

        /// <summary>
        /// setter
        /// </summary>
        /// <param name="bmr"></param>
        /// <returns></returns>
        public double KeepWeight(double bmr)
        {
            return bmr * bmrActivityLevel;
        }

        /// <summary>
        /// Do the calcuation
        /// </summary>
        /// <returns></returns>
        public double Calculate()
        {

            // Convert inch and ounce to metric system
            if (unit == Unit.US)
            {
                height *= 2.54; //1 inch = 2.54 centimeters
                weight *= 0.45359237; // 1 pound = 0.45359237 kilograms
            }

            // Calcuate BMR
            double bmr = 10 * weight + 6.25 * height - 5 * age + (int)gender;
            return bmr;
        }

    }
}
