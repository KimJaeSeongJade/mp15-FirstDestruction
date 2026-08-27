namespace ConsoleApp1;

public class Potion : Item
{
    public override void Interact(Monster monster)
    {
        monster.Health += 20;
    }
}