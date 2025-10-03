namespace App;


//vi bygger en konstrukt;namespace App;
public class Trade
    {
        private List<Item> _items;

        public Trade(List<Item> items)
        {
            _items = items;
        }

        // Visa alla items med index
        public void ShowMarket()
        {
            if (_items.Count == 0)
            {
                Console.WriteLine("Marknaden är tom.");
                return;
            }

            for (int i = 0; i < _items.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_items[i]}");
            }
        }

        // Låta en användare köpa ett item
        public void BuyItem(User buyer)
        {
            if (_items.Count == 0)
            {
                Console.WriteLine("Inga items finns på marknaden.");
                return;
            }

            ShowMarket();
            Console.Write("Välj nummer på item att köpa (eller Enter för att avbryta): ");
            string input = Console.ReadLine() ?? "";

            if (int.TryParse(input, out int index))
            {
                if (index >= 1 && index <= _items.Count)
                {
                    Item selected = _items[index - 1];
                    if (selected.Owner == buyer)
                    {
                        Console.WriteLine("Du kan inte köpa ditt eget item!");
                    }
                    else
                    {
                        selected.Owner = buyer;
                        Console.WriteLine($"Du har köpt '{selected.Name}'. Ägare är nu {buyer.UserName}.");
                    }
                }
                else
                {
                    Console.WriteLine("Felaktigt val.");
                }
            }
            else if (!string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Felaktig inmatning.");
            }
        }
    }