using System;

namespace WindowsFormsApp2
{
    /// <summary>
    /// Class for fuel calcualations
    /// </summary>
    class FuelCalc
    {
        // Instance variables
        private double currentKm;
        private double previousKm;
        private double fuelAmount;
        private double pricePerLiter;
        const double kmToMileFactor = 0.621371192;

        /// <summary>
        /// Setter
        /// </summary>
        /// <param name="currentKm"></param>
        public void SetCurrentKm(double currentKm)
        {
            this.currentKm = currentKm;
            Console.WriteLine("sdk");
        }

        /// <summary>
        /// Setter
        /// </summary>
        /// <param name="previousKm"></param>
        public void SetPreviousKm(double previousKm)
        {
            this.previousKm = previousKm;
        }

        /// <summary>
        /// Setter
        /// </summary>
        /// <param name="fuelAmount"></param>
        public void SetFuelAmount(double fuelAmount)
        {
            this.fuelAmount = fuelAmount;
        }

        /// <summary>
        /// Setter
        /// </summary>
        /// <param name="pricePerLiter"></param>
        public void SetPricePerLiter(double pricePerLiter)
        {
            this.pricePerLiter = pricePerLiter;
        }

        /// <summary>
        /// Calcuate the price
        /// </summary>
        /// <param name="kmPerLiter"></param>
        /// <param name="literPerKm"></param>
        /// <param name="literPerMile"></param>
        /// <param name="literPerMil"></param>
        /// <param name="costPerKm"></param>
        public void Calculate(out double kmPerLiter, out double literPerKm, out double literPerMile, out double literPerMil, out double costPerKm)
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
