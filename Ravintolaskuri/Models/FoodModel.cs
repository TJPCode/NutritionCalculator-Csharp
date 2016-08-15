using System.Collections.Generic;

namespace Ravintolaskuri.Models
{
    public class Foods
    {
        public List<Food> FoodDataList { get; set; }
    }

    public class Food
    {
        public string FoodName { get; set; }
        public string Kcal { get; set; }
        public string Protein { get; set; }
        public string Carbs { get; set; }
        public string Fat { get; set; }
        public string SFat { get; set; }
        public string Category { get; set; }
        public string Info { get; set; }
    }
}