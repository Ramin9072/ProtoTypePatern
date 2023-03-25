namespace ProtoTypePatern.Model
{
    public class Money : ICloneable<Money>
    {
        public Money(int amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }

        public int Amount { get; set; }
        public string Currency { get; set; }


        public Money Clone()
        {
            return this.MemberwiseClone() as Money; // ShalwoCompy cannot Nested compy object
        }
    }

    public abstract class Scadule : ICloneable
    {
        public abstract object Clone();
    }
    public class MonthlyScadule : Scadule
    {
        public override object Clone()
        {
            throw new NotImplementedException();
        }
    }
    public class WeeklyScadule : Scadule
    {
        public override object Clone()
        {
            throw new NotImplementedException();
        }
    }

}
