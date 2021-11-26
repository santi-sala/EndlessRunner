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

        coinCount.text = "XTBD";
        scoreCount.text = "XTBD";


        gameUI.SetActive(true);

    }

    public override void Destruct()
    {
        gameUI.SetActive(false);
    }

    public override void UpdateState()
    {
        GameManager._Instance.worldGeneration.ScanPosition();
        GameManager._Instance.scenaryGeneration.ScanPosition();
    }
}
