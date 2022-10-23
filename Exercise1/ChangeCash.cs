namespace Exercise1
{
    internal class ChangeCash
    {
        List<Cash> cashList = new List<Cash>();
        int[] cashType = { 1000, 500, 100, 50, 20, 10, 5, 2, 1 };

        public void menu()
        {
            int amount;
            foreach (var type in cashType)
            {
                if (type >= 20)
                {
                    Console.Write("input bank {0} baht: ", type);
                }
                else
                {
                    Console.Write("input coin {0} baht: ", type);
                }
            input:
                try
                {
                    amount = Int32.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("try again: ");
                    goto input;
                }

                cashList.Add(new Cash(type: type, amount: amount));
            }
            changeMoney();
        }

        void changeMoney()
        {
        input:
            int change = 0;
            Console.Clear();
            showCashList();
            Console.WriteLine("\ntotal money = {0}", TotalMoney());
            Console.Write("total change = ");
            try
            {
                change = Int32.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("try again: ");
                goto input;
            }

            try
            {
                if (change > TotalMoney())
                {
                    Console.WriteLine("\nchange not enough!!");
                    PressAnyKey();
                    goto input;
                }
                else
                {
                    calculateToChange(change);
                    goto input;
                }
            }
            catch (Exception)
            {
                goto input;
            }

        }

        void calculateToChange(int change)
        {
            List<Cash> changeCashList = new List<Cash>();

            Console.Clear();
            Console.WriteLine("change = {0}", change);
            Console.WriteLine("===============================================================\n");
            foreach (Cash cash in cashList)
            {
                int i = 0;
                while (change >= cash.type && cash.amount > 0)
                {
                    change -= cash.type;
                    cash.amount -= 1;
                    i++;
                }
                changeCashList.Add(new Cash(cash.type, i));
                if (cash.type >= 20)
                {
                    Console.WriteLine("use bank" + cash.type + " baht: " + i + " left " + cash.amount + " bank");
                }
                else
                {
                    Console.WriteLine("use coin" + cash.type + " baht: " + i + " left " + cash.amount + " coin");
                }
            }
            if (change > 0)
            {
                Console.Clear();
                Console.WriteLine("change = {0}", change);
                Console.WriteLine("===============================================================\n");
                Console.WriteLine("money is enough but can't change at all!!\n");

                int i = 0;
                foreach (var item in changeCashList)
                {
                    if (cashList[i].type == item.type)
                    {
                        cashList[i].amount += item.amount;
                        item.amount = 0;
                    }
                    i++;
                }
                showCashList();
            }
            PressAnyKey();
        }

        void showCashList()
        {
            foreach (var cash in cashList)
            {
                if (cash.type >= 20)
                {
                    Console.WriteLine("bank {0} baht left: {1} bank", cash.type, cash.amount);
                }
                else
                {
                    Console.WriteLine("coin {0} baht left: {1} coin", cash.type, cash.amount);
                }
            }
        }

        int TotalMoney()
        {
            int total = 0;
            foreach (var cash in cashList)
            {
                total += cash.total();
            }
            return total;
        }

        void PressAnyKey()
        {
            Console.Write("Press Any Key...");
            Console.ReadLine();
        }
    }
}
