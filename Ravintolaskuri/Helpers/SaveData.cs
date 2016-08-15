using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Ravintolaskuri.Helpers
{
    public class SaveData
    {       
        // Use these lines when project is going to be published. These ensures that published program finds these json files.
        //string foodPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Content\Files\FoodData.json");
        //string diaryPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Content\Files\DiaryData.json");

        // Use these lines during developing and testing. Edit path to match your directory path. These ensures json file overwriting.
        string foodPath = "C:\\NutritionCalculator-Csharp-master\\Ravintolaskuri\\Content\\Files\\FoodData.json";
        string diaryPath = "C:\\NutritionCalculator-Csharp-master\\Ravintolaskuri\\Content\\Files\\DiaryData.json";
        StreamWriter stream;

        // Saves json string to DiaryData.json or FoodData.json.
        public void SaveJson(string json, Boolean isDiary)
        {
            try
            {
                if (isDiary)
                {
                    stream = File.CreateText(diaryPath);
                }
                else
                {
                    stream = File.CreateText(foodPath);
                }
                stream.WriteLine(json);
            }
            catch (IOException e)
            {
                MessageBox.Show(Properties.Resources.SaveError);
                Debug.WriteLine(e);
            }
            finally
            {
                if (stream != null)
                {
                    stream.Close();
                }               
            }
        }
    }
}