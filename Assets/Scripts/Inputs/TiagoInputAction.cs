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
            ""id"": ""a5231746-5cf5-42b2-8fba-1a9b30c43b5b"",
            ""actions"": [
                {
                    ""name"": ""Touch"",
                    ""type"": ""Button"",
                    ""id"": ""9d6e4bba-8eaa-4248-b935-73e96d73d799"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""TouchPosition"",
                    ""type"": ""PassThrough"",
                    ""id"": ""e72ed921-cf6e-452a-b393-7885aac854b3"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""StartDrag"",
                    ""type"": ""PassThrough"",
                    ""id"": ""d8b4aceb-1e29-4a24-a1d9-f7caf8d65495"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""EndDrag"",
                    ""type"": ""PassThrough"",
                    ""id"": ""6eba29bc-2cbe-4efb-844d-bf59eae7a165"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""914034c4-261e-4d27-991c-d7f1c916fbbc"",
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
                    ""id"": ""77427e25-5287-4a4b-86b3-63854b3392e1"",
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
                    ""id"": ""1d3f3308-4805-4601-9177-8e0c613baac0"",
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
                    ""id"": ""e1ffa3f0-f5a1-44a7-a7cc-14526e2731cf"",
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
                    ""id"": ""51fc5c3c-57e4-4684-b612-1ba6ade2fb00"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Mac"",
                    ""action"": ""StartDrag"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8586611e-11c0-419e-b56b-707fb73ee1c4"",
                    ""path"": ""<Touchscreen>/touch*/tap"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mobile"",
                    ""action"": ""StartDrag"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1ff74707-0570-41f7-826b-683c10d3666f"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": ""Mac"",
                    ""action"": ""EndDrag"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0ce28cfe-b4e8-4224-8657-5277c585dc55"",
                    ""path"": ""<Touchscreen>/touch*/tap"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mobile"",
                    ""action"": ""EndDrag"",
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
