public class Ball : Item
{
    public float CatchRatio{get; private set;}

    public Ball(float catchRatio)
    {
        CatchRatio = catchRatio;
    }

    public override void Interact(Monster monster)
    {
        
        
    }
}