public class Program
{
    public static void Main()
    {
        int age = 25;
        string name = "Rashid";
        double temperature = 98.6;
        bool isAdult = false;

        int birthYear = DateTime.Now.Year - age;
        string message = $"Привет, меня зовут {name}, мне {age} лет" +
                         $" и моя температура тела составляет {temperature}" +
                         $" градусов по Фаренгейту.";
        Console.WriteLine(message);
        IsAnAdult(age, isAdult);
        IsHeat(temperature);

        age += 5;
        temperature += 2.5;
    }

    private static void IsHeat(double temperature)
    {
        if (temperature > 98.6)
        {
            Console.WriteLine("У вас повышенная температура");
        }
        else
        {
            Console.WriteLine("Ваша температура в норме");
        }
    }

    private static void IsAnAdult(int age, bool isAdult)
    {
        if (age >= 18)
        {
            Console.WriteLine("Вы совершеннолетний");
            isAdult = true;
        }
        else
        {
            Console.WriteLine("Вы не совершеннолетний");
            isAdult = false;
        }
    }
}