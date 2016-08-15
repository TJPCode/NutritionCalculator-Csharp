using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Drawing;
using Ravintolaskuri.Models;
using Ravintolaskuri.Helpers;
using System.Diagnostics;

namespace Ravintolaskuri
{  
    public partial class Form1 : Form
    {
        #region VARIABLES
        Foods rootfood;
        Diary rootdiary;
        SaveData saveData;
        List<Food> solids;
        List<Food> drinks;
        List<Food> supplements;
        List<Food> extras;
        List<string> selectedFoods = new List<string>();
        int sumKcal = 0;
        int sumProtein = 0;
        int sumCarbs = 0;
        int sumFat = 0;
        int sumSFat = 0;    
        int currentMonth = 0;
        bool dateInUse;        

        public List<Food> allFoodsList
        {
            get { return rootfood.FoodDataList; } set { rootfood.FoodDataList = value; }
        }

        public List<DiaryDay> diaryList
        {
            get { return rootdiary.DiaryDataList; } set { rootdiary.DiaryDataList = value; }
        }
        #endregion

        #region FORM
        // Initializes Form1.
        public Form1()
        {
            InitializeComponent(); 
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("fi-FI");
        }
      
        // Loads Form1.
        private void Form1_Load(object sender, EventArgs e)
        {
            chart.ChartAreas["ChartArea1"].AxisX.Minimum = 1;
            chart.ChartAreas["ChartArea1"].AxisX.Maximum = 31;
            chart.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            chart.ChartAreas["ChartArea1"].AxisY.Minimum = 0;
            chart.ChartAreas["ChartArea1"].AxisY.Interval = 250;
            DoubleBuffered = true;           
            btnAddToDiary.Enabled = false;
            btnDeleteFromDiary.Enabled = false;
            dataGridViewFoods.AutoGenerateColumns = false;
            groupBoxDiaryDay.Text = DateTime.Today.ToString("d.M.yyyy");
            rootfood = new Foods();
            rootdiary = new Diary();
            saveData = new SaveData();

            // Loads foods and diary from json files.
            LoadData loadData = new LoadData();
            allFoodsList = loadData.LoadFoods();
            diaryList = loadData.LoadDiary();

            PopulateListBoxes();
            dataGridViewFoods.DataSource = allFoodsList.ToList(); 
        }        
        #endregion     

        #region SELECTION CHANGE & SELECTED CLEAR
        // Calculates and prints total energy, macros and E%.
        private void PerformSelectionChange(int totalEnergy, int totalProteinGrams, int totalCarbsGrams, int totalFatGrams, int totalSFatGrams)
        {
            int proteinEnergy = totalProteinGrams * 4;
            int carbsEnergy = totalCarbsGrams * 4;
            int fatEnergy = totalFatGrams * 9;
            double proteinEnergyShare = ((double)proteinEnergy / (double)totalEnergy) * 100;
            double carbsEnergyShare = ((double)carbsEnergy / (double)totalEnergy) * 100;
            double fatEnergyShare = ((double)fatEnergy / (double)totalEnergy) * 100;

            labelKcalSum.Text = totalEnergy + Properties.Resources.CaloriesText;
            labelProteinSum.Text = totalProteinGrams + Properties.Resources.GramsText;
            labelCarbsSum.Text = totalCarbsGrams + Properties.Resources.GramsText;
            labelFatSum.Text = totalFatGrams + Properties.Resources.GramsText;
            labelSFatSum.Text = totalSFatGrams + Properties.Resources.GramsText;
            labelProteinShare.Text = Math.Round(proteinEnergyShare) + Properties.Resources.EnergyShareText;
            labelCarbsShare.Text = Math.Round(carbsEnergyShare) + Properties.Resources.EnergyShareText;
            labelFatShare.Text = Math.Round(fatEnergyShare) + Properties.Resources.EnergyShareText;

            // If total energy share reaches 150 E%, it means user has probably filled wrong food information.
            if ((proteinEnergyShare + carbsEnergyShare + fatEnergyShare) > 130)
            {
                labelEnergyCheck.Text = Properties.Resources.EnergyShareCheck;
            }
            else
            {
                labelEnergyCheck.Text = string.Empty;
            }          
        }

        // Clears all calculations, selectedBox and progressbar.
        private void ClearSelected()
        {
            selectedFoods.Clear();
            selectedFoodsBox.DataSource = null;
            selectedFoodsBox.Items.Clear();
            sumKcal = 0;
            sumProtein = 0;
            sumCarbs = 0;
            sumFat = 0;
            sumSFat = 0;
            progressBar.Value = 0;
            progressLabel.Text = 0 + Properties.Resources.CaloriesText;
            labelKcalSum.Text = string.Empty;
            labelProteinSum.Text = string.Empty;
            labelCarbsSum.Text = string.Empty;
            labelFatSum.Text = string.Empty;
            labelSFatSum.Text = string.Empty;
            labelProteinShare.Text = string.Empty;
            labelCarbsShare.Text = string.Empty;
            labelFatShare.Text = string.Empty;
            labelEnergyCheck.Text = string.Empty;
            labelSelectedName.Text = string.Empty;
            labelKcal.Text = string.Empty;
            labelProtein.Text = string.Empty;
            labelCarbs.Text = string.Empty;
            labelFat.Text = string.Empty;
            labelSFat.Text = string.Empty;
            ModifyProgressBarColor.SetState(progressBar, 1);
            progressLabel.BackColor = System.Drawing.Color.Lime;
            textBoxTargetKcal.Enabled = true;
        }
        #endregion

        #region BUTTONS
        // Adds food item to dataGridView.
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            Food f = new Food();
            allFoodsList.Add(f);
            dataGridViewFoods.DataSource = allFoodsList.ToList(); 
            int index = dataGridViewFoods.Rows.GetLastRow(DataGridViewElementStates.Visible);
            dataGridViewFoods.CurrentCell = dataGridViewFoods.Rows[index].Cells["FoodName"];
            dataGridViewFoods.BeginEdit(true);
            PopulateListBoxes();  
        }

        // Deletes food item from dataGridView.
        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewFoods.SelectedRows.Count > 0)
            {
                if (MessageBox.Show(Properties.Resources.ConfirmDelete, Properties.Resources.ConfirmDeleteTitle, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Food f = dataGridViewFoods.SelectedRows[0].DataBoundItem as Food;
                    allFoodsList.Remove(f);
                    dataGridViewFoods.DataSource = allFoodsList.ToList(); 
                    PopulateListBoxes();      
               }                           
            }
        }
       
        // Saves all food items to json file.
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show(Properties.Resources.FileSaveConfirmation, Properties.Resources.FileSaveTitle, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {               
                saveData.SaveJson(JsonConvert.SerializeObject(rootfood), false);   
            }
        }

        // Clears selected foods from listbox.
        private void btnClearSelected_Click_1(object sender, EventArgs e)
        {
            ClearSelected();
        }       
        #endregion

        #region LISTBOXES
        // Populates listboxes with data.
        private void PopulateListBoxes()
        {
            solids = allFoodsList.Where(x => x.Category == "Ruoka").ToList();
            drinks = allFoodsList.Where(x => x.Category == "Juoma").ToList();
            supplements = allFoodsList.Where(x => x.Category == "Lisäravinne").ToList();
            extras = allFoodsList.Where(x => x.Category == "Lisuke").ToList(); 
            solidsBox.DataSource = solids.Select(y => y.FoodName).ToList();
            drinksBox.DataSource = drinks.Select(y => y.FoodName).ToList();
            supplementsBox.DataSource = supplements.Select(y => y.FoodName).ToList();
            extrasBox.DataSource = extras.Select(y => y.FoodName).ToList();
        }

        // Prints values and info of selected solid food.
        private void solidsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = solidsBox.SelectedIndex;
            labelSelectedName.Text = solids[index].FoodName.ToString();
            labelKcal.Text = solids[index].Kcal.ToString() + Properties.Resources.CaloriesText;
            labelProtein.Text = solids[index].Protein.ToString() + Properties.Resources.GramsText;
            labelCarbs.Text = solids[index].Carbs.ToString() + Properties.Resources.GramsText;
            labelFat.Text = solids[index].Fat.ToString() + Properties.Resources.GramsText;
            labelSFat.Text = solids[index].SFat.ToString() + Properties.Resources.GramsText;

            if (solids[index].Info == null || solids[index].Info.Equals(" "))
            {
                labelInfo.Text = string.Empty;               
            }
            else
            {
                labelInfo.Text = Properties.Resources.InfoText + solids[index].Info.ToString();
            }
        }

        // Prints values and info of selected drink.
        private void drinksBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = drinksBox.SelectedIndex;
            labelSelectedName.Text = drinks[index].FoodName.ToString();
            labelKcal.Text = drinks[index].Kcal.ToString() + Properties.Resources.CaloriesText;
            labelProtein.Text = drinks[index].Protein.ToString() + Properties.Resources.GramsText;
            labelCarbs.Text = drinks[index].Carbs.ToString() + Properties.Resources.GramsText;
            labelFat.Text = drinks[index].Fat.ToString() + Properties.Resources.GramsText;
            labelSFat.Text = drinks[index].SFat.ToString() + Properties.Resources.GramsText;

            if (drinks[index].Info == null || drinks[index].Info.Equals(" "))
            {
                labelInfo.Text = string.Empty;                
            }
            else
            {
                labelInfo.Text = Properties.Resources.InfoText + drinks[index].Info.ToString();
            }
        }

        // Prints values and info of selected supplement.
        private void supplementsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = supplementsBox.SelectedIndex;
            labelSelectedName.Text = supplements[index].FoodName.ToString();
            labelKcal.Text = supplements[index].Kcal.ToString() + Properties.Resources.CaloriesText;
            labelProtein.Text = supplements[index].Protein.ToString() + Properties.Resources.GramsText;
            labelCarbs.Text = supplements[index].Carbs.ToString() + Properties.Resources.GramsText;
            labelFat.Text = supplements[index].Fat.ToString() + Properties.Resources.GramsText;
            labelSFat.Text = supplements[index].SFat.ToString() + Properties.Resources.GramsText;

            if (supplements[index].Info == null || supplements[index].Info.Equals(" "))
            {
                labelInfo.Text = string.Empty;               
            }
            else
            {
                labelInfo.Text = Properties.Resources.InfoText + supplements[index].Info.ToString();
            }
        }

        // Prints values and info of selected extra.
        private void extrasBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = extrasBox.SelectedIndex;
            labelSelectedName.Text = extras[index].FoodName.ToString();
            labelKcal.Text = extras[index].Kcal.ToString() + Properties.Resources.CaloriesText;
            labelProtein.Text = extras[index].Protein.ToString() + Properties.Resources.GramsText;
            labelCarbs.Text = extras[index].Carbs.ToString() + Properties.Resources.GramsText;
            labelFat.Text = extras[index].Fat.ToString() + Properties.Resources.GramsText;
            labelSFat.Text = extras[index].SFat.ToString() + Properties.Resources.GramsText;

            if (extras[index].Info == null || extras[index].Info.Equals(" "))
            {
                labelInfo.Text = string.Empty;              
            }
            else
            {
                labelInfo.Text = Properties.Resources.InfoText + extras[index].Info.ToString();
            }
        }
        #endregion

        #region LISTBOX CLICKS
        // Solid food is added by double click and total macro values are calculated. Solid food is added to selectedFood list.
        private void solidBox_DoubleClick(object sender, EventArgs e)
        {
            if (solidsBox.SelectedItem != null)
            {                
                selectedFoods.Add(solidsBox.SelectedValue.ToString());
                selectedFoodsBox.DataSource = selectedFoods.ToList();
                int index = solidsBox.SelectedIndex;
                sumKcal = sumKcal + Convert.ToInt32(solids[index].Kcal);
                sumProtein = sumProtein + Convert.ToInt32(solids[index].Protein);
                sumCarbs = sumCarbs + Convert.ToInt32(solids[index].Carbs);
                sumFat = sumFat + Convert.ToInt32(solids[index].Fat);
                sumSFat = sumSFat + Convert.ToInt32(solids[index].SFat);
                PerformSelectionChange(sumKcal, sumProtein, sumCarbs, sumFat, sumSFat);

                if (textBoxTargetKcal.Text != string.Empty)
                {
                    ProgressBarRefresh(Convert.ToInt32(solids[index].Kcal), sumKcal);
                }
                else
                {
                    textBoxTargetKcal.Enabled = false;
                }
            }
        }

        // Drink is added by double click and total macro values are calculated. Drink is added to selectedFood list.
        private void drinksBox_DoubleClick(object sender, EventArgs e)
        {
            if (drinksBox.SelectedItem != null)
            {              
                selectedFoods.Add(drinksBox.SelectedValue.ToString());
                selectedFoodsBox.DataSource = selectedFoods.ToList();
                int index = drinksBox.SelectedIndex;
                sumKcal = sumKcal + Convert.ToInt32(drinks[index].Kcal);
                sumProtein = sumProtein + Convert.ToInt32(drinks[index].Protein);
                sumCarbs = sumCarbs + Convert.ToInt32(drinks[index].Carbs);
                sumFat = sumFat + Convert.ToInt32(drinks[index].Fat);
                sumSFat = sumSFat + Convert.ToInt32(drinks[index].SFat);
                PerformSelectionChange(sumKcal, sumProtein, sumCarbs, sumFat, sumSFat);

                if (textBoxTargetKcal.Text != string.Empty)
                {
                    ProgressBarRefresh(Convert.ToInt32(drinks[index].Kcal), sumKcal);
                }
                else
                {
                    textBoxTargetKcal.Enabled = false;
                }
            }
        }

        // Supplement is added by double click and total macro values are calculated. Supplement is added to selectedFood list.
        private void supplementsBox_DoubleClick(object sender, EventArgs e)
        {
            if (supplementsBox.SelectedItem != null)
            {              
                selectedFoods.Add(supplementsBox.SelectedValue.ToString());
                selectedFoodsBox.DataSource = selectedFoods.ToList();
                int index = supplementsBox.SelectedIndex;
                sumKcal = sumKcal + Convert.ToInt32(supplements[index].Kcal);
                sumProtein = sumProtein + Convert.ToInt32(supplements[index].Protein);
                sumCarbs = sumCarbs + Convert.ToInt32(supplements[index].Carbs);
                sumFat = sumFat + Convert.ToInt32(supplements[index].Fat);
                sumSFat = sumSFat + Convert.ToInt32(supplements[index].SFat);
                PerformSelectionChange(sumKcal, sumProtein, sumCarbs, sumFat, sumSFat);

                if (textBoxTargetKcal.Text != string.Empty)
                {
                    ProgressBarRefresh(Convert.ToInt32(supplements[index].Kcal), sumKcal);
                }
                else
                {
                    textBoxTargetKcal.Enabled = false;
                }
            }
        }

        // Extra is added by double click and total macro values are calculated. Extra is added to selectedFood list.
        private void extrasBox_DoubleClick(object sender, EventArgs e)
        {
            if (extrasBox.SelectedItem != null)
            {
                selectedFoods.Add(extrasBox.SelectedValue.ToString());
                selectedFoodsBox.DataSource = selectedFoods.ToList();
                int index = extrasBox.SelectedIndex;
                sumKcal = sumKcal + Convert.ToInt32(extras[index].Kcal);
                sumProtein = sumProtein + Convert.ToInt32(extras[index].Protein);
                sumCarbs = sumCarbs + Convert.ToInt32(extras[index].Carbs);
                sumFat = sumFat + Convert.ToInt32(extras[index].Fat);
                sumSFat = sumSFat + Convert.ToInt32(extras[index].SFat);
                PerformSelectionChange(sumKcal, sumProtein, sumCarbs, sumFat, sumSFat);

                if (textBoxTargetKcal.Text != string.Empty)
                {
                    ProgressBarRefresh(Convert.ToInt32(extras[index].Kcal), sumKcal);
                }
                else
                {
                    textBoxTargetKcal.Enabled = false;
                }
            }
        }

        // Removes food item from selectedFoodBox and calculates macro values.
        private void selectedFoodBox_DoubleClick(object sender, EventArgs e)
        {
            if (selectedFoodsBox.SelectedItem != null)
            {
                foreach (Food food in allFoodsList)
                {
                    if (food.FoodName.Equals(selectedFoodsBox.SelectedValue.ToString()))
                    {
                        sumKcal = sumKcal - Convert.ToInt32(food.Kcal);
                        sumProtein = sumProtein - Convert.ToInt32(food.Protein);
                        sumCarbs = sumCarbs - Convert.ToInt32(food.Carbs);
                        sumFat = sumFat - Convert.ToInt32(food.Fat);
                        sumSFat = sumSFat - Convert.ToInt32(food.SFat);
                        PerformSelectionChange(sumKcal, sumProtein, sumCarbs, sumFat, sumSFat);
                        selectedFoods.RemoveAt(selectedFoods.IndexOf(food.FoodName));
                        selectedFoodsBox.DataSource = selectedFoods.ToList();

                        if (textBoxTargetKcal.Enabled)
                        {
                            progressBar.Value = sumKcal;
                            progressLabel.Text = sumKcal + Properties.Resources.CaloriesText;
                        }
                        break;
                    }                   
                }
            }

            if (selectedFoods.Count == 0)
            {
                textBoxTargetKcal.Enabled = true;
                labelKcalSum.Text = string.Empty;
                labelProteinSum.Text = string.Empty;
                labelCarbsSum.Text = string.Empty;
                labelFatSum.Text = string.Empty;
                labelSFatSum.Text = string.Empty;
                labelProteinShare.Text = string.Empty;
                labelCarbsShare.Text = string.Empty;
                labelFatShare.Text = string.Empty;
            }
        }
        #endregion     

        #region PROGRESSBAR
        // Refreshes progressbar after adding or removing food items.
        private void ProgressBarRefresh(int calories, int kcalSum)
        {
            int kcalTarget = Convert.ToInt32(textBoxTargetKcal.Text);
            progressLabelTarget.Text = kcalTarget + Properties.Resources.CaloriesText;           
            progressBar.Maximum = kcalTarget; 
            progressBar.Step = calories;         
            progressBar.PerformStep();
            progressLabel.Text = kcalSum + Properties.Resources.CaloriesText;

            if (kcalTarget < sumKcal)
            {
                ModifyProgressBarColor.SetState(progressBar, 2);
                progressLabel.BackColor = System.Drawing.Color.Red;
                textBoxTargetKcal.Enabled = false;
            }           
            else
            {
                ModifyProgressBarColor.SetState(progressBar, 1);
                progressLabel.BackColor = System.Drawing.Color.Lime;
            }
        }

        // Checks progressbar textbox input. Only numbers allowed.
        private void textBoxKcal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region DATAGRIDVIEW
        // Starts cell editing.
        private void dataGridViewFoods_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            Food selectedStatement = dataGridViewFoods.Rows[e.RowIndex].DataBoundItem as Food;

            if (String.IsNullOrEmpty(selectedStatement.FoodName)) // new statement
                return;

            dataGridViewFoods.Rows[e.RowIndex].ReadOnly = false;
        }

        // Validates cell after editing.
        private void dataGridViewFoods_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            dataGridViewFoods.Rows[e.RowIndex].ErrorText = string.Empty;
            Food selectedRuoat = dataGridViewFoods.CurrentRow.DataBoundItem as Food;

            if (dataGridViewFoods.Columns[e.ColumnIndex].HeaderText == "Ruoka")
            {
                if (selectedRuoat.FoodName != e.FormattedValue.ToString() && allFoodsList.Count(s => s.FoodName == e.FormattedValue.ToString()) > 0)
                {
                    e.Cancel = true;
                    dataGridViewFoods.Rows[e.RowIndex].ErrorText = Properties.Resources.FoodExist;
                }
            }

            if (dataGridViewFoods.Columns[e.ColumnIndex].HeaderText == "Prot" ||
                dataGridViewFoods.Columns[e.ColumnIndex].HeaderText == "HH" ||
                dataGridViewFoods.Columns[e.ColumnIndex].HeaderText == "Rasva" ||
                dataGridViewFoods.Columns[e.ColumnIndex].HeaderText == "T rasva" ||
                dataGridViewFoods.Columns[e.ColumnIndex].HeaderText == "kcal")
            {
                int newInteger;

                if (!int.TryParse(e.FormattedValue.ToString(), out newInteger) || newInteger < 0)
                {
                    e.Cancel = true;
                    dataGridViewFoods.Rows[e.RowIndex].ErrorText = Properties.Resources.ValidateError;
                }
            }

            if (dataGridViewFoods.Columns[e.ColumnIndex].HeaderText == "Info" && e.FormattedValue.ToString().Equals(string.Empty))
            {
                allFoodsList[e.RowIndex].Info = " ";
            }
        }

        // Cell editing finished.
        private void dgvRuoka_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            PopulateListBoxes();
        }
     
        // Validates row data after validating all cells.
        private void dataGridViewFoods_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dataGridViewFoods.Rows[e.RowIndex].Cells["Category"].Value == null ||
                dataGridViewFoods.Rows[e.RowIndex].Cells["FoodName"].Value == null ||
                dataGridViewFoods.Rows[e.RowIndex].Cells["Kcal"].Value == null ||
                dataGridViewFoods.Rows[e.RowIndex].Cells["Protein"].Value == null ||
                dataGridViewFoods.Rows[e.RowIndex].Cells["Carbs"].Value == null ||
                dataGridViewFoods.Rows[e.RowIndex].Cells["Fat"].Value == null ||
                dataGridViewFoods.Rows[e.RowIndex].Cells["SFat"].Value == null)
            {
                dataGridViewFoods.Rows[e.RowIndex].ErrorText = Properties.Resources.ValidateError;
                e.Cancel = true;
            }
            dataGridViewFoods.Rows[e.RowIndex].ErrorText = String.Empty;
        }

        // Formats food data after confirmation.
        private void formatFoodsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Properties.Resources.ClearFoodtableWarning, Properties.Resources.ClearFoodtableTitle, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FormatFoods();
            }
        }

        // Clears all food data and overwrites FoodData.json file.
        public void FormatFoods()
        {
            allFoodsList.Clear();
            saveData.SaveJson(JsonConvert.SerializeObject(rootfood), false);
            PopulateListBoxes();
            dataGridViewFoods.DataSource = allFoodsList;
            ClearSelected();
        }

        // Opens windows file dialog.
        private void createFoodsBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialogFoods.ShowDialog();
        }

        // Creates FoodData.json file to selected path.
        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            File.WriteAllText(saveFileDialogFoods.FileName, JsonConvert.SerializeObject(rootfood));
        }

        // Opens windows file dialog and loads selected json backup file.
        private void loadFoodsBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialogFoods.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FormatFoods();
                    string json = File.ReadAllText(openFileDialogFoods.FileName);
                    rootfood = JsonConvert.DeserializeObject<Foods>(json);
                    allFoodsList = rootfood.FoodDataList;
                    saveData.SaveJson(json, false);
                    PopulateListBoxes();
                    dataGridViewFoods.DataSource = allFoodsList;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Properties.Resources.LoadError);
                    Debug.WriteLine(ex);
                }
            }
        }
        #endregion        

        #region DIARY
        // Checks if selected day has already diary item.
        private void monthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            string date = monthCalendar.SelectionRange.Start.ToShortDateString();
            btnAddToDiary.Enabled = true;
            btnDeleteFromDiary.Enabled = false;  
            dateInUse = false;         
            groupBoxDiaryDay.Text = date;
            labelDiaryKcal.Text = string.Empty;
            labelDiaryProtein.Text = string.Empty;
            labelDiaryCarbs.Text = string.Empty;
            labelDiaryFat.Text = string.Empty;
            labelDiarySFat.Text = string.Empty;

            // Refresh diagram if selecting day after different month selected.
            if (monthCalendar.SelectionStart.Month != currentMonth)
            {
                currentMonth = monthCalendar.SelectionStart.Month;
                UpdateDiagram();  
            }

            foreach (DiaryDay diaryItem in diaryList)
            {
                if (diaryItem.Date.Equals(date))
                {                   
                    labelDiaryKcal.Text = diaryItem.Kcal + Properties.Resources.CaloriesText;
                    labelDiaryProtein.Text = diaryItem.Protein + Properties.Resources.GramsText;
                    labelDiaryCarbs.Text = diaryItem.Carbs + Properties.Resources.GramsText;
                    labelDiaryFat.Text = diaryItem.Fat + Properties.Resources.GramsText;
                    labelDiarySFat.Text = diaryItem.SFat + Properties.Resources.GramsText;                   
                    btnAddToDiary.Enabled = false;
                    btnDeleteFromDiary.Enabled = true;  
                    dateInUse = true;
                    break;
                }                              
            }
        }

        // Adds selected foods data to selected diary date and overwrites DiaryData.json file.
        private void btnAddToDiary_Click_1(object sender, EventArgs e)
        {
            DiaryDay diaryItem = new DiaryDay();
            diaryItem.Date = monthCalendar.SelectionRange.Start.ToShortDateString();
            diaryItem.Carbs = sumCarbs.ToString();
            diaryItem.Kcal = sumKcal.ToString();
            diaryItem.Protein = sumProtein.ToString();
            diaryItem.Fat = sumFat.ToString();
            diaryItem.SFat = sumSFat.ToString();
            diaryList.Add(diaryItem);
            saveData.SaveJson(JsonConvert.SerializeObject(rootdiary), true);
            labelDiaryKcal.Text = diaryItem.Kcal + Properties.Resources.CaloriesText;
            labelDiaryProtein.Text = diaryItem.Protein + Properties.Resources.GramsText;
            labelDiaryCarbs.Text = diaryItem.Carbs + Properties.Resources.GramsText;
            labelDiaryFat.Text = diaryItem.Fat + Properties.Resources.GramsText;
            labelDiarySFat.Text = diaryItem.SFat + Properties.Resources.GramsText;
            btnAddToDiary.Enabled = false;
            btnDeleteFromDiary.Enabled = true;
            UpdateDiagram();            
        }

        // Deletes selected dates data from diary.
        private void btnDeleteFromDiary_Click_1(object sender, EventArgs e)
        {
            if (dateInUse)
            {
                if (MessageBox.Show(Properties.Resources.ConfirmDelete, Properties.Resources.ConfirmDeleteTitle, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int index = 0;

                    foreach (DiaryDay diaryItem in diaryList)
                    {
                        if (diaryItem.Date.Equals(monthCalendar.SelectionRange.Start.ToShortDateString()))
                        {
                            break;
                        }
                        index++;
                    }
                    diaryList.RemoveAt(index);
                    saveData.SaveJson(JsonConvert.SerializeObject(rootdiary), true);
                    labelDiaryKcal.Text = string.Empty;
                    labelDiaryProtein.Text = string.Empty;
                    labelDiaryCarbs.Text = string.Empty;
                    labelDiaryFat.Text = string.Empty;
                    labelDiarySFat.Text = string.Empty;                   
                    btnAddToDiary.Enabled = true;
                    btnDeleteFromDiary.Enabled = false;
                    UpdateDiagram();
                }      
            }
        }

        // Formats diary data after confirmation.
        private void formatDiaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Properties.Resources.ClearDiaryWarning, Properties.Resources.ClearDiaryTitle, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FormatDiary();
            }
        }

        // Clears all diary data and overwrites DiaryData.json file.
        public void FormatDiary()
        {           
            diaryList.Clear();
            saveData.SaveJson(JsonConvert.SerializeObject(rootdiary), true);
            labelDiaryKcal.Text = string.Empty;
            labelDiaryProtein.Text = string.Empty;
            labelDiaryCarbs.Text = string.Empty;
            labelDiaryFat.Text = string.Empty;
            labelDiarySFat.Text = string.Empty;
            UpdateDiagram();
            btnAddToDiary.Enabled = true;
            btnDeleteFromDiary.Enabled = false;            
        }

        // Opens windows file dialog.
        private void createDiaryBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialogDiary.ShowDialog();
        }

        // Creates DiaryData.json file to selected path.
        private void saveFileDialog2_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            File.WriteAllText(saveFileDialogDiary.FileName, JsonConvert.SerializeObject(rootdiary));
        }

        // Opens windows file dialog and loads selected json backup file.
        private void loadDiaryBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialogDiary.ShowDialog() == DialogResult.OK)
            {               
                try
                {
                    FormatDiary();
                    string json = File.ReadAllText(openFileDialogDiary.FileName);
                    rootdiary = JsonConvert.DeserializeObject<Diary>(json);
                    diaryList = rootdiary.DiaryDataList;
                    saveData.SaveJson(json, true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Properties.Resources.LoadError);
                    Debug.WriteLine(ex);
                }
            }
        }
        #endregion       

        #region DIAGRAM
        // Calorie radiobutton selected.
        private void radioKcal_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDiagram();
        }

        // Protein radiobutton selected.
        private void radioProtein_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDiagram();
        }

        // Carbs radiobutton selected.
        private void radioCarbs_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDiagram();
        }

        // Fat radiobutton selected.
        private void radioFat_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDiagram();
        }

        // Updates diagram when user selects diagram tab.
        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == tabPageDiary)
            {
                UpdateDiagram();
            }
        }

        // Updates diagram after every click.
        private void UpdateDiagram()
        {
            groupBoxDiagram.Text = string.Empty;

            foreach (var series in chart.Series)
            {
                series.Points.Clear();
            }

            diaryList = diaryList.OrderByDescending(x => x.Date).ToList();
            string month = monthCalendar.SelectionRange.Start.ToShortDateString();
            string year = DateTime.Parse(month).ToString("M.yyyy");
            string monthName = DateTime.Parse(month).ToString("MMMM");

            foreach (DiaryDay day in diaryList)
            {
                if (day.Date.Contains(year))
                {
                    int dayInt = Convert.ToInt32(DateTime.Parse(day.Date).ToString("dd"));
                    
                    if (radioKcal.Checked)
                    {
                        chart.Series["kcal"].Points.AddXY(dayInt, day.Kcal);
                        chart.Series["kcal"].Color = System.Drawing.Color.FromArgb(0, 0, 255);
                        groupBoxDiagram.Text = monthName + "n kalorit";
                    }

                    if (radioProtein.Checked)
                    {
                        chart.Series["kcal"].Points.AddXY(dayInt, day.Protein);
                        chart.Series["kcal"].Color = System.Drawing.Color.FromArgb(100, 0, 100);
                        groupBoxDiagram.Text = monthName + "n proteiinit";
                    }

                    if (radioCarbs.Checked)
                    {
                        chart.Series["kcal"].Points.AddXY(dayInt, day.Carbs);
                        chart.Series["kcal"].Color = System.Drawing.Color.FromArgb(0, 150, 0);
                        groupBoxDiagram.Text = monthName + "n hiilihydraatit";
                    }

                    if (radioFat.Checked)
                    {
                        chart.Series["kcal"].Points.AddXY(dayInt, day.Fat);
                        chart.Series["kcal"].Color = System.Drawing.Color.FromArgb(255, 0, 0);
                        groupBoxDiagram.Text = monthName + "n rasvat";
                    }

                    if (radioSFat.Checked)
                    {
                        chart.Series["kcal"].Points.AddXY(dayInt, day.SFat);
                        chart.Series["kcal"].Color = System.Drawing.Color.FromArgb(250, 100, 50);
                        groupBoxDiagram.Text = monthName + "n tyydyttyneet rasvat";
                    }                       
                }
            }                     
        }       
        #endregion
  
        #region INSTRUCTIONS
        // Calculator instructions popup.
        private void calculatorInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Properties.Resources.CalculatorInstruction, Properties.Resources.CalculatoTitle);       
        }

        // Food table editing instructions popup.
        private void foodEditInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Properties.Resources.FoodtableInstruction, Properties.Resources.FoodtableTitle);
        }

        // Diary instructions popup.
        private void diaryInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Properties.Resources.DiaryInstruction, Properties.Resources.DiaryTitle);
        }

        // Backup instructions popup.
        private void backupInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Properties.Resources.BackupInstruction, Properties.Resources.BackupTitle);
        }
        #endregion        

        #region PAINT LISTBOXES
        // Paints solidsBox.
        private void solidsBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();

            bool isItemSelected = ((e.State & DrawItemState.Selected) == DrawItemState.Selected);
            int itemIndex = e.Index;
            if (itemIndex >= 0 && itemIndex < solidsBox.Items.Count)
            {
                Graphics g = e.Graphics;
                SolidBrush backgroundColorBrush = new SolidBrush((isItemSelected) ? Color.DimGray : Color.LightGray);
                g.FillRectangle(backgroundColorBrush, e.Bounds);              
                SolidBrush itemTextColorBrush = (isItemSelected) ? new SolidBrush(Color.White) : new SolidBrush(Color.Black);
                string itemText = solidsBox.Items[itemIndex].ToString();
                g.DrawString(itemText, e.Font, itemTextColorBrush, solidsBox.GetItemRectangle(itemIndex).Location);
                backgroundColorBrush.Dispose();
                itemTextColorBrush.Dispose();
            }
            e.DrawFocusRectangle();
        }

        // Paints drinksBox.
        private void drinksBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            bool isItemSelected = ((e.State & DrawItemState.Selected) == DrawItemState.Selected);
            int itemIndex = e.Index;
            if (itemIndex >= 0 && itemIndex < drinksBox.Items.Count)
            {
                Graphics g = e.Graphics;
                SolidBrush backgroundColorBrush = new SolidBrush((isItemSelected) ? Color.DimGray : Color.LightGray);
                g.FillRectangle(backgroundColorBrush, e.Bounds);             
                SolidBrush itemTextColorBrush = (isItemSelected) ? new SolidBrush(Color.White) : new SolidBrush(Color.Black);
                string itemText = drinksBox.Items[itemIndex].ToString();
                g.DrawString(itemText, e.Font, itemTextColorBrush, drinksBox.GetItemRectangle(itemIndex).Location);
                backgroundColorBrush.Dispose();
                itemTextColorBrush.Dispose();
            }
            e.DrawFocusRectangle();
        }

        // Paints supplementsBox.
        private void supplementsBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            bool isItemSelected = ((e.State & DrawItemState.Selected) == DrawItemState.Selected);
            int itemIndex = e.Index;
            if (itemIndex >= 0 && itemIndex < supplementsBox.Items.Count)
            {
                Graphics g = e.Graphics;
                SolidBrush backgroundColorBrush = new SolidBrush((isItemSelected) ? Color.DimGray : Color.LightGray);
                g.FillRectangle(backgroundColorBrush, e.Bounds);               
                SolidBrush itemTextColorBrush = (isItemSelected) ? new SolidBrush(Color.White) : new SolidBrush(Color.Black);
                string itemText = supplementsBox.Items[itemIndex].ToString();
                g.DrawString(itemText, e.Font, itemTextColorBrush, supplementsBox.GetItemRectangle(itemIndex).Location);
                backgroundColorBrush.Dispose();
                itemTextColorBrush.Dispose();
            }
            e.DrawFocusRectangle();
        }

        // Paints extrasBox.
        private void extrasBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            bool isItemSelected = ((e.State & DrawItemState.Selected) == DrawItemState.Selected);
            int itemIndex = e.Index;
            if (itemIndex >= 0 && itemIndex < extrasBox.Items.Count)
            {
                Graphics g = e.Graphics;
                SolidBrush backgroundColorBrush = new SolidBrush((isItemSelected) ? Color.DimGray : Color.LightGray);
                g.FillRectangle(backgroundColorBrush, e.Bounds);               
                SolidBrush itemTextColorBrush = (isItemSelected) ? new SolidBrush(Color.White) : new SolidBrush(Color.Black);
                string itemText = extrasBox.Items[itemIndex].ToString();
                g.DrawString(itemText, e.Font, itemTextColorBrush, extrasBox.GetItemRectangle(itemIndex).Location);
                backgroundColorBrush.Dispose();
                itemTextColorBrush.Dispose();
            }
            e.DrawFocusRectangle();
        }

        // Paints selectedFoodsBox.
        private void selectedFoodsBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            bool isItemSelected = ((e.State & DrawItemState.Selected) == DrawItemState.Selected);
            int itemIndex = e.Index;
            if (itemIndex >= 0 && itemIndex < selectedFoodsBox.Items.Count)
            {
                Graphics g = e.Graphics;
                SolidBrush backgroundColorBrush = new SolidBrush((isItemSelected) ? Color.DimGray : Color.LightGray);
                g.FillRectangle(backgroundColorBrush, e.Bounds);               
                SolidBrush itemTextColorBrush = (isItemSelected) ? new SolidBrush(Color.White) : new SolidBrush(Color.Black);
                string itemText = selectedFoodsBox.Items[itemIndex].ToString();
                g.DrawString(itemText, e.Font, itemTextColorBrush, selectedFoodsBox.GetItemRectangle(itemIndex).Location);
                backgroundColorBrush.Dispose();
                itemTextColorBrush.Dispose();
            }
            e.DrawFocusRectangle();
        }   
        #endregion            

        #region EXIT
        // Exits program.
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion     
    }
}