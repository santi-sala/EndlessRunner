public class GameStateInt : GameState
{
    public override void Construct()
    {
        
    }

    public override void UpdateState()
    {
        if (InputManager.Instance._Tap)
        {
            motor.ChangeState(GetComponent<GameStateGame>());
        }
    }
}
