using UnityEngine;

public class TiagoMotor : MonoBehaviour
{
    [HideInInspector] public Vector3 moveVector;
    [HideInInspector] public float verticalVelocity;
    [HideInInspector] public bool isGrounded;
    [HideInInspector] public int currentLane;

    public float distanceInbetweenLanes = 3.0f;
    public float baseRunSpeed = 5.0f;
    public float switchLaneSpeed = 10.0f;
    public float gravity = 14.0f;
    public float terminalVelocity = 20.0f;

    public CharacterController controller;

    //State
    private BaseState state;

    private void Start()
    {
        controller = GetComponent<CharacterController>();

        //State
        state = GetComponent<RunningState>();
        state.Construct();
    }

    private void Update()
    {
        UpdateMotor();
    }

    private void UpdateMotor()
    {
        // Check if grounded (Cahing it)
        isGrounded = controller.isGrounded;

        //State (Movement based on states)
        moveVector = state.ProcessMotion();

        //State (Changing state?)
        state.Transition();

        // Moving Tiago
        controller.Move(moveVector * Time.deltaTime);
    }

    public float SnapToLane()
    {
        float ret = 0.0f;

        if (transform.position.x != (currentLane * distanceInbetweenLanes))
        {
            float desiredPosition = (currentLane * distanceInbetweenLanes) - transform.position.x;
            ret = (desiredPosition > 0) ? 1 : -1;
            ret *= switchLaneSpeed;

            //Tos stop it from jittering to be in place
            float actualDistance = ret * Time.deltaTime;
            if (Mathf.Abs(actualDistance) > Mathf.Abs(desiredPosition))
            {
                ret = desiredPosition * (1 / Time.deltaTime);
            }
        }
        else
        {
            ret = 0;
        }

        return ret;
    }

    public void ChangeLane(int direction)
    {
        currentLane = Mathf.Clamp(currentLane + direction, -1, 1);
    }

    public void ChangeState(BaseState newState)
    {
        state.Destruct();
        state = newState;
        state.Construct();
    }

}

