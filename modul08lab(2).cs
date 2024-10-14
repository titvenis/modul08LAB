public abstract class Beverage
{
    void PrepareRecipe()
    {
        BoilWtaer();
        Brew();
        PourInCup();
        AddCondiments();
    }
    private void BoilWtaer()
    {
        Console.WriteLine("boilin water")
    }
    private void PourInCup()
    {
        Console.WriteLine("pouring into a cup")
     }

    protected abstract void Brew();
    protected abstract void AddCondiments();
}

public class Tea : Beverage
{
    protected override void Brew()
    {
        Console.WriteLine("Brewing tea")
    }

    protected override void AddCondiments()
    {
        Console.WriteLine("Adding lemon")
    }
}

public class Coffee : Beverage
{
    protected override void Brew()
    {
        Console.WriteLine("Breffing coffee")
    }
    protected override void AddCondiments()
    {
        Console.WriteLine("Adding milk")
    }
}
class Program 

{ 

    static void Main(string[] args) 

    { 
         Beverage tea = new Tea(); 
         Console.WriteLine("Приготовление чая:"); 
         tea.PrepareRecipe(); 
         
         Beverage coffee = new Coffee(); 
         Console.WriteLine("Приготовление кофе:"); 
         coffee.PrepareRecipe(); 

    } 

} 