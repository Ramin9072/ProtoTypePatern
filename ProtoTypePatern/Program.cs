using ProtoTypePatern.Model;

internal class Program
{
    private static void Main(string[] args)
    {
        var money = new Money(10, "$");
        var moneyColne =money.Clone();
    }
}