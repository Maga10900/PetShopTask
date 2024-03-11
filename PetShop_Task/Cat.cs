using PetShopTask;

namespace PetShop_Task;

public class Cat : Animal
{

    public int Smell_Count { get; set; }
    public Cat(string name, string gender, int age, int energy, int price, int mealQuantity, int smell_count, int size)
       : base(name, gender, age, energy, price, mealQuantity, size)
    {
        Smell_Count = smell_count;
    }

    public Cat() : base()
    {
        Smell_Count = 0;
    }



    public override void Eat()
    {
        base.Eat();
        Smell_Count++;
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Smell Count: {Smell_Count}");
    }
    public override string ToString()
    {
        this.ShowInfo(); return "";
    }
}
