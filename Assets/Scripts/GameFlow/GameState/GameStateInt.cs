using TMPro;
using UnityEngine;

public class GameStateInt : GameState
{
    public GameObject mainMenuUI;

    [SerializeField] private TextMeshProUGUI highScoreText;
    [SerializeField] private TextMeshProUGUI coinsText;
    [SerializeField] private AudioClip menuLoopMusic;

    public override void Construct()
    {
        GameManager._Instance.ChangeCamera(VirtualCameras.Init);

        highScoreText.text = "Highscore: " + SaveManager._Instance.save.Highscore.ToString();
        coinsText.text = "Coins: " + SaveManager._Instance.save.Coins.ToString(); ;

        mainMenuUI.SetActive(true);

        AudioManager._Instance.PlayMusicWithFade(menuLoopMusic, 0.5f);
    }

    public override void Destruct()
    {
        mainMenuUI.SetActive(false);
    }

    public void OnPlayClick()
    {
        //Debug.Log("Play button pressed!!!");
        motor.ChangeState(GetComponent<GameStateGame>());
        GameStats._Instance.ResetSession();
        GetComponent<GameStateDeath>().Revive();

    }

    public void OnShopClick()
    {
        //motor.ChangeState(GetComponent<GameStateShop>());
        Debug.Log("Shop State");
    }
}
