//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/controles/Controles.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @Controles : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controles()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controles"",
    ""maps"": [
        {
            ""name"": ""gamplay"",
            ""id"": ""b19cc0cc-807c-4f2d-99e6-e42bc1207e4b"",
            ""actions"": [
                {
                    ""name"": ""Movimiento"",
                    ""type"": ""Value"",
                    ""id"": ""2d87f43d-d98b-4471-9031-cdf2fa441b95"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Sprin"",
                    ""type"": ""Button"",
                    ""id"": ""5de9068c-d905-490d-abf2-e1fc5fdc7936"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Zoom"",
                    ""type"": ""Button"",
                    ""id"": ""9f1fea57-c726-4cda-8031-4091f731c973"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""pRUEBA"",
                    ""type"": ""Value"",
                    ""id"": ""94338450-bb91-45e3-859a-a22f0e0cfba8"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""fgtsrdtgsr"",
                    ""type"": ""Button"",
                    ""id"": ""aaae7262-6683-4d47-a19f-3fc5657d34f3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""ASDW"",
                    ""id"": ""bec4d684-fdce-4fb9-9b54-8b6f4cc28cc5"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movimiento"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""a14966c7-19a7-483b-9d41-26870948c9d1"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""teclado"",
                    ""action"": ""Movimiento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""220fe87f-48d8-434c-883d-91a7e10d8491"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""teclado"",
                    ""action"": ""Movimiento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""7558ea00-a9b3-44da-aac6-9d1895df4e22"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""teclado"",
                    ""action"": ""Movimiento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""4c872326-7f26-48ff-97b2-9cf2029d868e"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""teclado"",
                    ""action"": ""Movimiento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""f4af61ed-ae19-40f9-901a-a6f023c5b67c"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movimiento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1aad866e-49ec-4e49-a762-37877340033f"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprin"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7153fa2e-f9ae-468a-baae-5ac668311108"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprin"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d9f6564b-e7be-44ef-b0f6-816905849000"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a3217887-2503-47a4-aff4-90151f870c88"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f4eb590e-752f-4dfa-990e-c90c48a6a486"",
                    ""path"": ""<Gyroscope>/angularVelocity"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""pRUEBA"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5387cde1-530a-45ab-aa80-af21a8b85649"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""fgtsrdtgsr"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""teclado"",
            ""bindingGroup"": ""teclado"",
            ""devices"": []
        }
    ]
}");
        // gamplay
        m_gamplay = asset.FindActionMap("gamplay", throwIfNotFound: true);
        m_gamplay_Movimiento = m_gamplay.FindAction("Movimiento", throwIfNotFound: true);
        m_gamplay_Sprin = m_gamplay.FindAction("Sprin", throwIfNotFound: true);
        m_gamplay_Zoom = m_gamplay.FindAction("Zoom", throwIfNotFound: true);
        m_gamplay_pRUEBA = m_gamplay.FindAction("pRUEBA", throwIfNotFound: true);
        m_gamplay_fgtsrdtgsr = m_gamplay.FindAction("fgtsrdtgsr", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // gamplay
    private readonly InputActionMap m_gamplay;
    private IGamplayActions m_GamplayActionsCallbackInterface;
    private readonly InputAction m_gamplay_Movimiento;
    private readonly InputAction m_gamplay_Sprin;
    private readonly InputAction m_gamplay_Zoom;
    private readonly InputAction m_gamplay_pRUEBA;
    private readonly InputAction m_gamplay_fgtsrdtgsr;
    public struct GamplayActions
    {
        private @Controles m_Wrapper;
        public GamplayActions(@Controles wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movimiento => m_Wrapper.m_gamplay_Movimiento;
        public InputAction @Sprin => m_Wrapper.m_gamplay_Sprin;
        public InputAction @Zoom => m_Wrapper.m_gamplay_Zoom;
        public InputAction @pRUEBA => m_Wrapper.m_gamplay_pRUEBA;
        public InputAction @fgtsrdtgsr => m_Wrapper.m_gamplay_fgtsrdtgsr;
        public InputActionMap Get() { return m_Wrapper.m_gamplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GamplayActions set) { return set.Get(); }
        public void SetCallbacks(IGamplayActions instance)
        {
            if (m_Wrapper.m_GamplayActionsCallbackInterface != null)
            {
                @Movimiento.started -= m_Wrapper.m_GamplayActionsCallbackInterface.OnMovimiento;
                @Movimiento.performed -= m_Wrapper.m_GamplayActionsCallbackInterface.OnMovimiento;
                @Movimiento.canceled -= m_Wrapper.m_GamplayActionsCallbackInterface.OnMovimiento;
                @Sprin.started -= m_Wrapper.m_GamplayActionsCallbackInterface.OnSprin;
                @Sprin.performed -= m_Wrapper.m_GamplayActionsCallbackInterface.OnSprin;
                @Sprin.canceled -= m_Wrapper.m_GamplayActionsCallbackInterface.OnSprin;
                @Zoom.started -= m_Wrapper.m_GamplayActionsCallbackInterface.OnZoom;
                @Zoom.performed -= m_Wrapper.m_GamplayActionsCallbackInterface.OnZoom;
                @Zoom.canceled -= m_Wrapper.m_GamplayActionsCallbackInterface.OnZoom;
                @pRUEBA.started -= m_Wrapper.m_GamplayActionsCallbackInterface.OnPRUEBA;
                @pRUEBA.performed -= m_Wrapper.m_GamplayActionsCallbackInterface.OnPRUEBA;
                @pRUEBA.canceled -= m_Wrapper.m_GamplayActionsCallbackInterface.OnPRUEBA;
                @fgtsrdtgsr.started -= m_Wrapper.m_GamplayActionsCallbackInterface.OnFgtsrdtgsr;
                @fgtsrdtgsr.performed -= m_Wrapper.m_GamplayActionsCallbackInterface.OnFgtsrdtgsr;
                @fgtsrdtgsr.canceled -= m_Wrapper.m_GamplayActionsCallbackInterface.OnFgtsrdtgsr;
            }
            m_Wrapper.m_GamplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movimiento.started += instance.OnMovimiento;
                @Movimiento.performed += instance.OnMovimiento;
                @Movimiento.canceled += instance.OnMovimiento;
                @Sprin.started += instance.OnSprin;
                @Sprin.performed += instance.OnSprin;
                @Sprin.canceled += instance.OnSprin;
                @Zoom.started += instance.OnZoom;
                @Zoom.performed += instance.OnZoom;
                @Zoom.canceled += instance.OnZoom;
                @pRUEBA.started += instance.OnPRUEBA;
                @pRUEBA.performed += instance.OnPRUEBA;
                @pRUEBA.canceled += instance.OnPRUEBA;
                @fgtsrdtgsr.started += instance.OnFgtsrdtgsr;
                @fgtsrdtgsr.performed += instance.OnFgtsrdtgsr;
                @fgtsrdtgsr.canceled += instance.OnFgtsrdtgsr;
            }
        }
    }
    public GamplayActions @gamplay => new GamplayActions(this);
    private int m_tecladoSchemeIndex = -1;
    public InputControlScheme tecladoScheme
    {
        get
        {
            if (m_tecladoSchemeIndex == -1) m_tecladoSchemeIndex = asset.FindControlSchemeIndex("teclado");
            return asset.controlSchemes[m_tecladoSchemeIndex];
        }
    }
    public interface IGamplayActions
    {
        void OnMovimiento(InputAction.CallbackContext context);
        void OnSprin(InputAction.CallbackContext context);
        void OnZoom(InputAction.CallbackContext context);
        void OnPRUEBA(InputAction.CallbackContext context);
        void OnFgtsrdtgsr(InputAction.CallbackContext context);
    }
}
