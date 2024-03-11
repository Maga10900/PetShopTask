using PetShopTask;

namespace PetShop_Task;

public class Bird : Animal
{

    public bool CanFly { get; set; } // ucha bilen qushdur?


    public Bird() : base()
    {
        CanFly = default;
    }
    public Bird(string name, string gender, int age, int energy, int price, int mealQuantity, bool canFly, int size)
       : base(name, gender, age, energy, price, mealQuantity,size)
    {
        CanFly = canFly;
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        if (CanFly) Console.WriteLine($"Fly: Yes");
        else Console.WriteLine($"Fly: No");
    }

    public override string ToString()
    {
        this.ShowInfo(); return "";
    }
}
