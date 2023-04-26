namespace FinalTask17_6_6
{
    public static class Calculator
    {
        // Метод для расчета процентной ставки
        public static void CalculateInterest(IAccount account)
        {
            account.InterestCalculate();
        }
    }
}