using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class FoodEntry
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Calories { get; set; }
        public decimal Proteins { get; set; }
        public decimal Fats { get; set; }
        public decimal Carbs { get; set; }
        public DateTime Date { get; set; }

        public FoodEntry(string name, decimal calories, decimal proteins,
                        decimal fats, decimal carbs)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Название продукта не может быть пустым", nameof(name));
            if (calories < 0)
                throw new ArgumentOutOfRangeException(nameof(calories), "Калории не могут быть отрицательными");
            if (proteins < 0 || fats < 0 || carbs < 0)
                throw new ArgumentOutOfRangeException("БЖУ не могут быть отрицательными");

            Name = name;
            Calories = calories;
            Proteins = proteins;
            Fats = fats;
            Carbs = carbs;
            Date = DateTime.Now;
        }

        // ⬇️ ДОБАВЬТЕ ЭТОТ МЕТОД ️
        public override string ToString()
        {
            return $"{Date:HH:mm} | {Name} | {Calories} ккал";
        }
    }
}
