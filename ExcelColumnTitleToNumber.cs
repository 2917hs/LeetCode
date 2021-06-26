using System;
namespace Program450.LeetCode
{
    public class ExcelColumnTitleToNumber
    {
        public ExcelColumnTitleToNumber()
        {
            string columnTitle = "AC";
            int columnNumber = 0;
            for (int i = 0; i < columnTitle.Length; i++)
            {
                columnNumber *= 26;
                columnNumber += columnTitle[i] - 'A' + 1;
            }
            Console.WriteLine(columnNumber);
        }
    }
}
