public class GameStateInt : GameState
{
    public override void Construct()
    {
        GameManager._Instance.ChangeCamera(VirtualCameras.Init);
    }

    public override void UpdateState()
    {
        if (InputManager.Instance._Tap)
        {
            motor.ChangeState(GetComponent<GameStateGame>());
        }
    }
}
