namespace Exercise1
{
    internal class Cash
    {
        public int amount { get; set; }
        public int type { get; set; }

        public Cash(int type, int amount)
        {
            this.type = type;
            this.amount = amount;
        }

        public int total()
        {
            return type * amount;
        }

        public override string ToString()
        {
            return "Amount of " + type.ToString() + " baht: " + amount.ToString();
        }
    }
}
