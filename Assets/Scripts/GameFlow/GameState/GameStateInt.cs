using TMPro;
using UnityEngine;

public class GameStateInt : GameState
{
    public GameObject mainMenuUI;

    [SerializeField] private TextMeshProUGUI highScoreText;
    [SerializeField] private TextMeshProUGUI coinsText;

    public override void Construct()
    {
        GameManager._Instance.ChangeCamera(VirtualCameras.Init);

        highScoreText.text = "Highscore: " + "TBD";
        coinsText.text = "Coins: " + "TBD";

        mainMenuUI.SetActive(true);
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

    }

    public void OnShopClick()
    {
        //motor.ChangeState(GetComponent<GameStateShop>());
        Debug.Log("Shop State");
    }
}
