using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ClassLibrary;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly NutritionTracker _tracker = new NutritionTracker();

        public Form1()
        {
            InitializeComponent();
            UpdateSummary();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text;
                decimal cal = decimal.Parse(txtCalories.Text);
                decimal p = decimal.Parse(txtProteins.Text);
                decimal f = decimal.Parse(txtFats.Text);
                decimal c = decimal.Parse(txtCarbs.Text);

                var entry = new FoodEntry(name, cal, p, f, c);
                _tracker.AddEntry(entry);

                lstEntries.Items.Add($"{entry.Date:HH:mm} | {entry.Name} | {entry.Calories} ккал");
                UpdateSummary();
                ClearInputs();
                statusLabel.Text = "Запись успешно добавлена";
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректные числовые значения!", "Ошибка ввода",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Лимит превышен", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Непредвиденная ошибка: " + ex.Message, "Сбой",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _tracker.ClearDay();
            lstEntries.Items.Clear();
            UpdateSummary();
            statusLabel.Text = "День очищен";
        }

        private void UpdateSummary()
        {
            lblTotal.Text = $"Всего за день: {_tracker.GetDailyTotalCalories()} ккал " +
                            $"(Б:{_tracker.GetDailyTotalProteins()} Ж:{_tracker.GetDailyTotalFats()} У:{_tracker.GetDailyTotalCarbs()})";
        }

        private void ClearInputs()
        {
            txtName.Text = "";
            txtCalories.Text = "0";
            txtProteins.Text = "0";
            txtFats.Text = "0";
            txtCarbs.Text = "0";
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("АС «Дневник питания» v1.0\nПерсональное приложение для учёта рациона",
                "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
