namespace DelegateMasala1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Money money = new Money(1000000);
            MoneyOperator moneyOperator = new MoneyOperator();
            Money.MoneyDelegate moneyDelegate = new Money.MoneyDelegate(moneyOperator.Uzs2Usd);
            moneyOperator.Send(money, "KAPITALBANK", moneyDelegate);


            //Console.WriteLine(moneyDelegate.Method.Name);
            //Console.ReadLine();
        }
    }
}