using UnityEngine;

public abstract class BaseState : MonoBehaviour
{
    protected TiagoMotor tiagoMotor;

    //Entering state
    public virtual void Construct(){}

    //Leaving State
    public virtual void Destruct(){}

    //Be called in constatntly in the update loop for changes in thecurrent state
    public virtual void Transition(){}

    private void Awake()
    {
        tiagoMotor = GetComponent<TiagoMotor>();
    }


    public virtual Vector3 ProcessMotion()
    {
        Debug.Log("Process motion is not implemented in " + this.ToString());
        return Vector3.zero;
    }
}
