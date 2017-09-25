﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{

    public static class BmiTable
    {

        public static string GetBmiRange(double bmi, out string status)
        {
            string bmiRange; 

            if (bmi<18.5)
            {
                bmiRange = "below 18.5";
                status = "Underweight"; 
            }
            else if (bmi<25)
            {
                bmiRange = "18.5 - 24.9";
                status = "Normal weight";
            }
            else if (bmi < 30)
            {
                bmiRange = "25 - 29.5";
                status = "Overweight (preobesity)";
            }
            else if (bmi < 35)
            {
                bmiRange = "30 - 34.9";
                status = "Obesity class I";
            }
            else if (bmi < 40)
            {
                bmiRange = "35 - 39.9";
                status = "Obesity class II";
            }
            else
            {
                bmiRange = "Above 40";
                status = "Obesity class III";
            }

            return bmiRange;
        }
        
    }
}
