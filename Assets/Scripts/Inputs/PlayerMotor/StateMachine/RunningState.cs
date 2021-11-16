using UnityEngine;

public class RunningState : BaseState
{
    public override Vector3 ProcessMotion()
    {
        Vector3 movement = Vector3.zero;

        //Lane transtion
        movement.x = tiagoMotor.SnapToLane();

        //Atleast a small force to keep us on the floor!!
        movement.y = -1.0f;

        //Speed running
        movement.z = tiagoMotor.baseRunSpeed;

        return movement;
    }

    public override void Transition()
    {
        if (InputManager.Instance._SwipeLeft)
        {
            tiagoMotor.ChangeLane(-1);
        }

        if (InputManager.Instance._SwipeRight)
        {
            tiagoMotor.ChangeLane(1);
        }

        if (InputManager.Instance._SwipeUp && tiagoMotor.isGrounded)
        {
            //tiagoMotor.ChangeState(GetComponent<JumpingState>());
        }
    }
}
