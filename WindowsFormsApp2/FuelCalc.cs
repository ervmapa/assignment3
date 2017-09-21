using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class FuelCalc
    {
        // Instance variables
        private double currentKm;
        private double previousKm;
        private double fuelAmount;
        private double pricePerLiter;
        const double kmToMileFactor = 0.621371192;

        public void setCurrentKm(double currentKm)
        {
            this.currentKm = currentKm;
            Console.WriteLine("sdk");
        }

        public void setPreviousKm(double previousKm)
        {
            this.previousKm = previousKm;
        }

        public void setFuelAmount(double fuelAmount)
        {
            this.fuelAmount = fuelAmount;
        }

        public void setPricePerLiter(double pricePerLiter)
        {
            this.pricePerLiter = pricePerLiter;
        }

        public void Calculate(out double kmPerLiter, out double literPerKm, out double literPerMile, out double literPerMil, out double costPerKm) 
            //(double out kmPerLiter,  double out litPerKm,  double out litPerMile,  double out litPerMil, double out cost)
        {

            double distanceKm = currentKm - previousKm;

            kmPerLiter = distanceKm / fuelAmount;
            literPerKm = fuelAmount / distanceKm;
            literPerMile = fuelAmount / distanceKm;

            literPerMil = literPerKm * 10;
            costPerKm = literPerKm * pricePerLiter;
            Console.WriteLine("distance " + distanceKm.ToString() + "literPerKm:" + literPerKm.ToString() + "literPerMile:" + literPerMile.ToString() + "kmPerLiter:" + kmPerLiter.ToString() + " " + costPerKm.ToString());

        }
    }





}
