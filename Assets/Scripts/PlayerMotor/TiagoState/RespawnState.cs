using UnityEngine;

public class RespawnState : BaseState
{
    [SerializeField] private float verticalDistance = 25.0f;
    private float immunityTime = 1f;

    private float startTime;


    public override void Construct()
    {
        startTime = Time.time;


        tiagoMotor.controller.enabled = false;
        tiagoMotor.transform.position = new Vector3(0, verticalDistance, tiagoMotor.transform.position.z);
        tiagoMotor.controller.enabled = true;

        tiagoMotor.verticalVelocity = 0.0f;
        tiagoMotor.currentLane = 0;
        tiagoMotor.animator?.SetTrigger("Respawn");

        
    }

    public override void Destruct()
    {
        GameManager._Instance.ChangeCamera(VirtualCameras.Game);
    }

    public override Vector3 ProcessMotion()
    {
        
        tiagoMotor.ApplyGravity();

        Vector3 movement = Vector3.zero;
        movement.x = tiagoMotor.SnapToLane();
        movement.y = tiagoMotor.verticalVelocity;
        movement.z = tiagoMotor.baseRunSpeed;

        return movement;
    }

    public override void Transition()
    {
        if (tiagoMotor.isGrounded && (Time.time - startTime) > immunityTime)
        {
            tiagoMotor.ChangeState(GetComponent<RunningState>());
        }

        if (InputManager.Instance._SwipeLeft)
        {
            tiagoMotor.ChangeLane(-1);
        }

        if (InputManager.Instance._SwipeRight)
        {
            tiagoMotor.ChangeLane(1);
        }
    }
}
