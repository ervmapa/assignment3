using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class BmiCalc
    {
        // Instance variables
        private double weight;
        private double height;
        private Unit unit = Unit.METRIC;

    
        public void setWeight(double weight)
        {
            this.weight = weight;
        }

        public void setHeight(double height)
        {
            this.height = height;
        }

        public void setUnit(Unit unit)
        {
            this.unit = unit;
            Console.WriteLine(unit.ToString());
        }

        public void Calculate(out double bmi)
        {

            Console.WriteLine("UNIT IS"+unit.ToString());
            Console.WriteLine(weight.ToString());
            Console.WriteLine(height.ToString());

            if (unit == Unit.METRIC)
            {
                bmi = CalculateBmiMetric();
            }
            else
            {
               bmi =  CalculateBmiUs();
            }

            Console.WriteLine(bmi.ToString());
            
            
        }

        private double CalculateBmiUs()
        {
            return 703.0 * weight / height;
        }

        public double CalculateBmiMetric()
        {
            return weight / (height * height);
        }


        }
}
