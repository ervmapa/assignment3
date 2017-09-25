// testpage http://www.calculator.net/bmr-calculator.html

namespace WindowsFormsApp2
{
    class BmrCalc
    {
        // Instance variable default input value
        double bmrActivityLevel = BmrActivityLevel.SEDENTARY;
        double weight;
        double height;
        int age;
        Gender gender;
        Unit unit = Unit.METRIC;

        public void setWeight(double weight)
        {
            this.weight = weight;
        }

        public void setHeight(double height)
        {
            this.height = height;
        }

        public void setAge(int age)
        {
            this.age = age;
        }

        public void setGender(Gender gender)
        {
            this.gender = gender;
        }

        public void setUnit(Unit unit)
        {
            this.unit = unit;
         
        }

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

        public void setActivityLevel(double bmrActivityLevel)
        {
            this.bmrActivityLevel = bmrActivityLevel;
        }

        public double KeepWeight(double bmr)
        {
            return bmr * bmrActivityLevel;
        }

    }
}
