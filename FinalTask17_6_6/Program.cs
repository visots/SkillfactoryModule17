namespace FinalTask17_6_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var acc1 = new Account() {Type = "Обычный", Balance = 100, Interest = 10 };

            var acc2 = new Account() { Type = "Зарплатный", Balance = 1000, Interest = 10 };

            Calculator.CalculateInterest(acc1);
            Calculator.CalculateInterest(acc2);



        }
    }
}