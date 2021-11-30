using UnityEngine;

public class JumpingState : BaseState
{
    public float jumpForce = 7.0f;


    public override void Construct()
    {
        tiagoMotor.verticalVelocity = jumpForce;
        tiagoMotor.animator?.SetTrigger("Jump");
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
        if (tiagoMotor.verticalVelocity < 0)
        {
            tiagoMotor.ChangeState(GetComponent<FallingState>());
        }
    }
}
