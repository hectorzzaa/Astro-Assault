//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Controles.inputactions
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
            ""name"": ""Juego"",
            ""id"": ""65299913-f24c-433b-a9d5-dd390036515e"",
            ""actions"": [
                {
                    ""name"": ""Movmiento"",
                    ""type"": ""Value"",
                    ""id"": ""0f87cde7-73b4-4892-8e7c-9563ff57b2e0"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""disparo"",
                    ""type"": ""Button"",
                    ""id"": ""92211f03-8a34-4bd9-9ea4-516aaf84600b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Button"",
                    ""id"": ""0e70d706-a9cd-4199-bb82-7de114492e1b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Rotar"",
                    ""type"": ""Value"",
                    ""id"": ""d404681e-e8db-49d8-a058-23a815917a2a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ebe79489-6c35-45c6-aac9-aff59b80a7ed"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movmiento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""562a3e06-5800-4599-a6c6-5899e150c5c6"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movmiento"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""8204538c-845c-4a67-bd34-597798409777"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movmiento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""4fc8f818-158c-46cc-9403-daf759d7e1be"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movmiento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""5e9234eb-6e64-4439-9500-52582d785f2a"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movmiento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""98714bdf-a125-4aab-9b66-52e1071f0800"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movmiento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""8b850d2e-0b32-46bc-b620-bf3677d364f7"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movmiento"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""1e38cff8-071e-4c04-a5f2-c9d9476ef3a6"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movmiento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""73fc83d3-7abe-4a40-b968-cc96e19ec128"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movmiento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4a583ad6-9432-4759-8087-ce83e23919e5"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movmiento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""4ab540e4-39a4-44e5-8eb6-fa808c8c92db"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movmiento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""cea1f35c-7803-4857-ab8d-0e8fb2ffdd77"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""disparo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""97020df8-6ada-44e9-bced-c75aef57ab0e"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""disparo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e70bd1da-0b2e-43cc-9419-d51e4773d565"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6273292a-bb7c-405d-867a-bf35d0ead23f"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""48d838bf-9cf8-4a3b-9292-91fe50ce8aec"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotar"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""b1d3c090-2e3c-4219-9402-f3c754919d0b"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c64eadce-9409-4624-814d-6da7992d020c"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""1c82039e-ad51-4881-a3d3-6d794bee0743"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""3905a7c3-2c0e-49bd-b49f-00ce38b5f6bd"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Juego
        m_Juego = asset.FindActionMap("Juego", throwIfNotFound: true);
        m_Juego_Movmiento = m_Juego.FindAction("Movmiento", throwIfNotFound: true);
        m_Juego_disparo = m_Juego.FindAction("disparo", throwIfNotFound: true);
        m_Juego_Dash = m_Juego.FindAction("Dash", throwIfNotFound: true);
        m_Juego_Rotar = m_Juego.FindAction("Rotar", throwIfNotFound: true);
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

    // Juego
    private readonly InputActionMap m_Juego;
    private IJuegoActions m_JuegoActionsCallbackInterface;
    private readonly InputAction m_Juego_Movmiento;
    private readonly InputAction m_Juego_disparo;
    private readonly InputAction m_Juego_Dash;
    private readonly InputAction m_Juego_Rotar;
    public struct JuegoActions
    {
        private @Controles m_Wrapper;
        public JuegoActions(@Controles wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movmiento => m_Wrapper.m_Juego_Movmiento;
        public InputAction @disparo => m_Wrapper.m_Juego_disparo;
        public InputAction @Dash => m_Wrapper.m_Juego_Dash;
        public InputAction @Rotar => m_Wrapper.m_Juego_Rotar;
        public InputActionMap Get() { return m_Wrapper.m_Juego; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(JuegoActions set) { return set.Get(); }
        public void SetCallbacks(IJuegoActions instance)
        {
            if (m_Wrapper.m_JuegoActionsCallbackInterface != null)
            {
                @Movmiento.started -= m_Wrapper.m_JuegoActionsCallbackInterface.OnMovmiento;
                @Movmiento.performed -= m_Wrapper.m_JuegoActionsCallbackInterface.OnMovmiento;
                @Movmiento.canceled -= m_Wrapper.m_JuegoActionsCallbackInterface.OnMovmiento;
                @disparo.started -= m_Wrapper.m_JuegoActionsCallbackInterface.OnDisparo;
                @disparo.performed -= m_Wrapper.m_JuegoActionsCallbackInterface.OnDisparo;
                @disparo.canceled -= m_Wrapper.m_JuegoActionsCallbackInterface.OnDisparo;
                @Dash.started -= m_Wrapper.m_JuegoActionsCallbackInterface.OnDash;
                @Dash.performed -= m_Wrapper.m_JuegoActionsCallbackInterface.OnDash;
                @Dash.canceled -= m_Wrapper.m_JuegoActionsCallbackInterface.OnDash;
                @Rotar.started -= m_Wrapper.m_JuegoActionsCallbackInterface.OnRotar;
                @Rotar.performed -= m_Wrapper.m_JuegoActionsCallbackInterface.OnRotar;
                @Rotar.canceled -= m_Wrapper.m_JuegoActionsCallbackInterface.OnRotar;
            }
            m_Wrapper.m_JuegoActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movmiento.started += instance.OnMovmiento;
                @Movmiento.performed += instance.OnMovmiento;
                @Movmiento.canceled += instance.OnMovmiento;
                @disparo.started += instance.OnDisparo;
                @disparo.performed += instance.OnDisparo;
                @disparo.canceled += instance.OnDisparo;
                @Dash.started += instance.OnDash;
                @Dash.performed += instance.OnDash;
                @Dash.canceled += instance.OnDash;
                @Rotar.started += instance.OnRotar;
                @Rotar.performed += instance.OnRotar;
                @Rotar.canceled += instance.OnRotar;
            }
        }
    }
    public JuegoActions @Juego => new JuegoActions(this);
    public interface IJuegoActions
    {
        void OnMovmiento(InputAction.CallbackContext context);
        void OnDisparo(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
        void OnRotar(InputAction.CallbackContext context);
    }
}