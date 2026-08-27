public class Potion : Item
{
    public int HealValue { get;private set; }

    public Potion(int healValue)
    {
        HealValue = healValue;
    }
    
    public override void Interact(Monster monster)
    {
        monster.Health += HealValue;
    }
}