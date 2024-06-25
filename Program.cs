// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("請輸入您的體重(kg):");
        double weight = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("請輸入您的身高(m):");
        double height = Convert.ToDouble(Console.ReadLine());

        double bmi = CalculateBMI(weight, height);
        Console.WriteLine($"您的BMI是: {bmi}");
    }

    static double CalculateBMI(double weight, double height)
    {
        return weight / (height * height);
    }
}
