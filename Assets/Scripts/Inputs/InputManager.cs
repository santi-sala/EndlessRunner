using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    // Making sure theres only one input manager in the scene --> Better way to do this check for MonoSingleton.cs
    private static InputManager instance;
    public static InputManager Instance { get { return instance; } }


    // Action Schemes
    private TiagoInputAction actionScheme;

    [SerializeField] private float sqrSwipeDeadzone = 50.0f; 


    // Public properties
    public Vector2 _TouchPosition { get { return touchPosition; } }
    public bool _Tap { get { return tap; } }
    public bool _SwipeLeft { get { return swipeLeft; } }
    public bool _SwipeRight { get { return swipeRight; } }
    public bool _SwipeUp { get { return swipeUp; } }
    public bool _SwipeDown { get { return swipeDown; } }

    // Private properties
    private Vector2 touchPosition;
    private Vector2 startDrag;
    private bool tap;
    private bool swipeLeft;
    private bool swipeRight;
    private bool swipeUp;
    private bool swipeDown;

    private void Awake()
    {
        instance = this;
        DontDestroyOnLoad(gameObject);
        SetupControl();
    }

    private void LateUpdate()
    {
        ResetInputs();
    }

    private void ResetInputs()
    {
        tap = false;
        swipeLeft = false;
        swipeRight = false;
        swipeUp = false;
        swipeDown = false;
        // --> tap = swipeLeft = swipeRight = swipeUp = swipeDown = false;
    }

    private void SetupControl()
    {
        actionScheme = new TiagoInputAction();

        // Registering inputs
        actionScheme.Gameplay.Touch.performed += context => OnTap(context);
        actionScheme.Gameplay.TouchPosition.performed += context => OnTapPosition(context);
        actionScheme.Gameplay.StartDrag.performed += context => OnStartDrag(context);
        actionScheme.Gameplay.EndDrag.performed += context => OnEndDrag(context);
    }

    private void OnEndDrag(InputAction.CallbackContext context)
    {
        Vector2 drag = touchPosition - startDrag;
        float sqrDistance = drag.sqrMagnitude;

        if (sqrDistance > sqrSwipeDeadzone)
        {
            float x = Mathf.Abs(drag.x);
            float y = Mathf.Abs(drag.y);

            if (x > y)
            {
                if (drag.x > 0)
                {
                    swipeRight = true;
                    Debug.Log("swipeRight");
                }
                else
                {
                    swipeLeft = true;
                    Debug.Log("swipeLeft");
                }
            }
            else
            {
                if (drag.y > 0)
                {
                    swipeUp = true;
                    Debug.Log("swipeUp");
                }
                else
                {
                    swipeDown = true;
                    Debug.Log("swipeDown");
                }
            }
        }

        startDrag = Vector2.zero;
    }

    private void OnStartDrag(InputAction.CallbackContext context)
    {
        startDrag = touchPosition;
    }

    private void OnTapPosition(InputAction.CallbackContext context)
    {
        touchPosition = context.ReadValue<Vector2>();
    }

    private void OnTap(InputAction.CallbackContext context)
    {
        tap = true;
    }

    public void OnEnable()
    {
        actionScheme.Enable();
    }

    public void OnDisable()
    {
        actionScheme.Disable();
    }
}
