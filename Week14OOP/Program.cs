
// 2 erinevat koera:

Console.WriteLine("Name your dog:");
string myDogName = Console.ReadLine();
Dog myDog = new Dog(myDogName);

//Dog myDog = new Dog("Good boy");
//myDog._name = "Good boy";


Dog neighboursDog = new Dog("Good Girl");
//neighboursDog._name = "Good Girl";
//neighboursDog.Name = "Some other dog";

//Console.WriteLine($"my dog name is {myDog._name}.");
//Console.WriteLine($"my neighbours dog name is {neighboursDog._name}.");

Console.WriteLine($"my dog name is {myDog.Name}.");
Console.WriteLine($"my neighbours dog name is {neighboursDog.Name}.");

myDog.Rename("Bad Boy");
//Console.WriteLine($"Level of happiness: {myDog.LevelOfHapiness}");

//myDog.Bark();
//Console.WriteLine($"Level of happiness: {myDog.LevelOfHapiness}");

while (myDog.LevelOfHapiness != 5)
{
    myDog.Bark();
}

myDog.WagTail();


class Dog
{
    //public string _name = "Koer";
    //public int _levelOfHapiness = 0;
    private string _name; // = "Koer"; //field
    private int _levelOfHapiness;

    //constructor
    public Dog (string name) //name - let the user name the dog
    {
        _name = name;
        _levelOfHapiness = 0;
    }

    //getter 1
    public string Name
    {
        get { return _name; }   
    }
    //getter 2
    public int LevelOfHapiness
    {
        get { return _levelOfHapiness; }
    }

    public void Rename(string newName)
    {
        _name = newName;
        Console.WriteLine($"The dog has been renamed to: {newName}");
    }

    public void Bark()
    {
        Console.WriteLine("Woof-woof!");
        _levelOfHapiness++;
    }

    public void WagTail()
    {
        Console.WriteLine("Wiggle-wiggle!");
    }

}