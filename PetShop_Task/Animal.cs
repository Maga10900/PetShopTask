using System.Text;

namespace PetShopTask;

public abstract class Animal
{
    public string? Name { get; set; }

    public int Size { get; set; }
    public int Age { get; set; }
    public string? Gender { get; set; }
    public int Energy { get; set; }
    public int Price { get; set; }
    public int MealQuantity { get; set; }

    public Animal()
    {
        Name = NameGenerator();
        Gender = GenderGenerator();
        Age = 0;
        Energy = 0;
        Price = 0;
        MealQuantity = 0;
        Size = 0;

    }
    public Animal(string name, string gender, int age)
    {
        Name = name; Gender = gender; Age = age;
        Energy = 0; Price = 0; MealQuantity = 0;
    }
    public Animal(string name, string gender, int age, int energy, int price, int mealQuantity, int size)
        : this(name, gender, age)
    {
        Energy = energy; Price = price; MealQuantity = mealQuantity;
        Size = size;
    }


    public virtual string GenderGenerator()
    {
        Random random = new Random();

        if (random.Next(0, 2) == 0)
        {
            return "Male";
        }
        else
        {
            return "Female";
        }
    }

    public virtual string NameGenerator()
    {
        int length = 7;

        // creating a StringBuilder object()
        StringBuilder str_build = new StringBuilder();
        Random random = new Random();

        char letter;

        for (int i = 0; i < length; i++)
        {
            double flt = random.NextDouble();
            int shift = Convert.ToInt32(Math.Floor(25 * flt));
            letter = Convert.ToChar(shift + 65);
            str_build.Append(letter);
        }
        //System.Console.WriteLine(str_build.ToString());
        return str_build.ToString();
    }
    public virtual void ShowInfo()
    {
        Console.WriteLine($"Name: {Name}\nGender: {Gender}\nAge: {Age}\nEnergy: {Energy}\nPrice: {Price}\nMealQuantity: {MealQuantity}\nSize: {Size}");
    }

    public virtual void CheckSize(int size)
    {
        if(size > 0)
        {
            int num = size / 10;
            this.Age += num;
        }
    }
    public virtual void Eat()
    {
        if (MealQuantity > 0)
        {
            MealQuantity--;
            Energy++;
            Price++;
            Size++;
            CheckSize(Size);
        }
    }

    public virtual void Sleep()
    {
        Energy++;
        Size++;
        CheckSize(Size);
    }

    public virtual void Play()
    {
        Energy--;

        if (Energy == 0)
        {
            Sleep();

            Console.WriteLine("\nPet Sleeping ...");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n\n\t\tPress any key to Continue ....");
            Console.ForegroundColor = ConsoleColor.White;
            _ = Console.ReadKey();
        }
    }
}
