using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class NutritionTracker
    {
        public const string LimitExceededMessage = "Превышен дневной лимит калорий";
        public const string EmptyNameMessage = "Название продукта не может быть пустым";

        private readonly List<FoodEntry> _entries = new List<FoodEntry>();
        public decimal DailyCalorieLimit { get; set; } = 2000;

        public IReadOnlyList<FoodEntry> Entries => _entries.AsReadOnly();

        public void AddEntry(FoodEntry entry)
        {
            ArgumentNullException.ThrowIfNull(entry);
            if (GetDailyTotalCalories() + entry.Calories > DailyCalorieLimit)
                throw new InvalidOperationException(LimitExceededMessage);

            _entries.Add(entry);
            SaveToDatabase(entry);
        }

        public void RemoveEntry(int id)
        {
            var entry = _entries.FirstOrDefault(e => e.Id == id);
            if (entry != null) _entries.Remove(entry);
        }

        public decimal GetDailyTotalCalories() => _entries.Sum(e => e.Calories);
        public decimal GetDailyTotalProteins() => _entries.Sum(e => e.Proteins);
        public decimal GetDailyTotalFats() => _entries.Sum(e => e.Fats);
        public decimal GetDailyTotalCarbs() => _entries.Sum(e => e.Carbs);

        public void ClearDay()
        {
            _entries.Clear();
        }

        // Заглушка для интеграционного и нагрузочного тестирования
        private void SaveToDatabase(FoodEntry entry)
        {
            System.Threading.Thread.Sleep(30); // имитация записи в SQLite
        }
    }
}
