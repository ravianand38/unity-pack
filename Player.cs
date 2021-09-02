// GENERATED AUTOMATICALLY FROM 'Assets/New Input/Player.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Player : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Player()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player"",
    ""maps"": [
        {
            ""name"": ""PlayerMain"",
            ""id"": ""9b953af4-c619-43bc-824f-84d725738d5d"",
            ""actions"": [
                {
                    ""name"": ""look"",
                    ""type"": ""Value"",
                    ""id"": ""7bbdeab2-5463-4fbd-9046-5b6fcf15a79f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""5015ca48-bb63-441a-8a95-9d21338039a9"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""jump"",
                    ""type"": ""Button"",
                    ""id"": ""30048e3c-74eb-434b-933a-387e2a00fb10"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fire1"",
                    ""type"": ""Button"",
                    ""id"": ""ff8499a6-5d03-4945-9e12-626c54b17a55"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""6486e606-7374-40bf-923d-dc88a7a9d6a2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""67a21015-5364-4145-acb4-2b963c799fe3"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""cc74cd23-5c1a-42b9-ac20-9289512a2884"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""b3345ab1-c955-4676-aa54-9af460542e3b"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""0f5fbdd3-ea01-4d1f-9c03-a173a4a62df0"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ee7e18b5-6d4c-4d43-b5c9-62accca466e0"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""698eb766-f41e-4d73-ae1c-2161bb1f640c"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""ee0380fe-6055-4791-8cc3-af7b8fe21ebc"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""69b6b365-ffd3-4b55-9a9b-ee4e25f0b21f"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5bbdf797-9f71-4b97-a6d2-8135d5648985"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fa1eee08-b8ca-4c0e-8b2a-ce4cecad2ad7"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerMain
        m_PlayerMain = asset.FindActionMap("PlayerMain", throwIfNotFound: true);
        m_PlayerMain_look = m_PlayerMain.FindAction("look", throwIfNotFound: true);
        m_PlayerMain_Move = m_PlayerMain.FindAction("Move", throwIfNotFound: true);
        m_PlayerMain_jump = m_PlayerMain.FindAction("jump", throwIfNotFound: true);
        m_PlayerMain_Fire1 = m_PlayerMain.FindAction("Fire1", throwIfNotFound: true);
        m_PlayerMain_Newaction = m_PlayerMain.FindAction("New action", throwIfNotFound: true);
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

    // PlayerMain
    private readonly InputActionMap m_PlayerMain;
    private IPlayerMainActions m_PlayerMainActionsCallbackInterface;
    private readonly InputAction m_PlayerMain_look;
    private readonly InputAction m_PlayerMain_Move;
    private readonly InputAction m_PlayerMain_jump;
    private readonly InputAction m_PlayerMain_Fire1;
    private readonly InputAction m_PlayerMain_Newaction;
    public struct PlayerMainActions
    {
        private @Player m_Wrapper;
        public PlayerMainActions(@Player wrapper) { m_Wrapper = wrapper; }
        public InputAction @look => m_Wrapper.m_PlayerMain_look;
        public InputAction @Move => m_Wrapper.m_PlayerMain_Move;
        public InputAction @jump => m_Wrapper.m_PlayerMain_jump;
        public InputAction @Fire1 => m_Wrapper.m_PlayerMain_Fire1;
        public InputAction @Newaction => m_Wrapper.m_PlayerMain_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_PlayerMain; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerMainActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerMainActions instance)
        {
            if (m_Wrapper.m_PlayerMainActionsCallbackInterface != null)
            {
                @look.started -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnLook;
                @look.performed -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnLook;
                @look.canceled -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnLook;
                @Move.started -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnMove;
                @jump.started -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnJump;
                @jump.performed -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnJump;
                @jump.canceled -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnJump;
                @Fire1.started -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnFire1;
                @Fire1.performed -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnFire1;
                @Fire1.canceled -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnFire1;
                @Newaction.started -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_PlayerMainActionsCallbackInterface = instance;
            if (instance != null)
            {
                @look.started += instance.OnLook;
                @look.performed += instance.OnLook;
                @look.canceled += instance.OnLook;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @jump.started += instance.OnJump;
                @jump.performed += instance.OnJump;
                @jump.canceled += instance.OnJump;
                @Fire1.started += instance.OnFire1;
                @Fire1.performed += instance.OnFire1;
                @Fire1.canceled += instance.OnFire1;
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public PlayerMainActions @PlayerMain => new PlayerMainActions(this);
    public interface IPlayerMainActions
    {
        void OnLook(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnFire1(InputAction.CallbackContext context);
        void OnNewaction(InputAction.CallbackContext context);
    }
}
