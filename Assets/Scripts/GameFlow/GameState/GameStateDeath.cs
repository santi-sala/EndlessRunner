using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameStateDeath : GameState
{
    public GameObject deathUI;
    [SerializeField] private TextMeshProUGUI highScore;
    [SerializeField] private TextMeshProUGUI currentScore;
    [SerializeField] private TextMeshProUGUI totalCoins;
    [SerializeField] private TextMeshProUGUI currentCoins;

    [SerializeField] private Image completeCircle;
    public float decisionTime = 3;
    private float deahtTime;

    public override void Construct()
    {
        base.Construct();
        GameManager._Instance.gameMotor.PausePlayer();
        completeCircle.gameObject.SetActive(true);

        deahtTime = Time.time;
        deathUI.SetActive(true);

        highScore.text = "Highscore: " + "TBD";
        currentScore.text = "684565324";
        totalCoins.text = "Total coins: " + "TBD";
        totalCoins.text = "654";
            
    }

    public override void Destruct()
    {
        deathUI.SetActive(false);
    }

    public override void UpdateState()
    {
        //if (InputManager.Instance._SwipeDown)
        //{
        //    ToMenu();
        //}
        //if (InputManager.Instance._SwipeUp)
        //{
        //    ResumeGame();
        //}

        float ratio = (Time.time - deahtTime) / decisionTime;
        completeCircle.color = Color.Lerp(Color.green, Color.blue, ratio);
        completeCircle.fillAmount = 1 - ratio;

        if (ratio > 1)
        {
            completeCircle.gameObject.SetActive(false);
        }
    }

    public void ResumeGame()
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
