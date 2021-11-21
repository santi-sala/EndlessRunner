using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager _Instance { get { return instance; } }
    private static GameManager instance;

    public TiagoMotor gameMotor;



    private GameState state;


    private void Awake()
    {
        instance = this;
        state = GetComponent<GameStateInt>();
        state.Construct();
    }

    private void Update()
    {
        state.UpdateState();
    }

    public void ChangeState(GameState newState)
    {
        state.Destruct();
        state = newState;
        state.Construct();
    }
}
