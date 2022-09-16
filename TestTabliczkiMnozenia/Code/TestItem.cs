namespace TestTabliczkiMnozenia.Code
{
    /// <summary>
    /// Test case data.
    /// </summary>
    internal class TestItem
    {
        public readonly int Number1, Number2, ExpectedValue;

        public TestItem(int number1, int number2, int expectedValue)
        {
            Number1 = number1;
            Number2 = number2;
            ExpectedValue = expectedValue;
        }
    }
}
