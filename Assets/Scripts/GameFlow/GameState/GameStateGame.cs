public class GameStateGame : GameState
{
    public override void Construct()
    {
        GameManager._Instance.gameMotor.ResumePlayer();
        GameManager._Instance.ChangeCamera(VirtualCameras.Game);
    }

    public override void UpdateState()
    {
        GameManager._Instance.worldGeneration.ScanPosition();
        GameManager._Instance.scenaryGeneration.ScanPosition();
    }
}
