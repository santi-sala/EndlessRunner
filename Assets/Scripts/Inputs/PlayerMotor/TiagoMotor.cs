using System;
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
    public Animator animator;

    // State --> Player
    private BaseState state;

    // State --> Game
    private bool isPaused;

    

    // Start
    private void Start()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();

        // State --> Player
        state = GetComponent<RunningState>();
        state.Construct();

        // State --> Game
        isPaused = true;
    }

    private void Update()
    {
        if (!isPaused)
        {
            UpdateMotor();
        }
    }

    private void UpdateMotor()
    {
        // Check if grounded (Cahing it)
        isGrounded = controller.isGrounded;

        //State --> Player (Movement based on states)
        moveVector = state.ProcessMotion();

        //State --> Player (Changing state?)
        state.Transition();

        //
        animator?.SetBool("IsGrounded", isGrounded);
        animator?.SetFloat("Speed", Mathf.Abs(moveVector.z));

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

    public void ApplyGravity()
    {
        verticalVelocity -= gravity * Time.deltaTime;

        if (verticalVelocity < -terminalVelocity)
        {
            verticalVelocity = -terminalVelocity;
        }
    }


    // State --> Game
    public void PausePlayer()
    {
        isPaused = true;
    }

    public void ResumePlayer()
    {
        isPaused = false;
    }

    public void ResetPlayer()
    {
        currentLane = 0;
        //Debug.Log("Before reseting player: " + transform.position);
        //Debug.Log("This is: " + this);

        //You cannot move a object with character controller using transform.position, so firts disable it, move it , enable it back XD        
        controller.enabled = false;
        transform.position = Vector3.zero;
        controller.enabled = true;

        animator?.SetTrigger("Idle");
        ChangeState(GetComponent<RunningState>());
        PausePlayer();
        //Debug.Log("After reseting player: " + transform.position);
    }

    public void RespawnTiago()
    {
        ChangeState(GetComponent<RespawnState>());
        GameManager._Instance.ChangeCamera(VirtualCameras.Respawn);
    }


    // Detecting Collisions
    public void OnControllerColliderHit(ControllerColliderHit hit)
    {
        string hitLayerName = LayerMask.LayerToName(hit.gameObject.layer);

        if (hitLayerName == "Death")
        {
            ChangeState(GetComponent<DeathState>());
        }
    }

}

