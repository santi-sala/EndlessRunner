// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Inputs/TiagoInputAction.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @TiagoInputAction : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @TiagoInputAction()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""TiagoInputAction"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""00088d3b-184d-44f3-adec-470f85c42c6f"",
            ""actions"": [
                {
                    ""name"": ""Touch"",
                    ""type"": ""Button"",
                    ""id"": ""34bf0bc7-0311-484f-bad7-ecdc79344961"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""TouchPosition"",
                    ""type"": ""PassThrough"",
                    ""id"": ""f1b36fea-745c-4ac4-b869-fb5d6e463fdd"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""StartDrag"",
                    ""type"": ""PassThrough"",
                    ""id"": ""1684a313-0ab4-44ff-92dd-de3d5d435002"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""EndDrag"",
                    ""type"": ""PassThrough"",
                    ""id"": ""89056f40-f5e4-49bc-92aa-d1c1050420ad"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f3f1fb0a-9ecd-46aa-a78a-160f284cb7df"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mac"",
                    ""action"": ""Touch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4a244ce8-2053-408e-9f65-2fa4411078d9"",
                    ""path"": ""<Touchscreen>/touch*/tap"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mobile"",
                    ""action"": ""Touch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""85866b17-7aa6-447f-a6d0-19704a7d3067"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mac"",
                    ""action"": ""TouchPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""455d2712-6cab-482b-ad55-e2862176d503"",
                    ""path"": ""<Touchscreen>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mobile"",
                    ""action"": ""TouchPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4da95e7f-710a-477f-8db1-d0a2b485ca93"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mac"",
                    ""action"": ""EndDrag"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""16ea050b-7471-4ac6-9ef0-f06e99d77985"",
                    ""path"": ""<Touchscreen>/touch*/tap"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mobile"",
                    ""action"": ""EndDrag"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ec7c055c-136a-430d-b154-158cb52d8be1"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mac"",
                    ""action"": ""StartDrag"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1c382a2e-7993-4671-a8b3-470725e627d5"",
                    ""path"": ""<Touchscreen>/touch*/tap"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mobile"",
                    ""action"": ""StartDrag"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Mac"",
            ""bindingGroup"": ""Mac"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Mobile"",
            ""bindingGroup"": ""Mobile"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_Touch = m_Gameplay.FindAction("Touch", throwIfNotFound: true);
        m_Gameplay_TouchPosition = m_Gameplay.FindAction("TouchPosition", throwIfNotFound: true);
        m_Gameplay_StartDrag = m_Gameplay.FindAction("StartDrag", throwIfNotFound: true);
        m_Gameplay_EndDrag = m_Gameplay.FindAction("EndDrag", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_Touch;
    private readonly InputAction m_Gameplay_TouchPosition;
    private readonly InputAction m_Gameplay_StartDrag;
    private readonly InputAction m_Gameplay_EndDrag;
    public struct GameplayActions
    {
        private @TiagoInputAction m_Wrapper;
        public GameplayActions(@TiagoInputAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @Touch => m_Wrapper.m_Gameplay_Touch;
        public InputAction @TouchPosition => m_Wrapper.m_Gameplay_TouchPosition;
        public InputAction @StartDrag => m_Wrapper.m_Gameplay_StartDrag;
        public InputAction @EndDrag => m_Wrapper.m_Gameplay_EndDrag;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @Touch.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnTouch;
                @Touch.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnTouch;
                @Touch.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnTouch;
                @TouchPosition.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnTouchPosition;
                @TouchPosition.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnTouchPosition;
                @TouchPosition.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnTouchPosition;
                @StartDrag.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnStartDrag;
                @StartDrag.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnStartDrag;
                @StartDrag.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnStartDrag;
                @EndDrag.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnEndDrag;
                @EndDrag.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnEndDrag;
                @EndDrag.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnEndDrag;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Touch.started += instance.OnTouch;
                @Touch.performed += instance.OnTouch;
                @Touch.canceled += instance.OnTouch;
                @TouchPosition.started += instance.OnTouchPosition;
                @TouchPosition.performed += instance.OnTouchPosition;
                @TouchPosition.canceled += instance.OnTouchPosition;
                @StartDrag.started += instance.OnStartDrag;
                @StartDrag.performed += instance.OnStartDrag;
                @StartDrag.canceled += instance.OnStartDrag;
                @EndDrag.started += instance.OnEndDrag;
                @EndDrag.performed += instance.OnEndDrag;
                @EndDrag.canceled += instance.OnEndDrag;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);
    private int m_MacSchemeIndex = -1;
    public InputControlScheme MacScheme
    {
        get
        {
            if (m_MacSchemeIndex == -1) m_MacSchemeIndex = asset.FindControlSchemeIndex("Mac");
            return asset.controlSchemes[m_MacSchemeIndex];
        }
    }
    private int m_MobileSchemeIndex = -1;
    public InputControlScheme MobileScheme
    {
        get
        {
            if (m_MobileSchemeIndex == -1) m_MobileSchemeIndex = asset.FindControlSchemeIndex("Mobile");
            return asset.controlSchemes[m_MobileSchemeIndex];
        }
    }
    public interface IGameplayActions
    {
        void OnTouch(InputAction.CallbackContext context);
        void OnTouchPosition(InputAction.CallbackContext context);
        void OnStartDrag(InputAction.CallbackContext context);
        void OnEndDrag(InputAction.CallbackContext context);
    }
}
