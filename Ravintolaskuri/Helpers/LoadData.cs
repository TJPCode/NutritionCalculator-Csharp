using Newtonsoft.Json;
using Ravintolaskuri.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Ravintolaskuri.Helpers
{
    public class LoadData
    {
        private List<Food> foodsList;
        private List<DiaryDay> diaryList;

        // Loads all food data from FoodData.json.
        public List<Food> LoadFoods()
        {
            try
            {
                string json = File.ReadAllText(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Content\Files\FoodData.json"));
                Foods rootfood = new Foods();
                rootfood = JsonConvert.DeserializeObject<Foods>(json);
                foodsList = rootfood.FoodDataList;
            }
            catch (Exception e)
            {
                MessageBox.Show(Properties.Resources.LoadError);
                Debug.WriteLine(e);
            }
            return foodsList;
        }

        // Loads all diary data from DiaryData.json.
        public List<DiaryDay> LoadDiary()
        {
            try
            {
                string json = File.ReadAllText(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Content\Files\DiaryData.json"));
                Diary rootdiary = new Diary();
                rootdiary = JsonConvert.DeserializeObject<Diary>(json);
                diaryList = rootdiary.DiaryDataList;
            }
            catch (Exception e)
            {
                MessageBox.Show(Properties.Resources.LoadError);
                Debug.WriteLine(e);
            }
            return diaryList;
        }
    }
}