using PetShop_Task;

internal class PetShop
{
    public List<Cat> cats { get; set; }
    public List<Dog> dogs { get; set; }
    public List<Bird> birds { get; set; }
    public List<Fish> Fishes { get; set; }

    public void RemoveByNicknameCat(string Nickname)
    {
        bool ischeck = true;
        foreach (var item in cats)
        {
            if (item.Name == Nickname)
            {
                cats.Remove(item);
                ischeck = false;
            }
        }
        if (ischeck)
            throw new Exception("Nickname is not found");
    }
    public void RemoveByNicknameDog(string Nickname)
    {
        bool ischeck = true;
        foreach (var item in dogs)
        {
            if (item.Name == Nickname)
            {
                dogs.Remove(item);
                ischeck = false;
            }
        }
        if (ischeck)
            throw new Exception("Nickname is not found");
    }
    public void RemoveByNicknameBird(string Nickname)
    {
        bool ischeck = true;
        foreach (var item in birds)
        {
            if (item.Name == Nickname)
            {
                birds.Remove(item);
                ischeck = false;
            }
        }
        if (ischeck)
            throw new Exception("Nickname is not found");
    }
    public void RemoveByNicknameFish(string Nickname)
    {
        bool ischeck = true;
        foreach (var item in Fishes)
        {
            if (item.Name == Nickname)
            {
                Fishes.Remove(item);
                ischeck = false;
            }
        }
        if (ischeck)
            throw new Exception("Nickname is not found");
    }

    public void AddByNicknameCat(string nickname)
    {
        bool ischeck = true;
        foreach (var item in cats)
        {
            if (item.Name == nickname)
            {
                cats.Add(item);
                ischeck = false;
            }
        }
        if (ischeck)
            throw new Exception("Nickname is not found");
    }
    public void AddByNicknameDog(string nickname)
    {
        bool ischeck = true;
        foreach (var item in dogs)
        {
            if (item.Name == nickname)
            {
                dogs.Add(item);
                ischeck = false;
            }
        }
        if (ischeck)
            throw new Exception("Nickname is not found");
    }
    public void AddByNicknameBirds(string nickname)
    {
        bool ischeck = true;
        foreach (var item in birds)
        {
            if (item.Name == nickname)
            {
                birds.Add(item);
                ischeck = false;
            }
        }
        if (ischeck)
            throw new Exception("Nickname is not found");
    }
    public void AddByNicknameFishes(string nickname)
    {
        bool ischeck = true;
        foreach (var item in Fishes)
        {
            if (item.Name== nickname)
            {
                Fishes.Add(item);
                ischeck = false;
            }
        }
        if (ischeck)
            throw new Exception("Nickname is not found");
    }


    public  void ShowInfo()
    {
        Console.WriteLine("Cats");
        foreach (var i in cats)
            i.ShowInfo();
        Console.WriteLine("Dogs");
        foreach (var i in dogs)
            i.ShowInfo();
        Console.WriteLine("Birds");
        foreach (var i in birds)
            i.ShowInfo();
        Console.WriteLine("Fihes");
        foreach (var i in Fishes)
            i.ShowInfo();
    }
}