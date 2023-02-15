string[] snacks = { "sushi", "pizza", "burger", "chicken nuggets" };

Random rnd = new Random();

int randomIndex = rnd.Next(0, snacks.Length);

Console.WriteLine($"Tonight we're going to eat {snacks[randomIndex]}.");