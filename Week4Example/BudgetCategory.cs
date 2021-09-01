using System;
using System.Collections.Generic;
using System.Text;

namespace Week4Example
{
    class BudgetCategory
    {

        public String category = "";
        double fy2017 = 0;
        double fy2018 = 0;
        double fy2019 = 0;
        double fy2020 = 0;

        public BudgetCategory(String tempCategory, double tempfy2017,
            double tempfy2018, double tempfy2019, double tempfy2020)
        {
            this.category = tempCategory;
            this.fy2017 = tempfy2017;
            this.fy2018 = tempfy2018;
            this.fy2019 = tempfy2019;
            this.fy2020 = tempfy2020;
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

        private double GetPercentChange(double doubleBaseNumber, double doubleChangeNumber)
        {
            double doublePercentage = (doubleChangeNumber - doubleBaseNumber) / doubleBaseNumber;
            return doublePercentage;
        }

    }
}
