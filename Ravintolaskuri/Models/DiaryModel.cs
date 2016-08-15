using System.Collections.Generic;

namespace Ravintolaskuri.Models
{
    public class Diary
    {
        public List<DiaryDay> DiaryDataList { get; set; }
    }

    public class DiaryDay
    {
        public string Date { get; set; }
        public string Kcal { get; set; }
        public string Protein { get; set; }
        public string Carbs { get; set; }
        public string Fat { get; set; }
        public string SFat { get; set; }
    }        
}