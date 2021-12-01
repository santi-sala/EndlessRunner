using UnityEngine;
using UnityEngine.Advertisements;

public class AdManager : MonoBehaviour
{
    public static AdManager _Instance { get { return instance; } }
    private static AdManager instance;

    [SerializeField] private string gameID;
    [SerializeField] private string rewardedVideoPlacementID;
    [SerializeField] private bool testMode;

    private void Awake()
    {
        instance = this;
        Advertisement.Initialize(gameID, testMode);
    }

    public void ShowRewardedAd()
    {
        ShowOptions showOptions = new ShowOptions();
    }
}
