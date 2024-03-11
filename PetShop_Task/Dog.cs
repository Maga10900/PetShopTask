using PetShopTask;

namespace PetShop_Task;

public class Dog : Animal
{

    public int Level_of_Frendship { get; set; }

    public Dog() : base()
    {
        Level_of_Frendship = default;
    }
    public Dog(string name, string gender, int age, int energy, int price, int mealQuantity, int size, int level_of_Frendship)
        : base(name, gender, age, energy, price, mealQuantity, size)
    {
        Level_of_Frendship = level_of_Frendship;
    }



    public override void Eat()
    {
        base.Eat();
        Level_of_Frendship++;
    }

    public override void Sleep()
    {
        base.Sleep();
        Level_of_Frendship++;
    }
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Level of Friendship: {Level_of_Frendship}");
    }

    public override string ToString()
    {
        this.ShowInfo(); return "";
    }
}
