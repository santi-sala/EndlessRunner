public class GameStateDeath : GameState
{
    public override void Construct()
    {
        GameManager._Instance.gameMotor.PausePlayer();    
    }

    public override void UpdateState()
    {
        if (InputManager.Instance._SwipeDown)
        {
            ToMenu();
        }
        if (InputManager.Instance._SwipeUp)
        {
            ResumeGame();
        }
    }

    private void ResumeGame()
    {
        motor.ChangeState(GetComponent<GameStateGame>());
        GameManager._Instance.gameMotor.RespawnTiago();
    }

    public void ToMenu()
    {
        motor.ChangeState(GetComponent<GameStateInt>());
        GameManager._Instance.gameMotor.ResetPlayer();
        GameManager._Instance.worldGeneration.ResetWorld();
        
    }
}
