using System;

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
        GameManager._Instance.gameMotor.RespawnTiago();
        motor.ChangeState(GetComponent<GameStateGame>());
    }

    public void ToMenu()
    {
        motor.ChangeState(GetComponent<GameStateInt>());
    }
}
