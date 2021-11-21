public class GameStateGame : GameState
{
    public override void Construct()
    {
        GameManager._Instance.gameMotor.ResumePlayer();
    }
}
