using PetShopTask;

namespace PetShop_Task;

public class Fish : Animal
{

    public int Memory_size { get; set; }
    public Fish(string name, string gender, int age, int energy, int price, int mealQuantity, int size, int memory_size)
      : base(name, gender, age, energy, price, mealQuantity, size)
    {
        Memory_size = memory_size;
    }

    public Fish() : base() 
    {
        Memory_size = default;
    }


    public override void Eat()
    {
        base.Eat();
        Memory_size++;
    }

    public override void Sleep()
    {
        base.Sleep();
        Memory_size--;
    }
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Memory Size: {Memory_size}");
    }

    public override string ToString()
    {
        this.ShowInfo(); return "";
    }
}
