using UnityEngine;

public abstract class GameState : MonoBehaviour
{
    protected GameManager motor;

    private void Awake()
    {
        motor = GetComponent<GameManager>();
    }

    public virtual void Construct()
    {

    }
    public virtual void Destruct()
    {

    }
    public virtual void UpdateState()
    {

    }
}
