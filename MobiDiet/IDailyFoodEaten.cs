using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace MobiDiet
{
    interface IDailyFoodEaten
    {

        string Text { get; set; }


        void SaveDailyFoodEaten();

        void SubmitDailyFoodEaten();
        
    }
}
