namespace FinalTask17_6_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var acc1 = new SalaryAccount() {  Balance = 10000, Interest = 15 };

            var acc2 = new DefaultAccount() { Balance = 1000, Interest = 10 };

            Calculator.CalculateInterest(acc1);
            Calculator.CalculateInterest(acc2);




        }
    }
}