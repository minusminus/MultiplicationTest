namespace TestTabliczkiMnozenia.Code
{
    /// <summary>
    /// UI elements visibility.
    /// </summary>
    internal class UIElementsVisibility
    {
        public bool StartVisible = true;
        public bool TestVisible = false;
        public bool ResultVisible = false;

        public void Set(bool startVisible, bool testVisible, bool resultVisible)
        {
            StartVisible = startVisible;
            TestVisible = testVisible;
            ResultVisible = resultVisible;
        }
    }
}
