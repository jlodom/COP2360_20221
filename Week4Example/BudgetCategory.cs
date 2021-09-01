using System;
using System.Collections.Generic;


namespace Week4Example

{
    /* BudgetCategory object to show the basics of how objects work.
     * Corresponds to a row on the CSV file for the Pensacola budget. */
    class BudgetCategory
    {

        /* Our object variables. One set to public for demonstration purposes only. */
        public String category = "";
        double fy2017 = 0; /* We will eventually put auto-setters-and-getters here. */
        double fy2018 = 0;
        double fy2019 = 0;
        double fy2020 = 0;

        /* Generic Full Constructor */
        public BudgetCategory(String tempCategory, double tempfy2017,
            double tempfy2018, double tempfy2019, double tempfy2020)
        {
            this.category = tempCategory;
            this.fy2017 = tempfy2017;
            this.fy2018 = tempfy2018;
            this.fy2019 = tempfy2019;
            this.fy2020 = tempfy2020;
        }

        /* Special Constructor for use with our original program. */
        public BudgetCategory(Dictionary<String, String> dicTemp)
        {
            this.category = dicTemp["Category"];
            this.fy2017 = Double.Parse(dicTemp["FY 2017 Approved Budget"]);
            this.fy2018 = Double.Parse(dicTemp["FY 2018 Approved Budget"]);
            this.fy2019 = Double.Parse(dicTemp["FY 2019 Approved Budget"]);
            this.fy2020 = Double.Parse(dicTemp["FY 2020 Approved Budget"]);
        }

        /* Getter / Accessor */
        public double GetFY2017()
        {
            return this.fy2017;
        }

        /*Setter / Mutator */
        public void SetFY2017(double newValue)
        {
            this.fy2017 = newValue;
        }

        /* Three public methods. */
        public double GetPercent1718()
        {
            return this.GetPercentChange(this.fy2017, this.fy2018);
        }

        public double GetPercent1819()
        {
            return this.GetPercentChange(this.fy2018, this.fy2019);
        }

        public double GetPercent1920()
        {
            return this.GetPercentChange(this.fy2019, this.fy2020);
        }

        /* We made this private because no one needs to see it. */
        private double GetPercentChange(double doubleBaseNumber, double doubleChangeNumber)
        {
            double doublePercentage = (doubleChangeNumber - doubleBaseNumber) / doubleBaseNumber;
            return doublePercentage;
        }

    }
}
