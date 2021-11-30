using TMPro;
using UnityEngine;

public class GameStateGame : GameState
{
    public GameObject gameUI;
    [SerializeField] private TextMeshProUGUI coinCount;
    [SerializeField] private TextMeshProUGUI scoreCount;

    public override void Construct()
    {
        base.Construct();
        GameManager._Instance.gameMotor.ResumePlayer();
        GameManager._Instance.ChangeCamera(VirtualCameras.Game);

        // Subscribing to change events (Action)        
        GameStats._Instance.OnCollectedCoin += OnCoinCollection;
        GameStats._Instance.OnScoreChange += OnChangingScore;

        gameUI.SetActive(true);

    }

    private void OnCoinCollection(int amountCollected)
    {
        coinCount.text = amountCollected.ToString("0000");

        //coinCount.text = GameStats._Instance.CoinsToText();
    }

    private void OnChangingScore(float score)
    {
        scoreCount.text = score.ToString("000000");

        //scoreCount.text = GameStats._Instance.ScoreToText();
        
    }

    public override void Destruct()
    {
        gameUI.SetActive(false);

        // UNsubscribing to change events (Action) 
        GameStats._Instance.OnCollectedCoin -= OnCoinCollection;
        GameStats._Instance.OnScoreChange -= OnChangingScore;
    }

    public override void UpdateState()
    {
        GameManager._Instance.worldGeneration.ScanPosition();
        GameManager._Instance.scenaryGeneration.ScanPosition();
    }
}
