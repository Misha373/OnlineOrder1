Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("ДЗ: Онлайн замовлення");
Console.WriteLine($"Перелік товарів магазину:\n 1)Iphone 10 - 400$\n 2)Iphone11 - 500$\n 3)Iphone12 - 650$\n 4)Iphone13 - 800$\n 5)Iphone14 - 950$\n 6)Iphone15 - 1100$");

Console.WriteLine($"Замовлення No 1");
Console.Write("Введіть ім'я першого покупця:");
string byer1 = Console.ReadLine();
Console.Write("Введіть адресу першого покупця:");
string address1 = Console.ReadLine();
Console.Write($"Введіть товар який хоче замовити {byer1}:");
string product1 = Console.ReadLine();
Console.Write($"Введіть ціну продукту {product1}:");
int price1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Замовлення No 2");
Console.Write("Введіть ім'я першого покупця:");
string byer2 = Console.ReadLine();
Console.Write("Введіть адресу першого покупця:");
string address2 = Console.ReadLine();
Console.Write($"Введіть товар який хоче замовити {byer2}:");
string product2 = Console.ReadLine();
Console.Write($"Введіть ціну продукту {product2}:");
int price2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Замовлення No 3");
Console.Write("Введіть ім'я першого покупця:");
string byer3 = Console.ReadLine();
Console.Write("Введіть адресу першого покупця:");
string address3 = Console.ReadLine();
Console.Write($"Введіть товар який хоче замовити {byer3}:");
string product3 = Console.ReadLine();
Console.Write($"Введіть ціну продукту {product3}:");
int price3 = Convert.ToInt32(Console.ReadLine());

Console.Clear();

Console.WriteLine($"Order No 1");
Console.WriteLine($"Client: {byer1}.");
Console.WriteLine($"Product: {product1}, price {price1}$.");
Console.WriteLine($"Address: {address1}.");
Console.WriteLine();
Console.WriteLine($"Order No 21");
Console.WriteLine($"Client: {byer2}.");
Console.WriteLine($"Product: {product2}, price {price2}$.");
Console.WriteLine($"Address: {address2}.");
Console.WriteLine();
Console.WriteLine($"Order No 3");
Console.WriteLine($"Client: {byer3}.");
Console.WriteLine($"Product: {product3}, price {price3}$.");
Console.WriteLine($"Address: {address3}.");
Console.WriteLine();
