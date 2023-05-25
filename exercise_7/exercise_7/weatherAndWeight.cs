public class Weather_2
{
    public enum Months
    {
        Січень = 1,
        Лютий,
        Березень,
        Квітень,
        Травень,
        Червень,
        Липень,
        Серпень,
        Вересень,
        Жовтень,
        Листопад,
        Грудень
    }

    public enum Weather
    {
        Тепло,
        Дощі,
        Холодно,
        Інше
    }

    public enum WeightUnit
    {
        Кілограми,
        Грами,
        Центнери
    }

    public static void Main(string[] args)
    {
        //ЗАВДАННЯ 2
        Console.WriteLine("ЗАВДАННЯ 2");
        Console.WriteLine("Напиши номер мiсяця(вiд 1 до 12): ");
        Int16 monthNumber = Int16.Parse(Console.ReadLine());

        if (monthNumber < 1 || monthNumber > 12)
        {
            Console.WriteLine("Некоректний номер");
            return;
        }

        Months month = (Months)monthNumber;

        Weather weather = Weather.Інше;

        switch (month)
        { 
            case Months.Січень:
                weather = Weather.Холодно;
                break;
            case Months.Лютий:
                weather = Weather.Холодно;
                break;
            case Months.Березень:
                weather = Weather.Дощі;
                break;
            case Months.Квітень:
                weather = Weather.Дощі;
                break;
            case Months.Травень:
                weather = Weather.Дощі;
                break;
            case Months.Червень:
                weather = Weather.Тепло;
                break;
            case Months.Липень:
                weather = Weather.Тепло;
                break;
            case Months.Серпень:
                weather = Weather.Тепло;
                break;
            case Months.Вересень:
                weather = Weather.Холодно;
                break;
            case Months.Жовтень:
                weather = Weather.Холодно;
                break;
            case Months.Листопад:
                weather = Weather.Холодно;
                break;
            case Months.Грудень:
                weather = Weather.Холодно;
                break;
        }

        Console.WriteLine("Погода в місяці " + month + ": " + weather);


        //ЗАВДАННЯ 5
        Console.WriteLine("ЗАВДАННЯ 5");
        Console.WriteLine("Введіть вагу у кілограмах:");
        double weightKg = double.Parse(Console.ReadLine());

        Console.WriteLine("Оберіть одиницю довжини для перетворення:");
        Console.WriteLine("1. Грами");
        Console.WriteLine("2. Центнери");
        int option = int.Parse(Console.ReadLine());

        WeightUnit unit;

        switch (option)
        {
            case 1:
                unit = WeightUnit.Грами;
                double weightGrams = weightKg * 1000;
                Console.WriteLine($"Вага у грамах: {weightGrams} г");
                break;
            case 2:
                unit = WeightUnit.Центнери;
                double weightCentners = weightKg / 100;
                Console.WriteLine($"Вага у центнерах: {weightCentners} ц");
                break;
            default:
                Console.WriteLine("Невірна опція!");
                return;
        }
    }
}
