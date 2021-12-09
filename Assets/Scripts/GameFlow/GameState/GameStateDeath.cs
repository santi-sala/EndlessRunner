using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;


public class GameStateDeath : GameState, IUnityAdsListener
{
    public GameObject deathUI;
    [SerializeField] private TextMeshProUGUI highScore;
    [SerializeField] private TextMeshProUGUI currentScore;
    [SerializeField] private TextMeshProUGUI totalCoins;
    [SerializeField] private TextMeshProUGUI currentCoins;

    [SerializeField] private Image completeCircle;
    public float decisionTime = 3;
    private float deahtTime;

    private void Start()
    {
        Advertisement.AddListener(this);
    }

    public override void Construct()
    {
        base.Construct();
        GameManager._Instance.gameMotor.PausePlayer();

        deahtTime = Time.time;
        deathUI.SetActive(true);
        

        // Set highscore if needed
        if (SaveManager._Instance.save.Highscore < (int)GameStats._Instance.score)
        {
            SaveManager._Instance.save.Highscore = (int)GameStats._Instance.score;
            highScore.color = Color.yellow;
            currentScore.color = Color.yellow;
            highScore.text = "NEW HIGHSCORE!! " + SaveManager._Instance.save.Highscore;
        }
        else
        {
            highScore.color = Color.white;
            currentScore.color = Color.white;
            highScore.text = "Highscore: " + SaveManager._Instance.save.Highscore;
        }

        SaveManager._Instance.save.Coins += GameStats._Instance.currentCollectedCoins;
        SaveManager._Instance.Save();

        currentScore.text = GameStats._Instance.score.ToString("00000");
        totalCoins.text = "Total coins: " + SaveManager._Instance.save.Coins;
        currentCoins.text = GameStats._Instance.currentCollectedCoins.ToString();
            
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

    public void ShowAd()
    {
        AdManager._Instance.ShowRewardedAd();
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
        GameManager._Instance.scenaryGeneration.ResetWorld();        
    }

    public void Revive()
    {
        completeCircle.gameObject.SetActive(true);
    }

    public void OnUnityAdsReady(string placementId)
    {
       
    }

    public void OnUnityAdsDidError(string message)
    {
        Debug.Log(message);
    }

    public void OnUnityAdsDidStart(string placementId)
    {
        
    }

    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        completeCircle.gameObject.SetActive(false);
        switch (showResult)
        {
            case ShowResult.Failed:
                ToMenu();
                break;
            case ShowResult.Finished:
                ResumeGame();
                break;
            default:
                break;
        }
    }
}
