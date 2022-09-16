using System;
using System.Collections.Generic;
using System.Linq;

namespace TestTabliczkiMnozenia.Code
{
    /// <summary>
    /// Random test cases generator.
    /// </summary>
    internal static class MultiplicationTestCasesGenerator
    {
        public static List<TestItem> Generate(int count, int minNumberValue, int maxNumberValue)
        {
            Random random = new();

            return Enumerable
                .Range(1, count)
                .Select(_ => CreateTestItem(random, minNumberValue, maxNumberValue))
                .ToList();
        }

        private static TestItem CreateTestItem(Random random, int minNumberValue, int maxNumberValue)
        {
            int number1 = random.Next(minNumberValue, maxNumberValue + 1);
            int number2 = random.Next(minNumberValue, maxNumberValue + 1);
            return new TestItem(number1, number2, number1 * number2);
        }
    }
}
