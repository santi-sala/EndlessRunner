using UnityEngine;

public class SlidingState : BaseState
{
    public float slideDuration = 1.0f;


    // Collider logic
    private Vector3 colliderInitialCenter;
    private float colliderInitialRadius;
    private float slideStart;

    public override void Construct()
    {
        //If (?) null stop, else (.) continue.
        tiagoMotor.animator?.SetTrigger("Slide");

        slideStart = Time.time;

        colliderInitialRadius = tiagoMotor.controller.height;
        colliderInitialCenter = tiagoMotor.controller.center;

        tiagoMotor.controller.height = colliderInitialRadius * 0.25f;
        tiagoMotor.controller.center = colliderInitialCenter * 0.25f;
    }

    public override void Destruct()
    {
        tiagoMotor.controller.height = colliderInitialRadius;
        tiagoMotor.controller.center = colliderInitialCenter;
        tiagoMotor.animator?.SetTrigger("Running");
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

        if (!tiagoMotor.isGrounded)
        {
            tiagoMotor.ChangeState(GetComponent<FallingState>());

        }

        if (InputManager.Instance._SwipeUp)
        {
            tiagoMotor.ChangeState(GetComponent<JumpingState>());
        }

        if (Time.time - slideStart > slideDuration)
        {
            tiagoMotor.ChangeState(GetComponent<RunningState>());
        }
    }

    public override Vector3 ProcessMotion()
    {
        Vector3 movement = Vector3.zero;
        movement.x = tiagoMotor.SnapToLane();
        movement.y = tiagoMotor.verticalVelocity;
        movement.z = tiagoMotor.baseRunSpeed;

        return movement;
    }
}
