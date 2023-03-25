class Program
{
    public delegate double MathDelegate(double value1, double value2);

    public static double Add(double value1, double value2)
    {
        return value1 + value2;
    }
    public static double Subtract(double value1, double value2)
    {
        return value1 - value2;
    }

    static void Main(string[] args)
    {
        // пример с математикой 
        MathDelegate mathDelegate = Add;
        var result = mathDelegate(5, 2);
        Console.WriteLine(result);
        // вывод: 7

        mathDelegate = Subtract;
        result = mathDelegate(5, 2);
        Console.WriteLine(result);
        // вывод: 3


        // пример с библиотекой
        StockExchangeMonitor.Monitor monitor = new();
        monitor.PriceChangeHandler = ShowPrice;
        monitor.Start();
    }

    // реализация (обращения) получения данных из класса 
    private static void ShowPrice(int price)
    {
        Console.WriteLine($"New price is: {price}");
    }
}