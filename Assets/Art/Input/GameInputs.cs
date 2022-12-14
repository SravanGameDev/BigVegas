//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Input/GameInputs.inputactions
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

public partial class @GameInputs : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @GameInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GameInputs"",
    ""maps"": [
        {
            ""name"": ""DoozyControls"",
            ""id"": ""856f4d78-b34a-46ba-b294-3ba0545231c2"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""2fbad324-cb80-48f3-aee5-0f888f7e1ee5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5fc87fe9-b928-4447-abb2-a205c2f77856"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1a6cf4f5-17a9-4307-b37c-a967b4e1c350"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""BigVegasControls"",
            ""id"": ""4b8b3e64-f1da-4f06-979e-af78993e7075"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""43efa485-5ad0-40f1-8391-d12f35b02f1c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""07c118b6-2378-4eda-aa0c-7e797a134525"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""CMove"",
                    ""type"": ""Value"",
                    ""id"": ""75fb72bd-c420-473f-a132-693957b12003"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""27aebb59-a5f1-4b56-97b1-131b4cd1dad2"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""0eaad280-2933-4e58-a8dd-600dbfd18895"",
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
                    ""id"": ""25a84185-972a-46e1-9a82-abd97ff9b844"",
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
                    ""id"": ""adca5dc9-7ede-48cc-bb9d-120f60a429d3"",
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
                    ""id"": ""fea8553f-eaf5-4a96-a4bb-30ea4bf02769"",
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
                    ""id"": ""3fd8a0d2-c7d8-4fe5-ace1-c178d9a51b8b"",
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
                    ""id"": ""0363505d-15a4-4e70-942d-4d6895384132"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ce27d411-f08f-4c44-ba08-1b8c340e2354"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6bf49ac5-e0dc-4223-8ba4-804997a5533b"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // DoozyControls
        m_DoozyControls = asset.FindActionMap("DoozyControls", throwIfNotFound: true);
        m_DoozyControls_Movement = m_DoozyControls.FindAction("Movement", throwIfNotFound: true);
        // BigVegasControls
        m_BigVegasControls = asset.FindActionMap("BigVegasControls", throwIfNotFound: true);
        m_BigVegasControls_Move = m_BigVegasControls.FindAction("Move", throwIfNotFound: true);
        m_BigVegasControls_Run = m_BigVegasControls.FindAction("Run", throwIfNotFound: true);
        m_BigVegasControls_CMove = m_BigVegasControls.FindAction("CMove", throwIfNotFound: true);
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

    // DoozyControls
    private readonly InputActionMap m_DoozyControls;
    private IDoozyControlsActions m_DoozyControlsActionsCallbackInterface;
    private readonly InputAction m_DoozyControls_Movement;
    public struct DoozyControlsActions
    {
        private @GameInputs m_Wrapper;
        public DoozyControlsActions(@GameInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_DoozyControls_Movement;
        public InputActionMap Get() { return m_Wrapper.m_DoozyControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DoozyControlsActions set) { return set.Get(); }
        public void SetCallbacks(IDoozyControlsActions instance)
        {
            if (m_Wrapper.m_DoozyControlsActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_DoozyControlsActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_DoozyControlsActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_DoozyControlsActionsCallbackInterface.OnMovement;
            }
            m_Wrapper.m_DoozyControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
            }
        }
    }
    public DoozyControlsActions @DoozyControls => new DoozyControlsActions(this);

    // BigVegasControls
    private readonly InputActionMap m_BigVegasControls;
    private IBigVegasControlsActions m_BigVegasControlsActionsCallbackInterface;
    private readonly InputAction m_BigVegasControls_Move;
    private readonly InputAction m_BigVegasControls_Run;
    private readonly InputAction m_BigVegasControls_CMove;
    public struct BigVegasControlsActions
    {
        private @GameInputs m_Wrapper;
        public BigVegasControlsActions(@GameInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_BigVegasControls_Move;
        public InputAction @Run => m_Wrapper.m_BigVegasControls_Run;
        public InputAction @CMove => m_Wrapper.m_BigVegasControls_CMove;
        public InputActionMap Get() { return m_Wrapper.m_BigVegasControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BigVegasControlsActions set) { return set.Get(); }
        public void SetCallbacks(IBigVegasControlsActions instance)
        {
            if (m_Wrapper.m_BigVegasControlsActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_BigVegasControlsActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_BigVegasControlsActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_BigVegasControlsActionsCallbackInterface.OnMove;
                @Run.started -= m_Wrapper.m_BigVegasControlsActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_BigVegasControlsActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_BigVegasControlsActionsCallbackInterface.OnRun;
                @CMove.started -= m_Wrapper.m_BigVegasControlsActionsCallbackInterface.OnCMove;
                @CMove.performed -= m_Wrapper.m_BigVegasControlsActionsCallbackInterface.OnCMove;
                @CMove.canceled -= m_Wrapper.m_BigVegasControlsActionsCallbackInterface.OnCMove;
            }
            m_Wrapper.m_BigVegasControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
                @CMove.started += instance.OnCMove;
                @CMove.performed += instance.OnCMove;
                @CMove.canceled += instance.OnCMove;
            }
        }
    }
    public BigVegasControlsActions @BigVegasControls => new BigVegasControlsActions(this);
    public interface IDoozyControlsActions
    {
        void OnMovement(InputAction.CallbackContext context);
    }
    public interface IBigVegasControlsActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnCMove(InputAction.CallbackContext context);
    }
}
