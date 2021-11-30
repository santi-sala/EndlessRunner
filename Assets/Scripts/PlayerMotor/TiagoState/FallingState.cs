using UnityEngine;

public class FallingState : BaseState
{
    public override void Construct()
    {
        tiagoMotor.animator?.SetTrigger("Fall");
    }

    public override Vector3 ProcessMotion()
    {
        // Apply gravity
        tiagoMotor.ApplyGravity();


        // Return vector
        Vector3 movement = Vector3.zero;
        movement.x = tiagoMotor.SnapToLane();
        movement.y = tiagoMotor.verticalVelocity;
        movement.z = tiagoMotor.baseRunSpeed;

        return movement;
    }

    public override void Transition()
    {
        if (tiagoMotor.isGrounded)
        {
            tiagoMotor.ChangeState(GetComponent<RunningState>());
        }


    }
}
