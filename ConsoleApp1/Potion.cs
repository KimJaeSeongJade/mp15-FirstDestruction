public class Potion : Item
{
    public float HealValue { get;private set; }

    public Potion(int healValue)
    {
        HealValue = healValue;
    }
    
    public override void Interact(Monster monster)
    {
        monster.Health += (int)(monster.Health * HealValue);
    }
}