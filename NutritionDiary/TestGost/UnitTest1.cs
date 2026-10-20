using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NutritionDiary;
using ClassLibrary;

namespace NutritionDiary.Tests
{
    [TestClass]
    public class FoodEntryTests
    {
        // Тест 1: Валидные данные — объект создаётся корректно
        [TestMethod]
        public void FoodEntry_ValidData_ObjectCreatedSuccessfully()
        {
            // Arrange
            string name = "Овсянка";
            decimal calories = 150;
            decimal proteins = 5;
            decimal fats = 3;
            decimal carbs = 25;

            // Act
            FoodEntry entry = new FoodEntry(name, calories, proteins, fats, carbs);

            // Assert
            Assert.AreEqual(name, entry.Name);
            Assert.AreEqual(calories, entry.Calories);
            Assert.AreEqual(proteins, entry.Proteins);
            Assert.AreEqual(fats, entry.Fats);
            Assert.AreEqual(carbs, entry.Carbs);
            Assert.IsTrue(entry.Date <= DateTime.Now);
        }

        // Тест 2: Пустое название — выбрасывается ArgumentException
        [TestMethod]
        public void FoodEntry_EmptyName_ThrowsArgumentException()
        {
            // Arrange
            string emptyName = "";
            bool exceptionThrown = false;

            // Act & Assert
            try
            {
                new FoodEntry(emptyName, 100, 5, 3, 10);
            }
            catch (ArgumentException ex)
            {
                exceptionThrown = true;
                StringAssert.Contains(ex.Message, "Название продукта не может быть пустым");
            }

            Assert.IsTrue(exceptionThrown, "Ожидалось исключение ArgumentException");
        }

        // Тест 3: Название из пробелов — выбрасывается ArgumentException
        [TestMethod]
        public void FoodEntry_WhitespaceName_ThrowsArgumentException()
        {
            bool exceptionThrown = false;
            try
            {
                new FoodEntry("   ", 100, 5, 3, 10);
            }
            catch (ArgumentException)
            {
                exceptionThrown = true;
            }
            Assert.IsTrue(exceptionThrown);
        }

        // Тест 4: Отрицательные калории — выбрасывается ArgumentOutOfRangeException
        [TestMethod]
        public void FoodEntry_NegativeCalories_ThrowsArgumentOutOfRangeException()
        {
            bool exceptionThrown = false;
            try
            {
                new FoodEntry("Хлеб", -50, 5, 3, 10);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                exceptionThrown = true;
                StringAssert.Contains(ex.Message, "Калории не могут быть отрицательными");
            }
            Assert.IsTrue(exceptionThrown);
        }

        // Тест 5: Отрицательные белки — выбрасывается исключение
        [TestMethod]
        public void FoodEntry_NegativeProteins_ThrowsArgumentOutOfRangeException()
        {
            bool exceptionThrown = false;
            try
            {
                new FoodEntry("Хлеб", 100, -5, 3, 10);
            }
            catch (ArgumentOutOfRangeException)
            {
                exceptionThrown = true;
            }
            Assert.IsTrue(exceptionThrown);
        }

        // Тест 6: Отрицательные жиры — выбрасывается исключение
        [TestMethod]
        public void FoodEntry_NegativeFats_ThrowsArgumentOutOfRangeException()
        {
            bool exceptionThrown = false;
            try
            {
                new FoodEntry("Хлеб", 100, 5, -3, 10);
            }
            catch (ArgumentOutOfRangeException)
            {
                exceptionThrown = true;
            }
            Assert.IsTrue(exceptionThrown);
        }

        // Тест 7: Отрицательные углеводы — выбрасывается исключение
        [TestMethod]
        public void FoodEntry_NegativeCarbs_ThrowsArgumentOutOfRangeException()
        {
            bool exceptionThrown = false;
            try
            {
                new FoodEntry("Хлеб", 100, 5, 3, -10);
            }
            catch (ArgumentOutOfRangeException)
            {
                exceptionThrown = true;
            }
            Assert.IsTrue(exceptionThrown);
        }

        // Тест 8: Граничное значение — калории = 0 (допустимо)
        [TestMethod]
        public void FoodEntry_ZeroCalories_ObjectCreated()
        {
            FoodEntry entry = new FoodEntry("Вода", 0, 0, 0, 0);
            Assert.AreEqual(0, entry.Calories);
        }

        // Тест 9: ToString возвращает корректный формат
        [TestMethod]
        public void FoodEntry_ToString_ReturnsCorrectFormat()
        {
            FoodEntry entry = new FoodEntry("Яблоко", 50, 1, 0, 10);
            string result = entry.ToString();
            StringAssert.Contains(result, "Яблоко");
            StringAssert.Contains(result, "50");
        }
    }
}