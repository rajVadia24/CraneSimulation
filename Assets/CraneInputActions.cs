//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.5.1
//     from Assets/CraneInputActions.inputactions
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

public partial class @CraneInputActions: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @CraneInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""CraneInputActions"",
    ""maps"": [
        {
            ""name"": ""Crane"",
            ""id"": ""6e58ca60-18cd-4cfb-8bed-a62f146767a0"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""1485e50b-1ee4-4a46-b07d-70421a4515cc"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""PickupAndDrop"",
                    ""type"": ""Button"",
                    ""id"": ""be97a59a-17b2-4905-bee2-178df83356b0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ShrinkRope"",
                    ""type"": ""Button"",
                    ""id"": ""fc1b1fc1-e670-46c1-94b5-f8d02d62a847"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""LooseRope"",
                    ""type"": ""Button"",
                    ""id"": ""308d90be-4691-42f8-97f4-66830dd73990"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""3D Vector"",
                    ""id"": ""27dcfcfc-d4b6-47e2-a1e0-aabc71e8ac5d"",
                    ""path"": ""3DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""d885558a-7ac7-46c5-a5f6-4fc644824f87"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a17e9f51-5479-415f-bb3f-7824953e5e06"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""41baaaab-a2bd-4630-a7b1-39424baa0608"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""6d61bd62-8f07-4493-ba90-ec43490edebe"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""a38a0ca2-8de7-45ac-adb1-30179b89b663"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PickupAndDrop"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e4b6a614-3946-4293-b664-25eee58b3f28"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShrinkRope"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""838108fd-6964-494e-8477-52b6a0335d3e"",
                    ""path"": ""<Keyboard>/alt"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LooseRope"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Crane
        m_Crane = asset.FindActionMap("Crane", throwIfNotFound: true);
        m_Crane_Movement = m_Crane.FindAction("Movement", throwIfNotFound: true);
        m_Crane_PickupAndDrop = m_Crane.FindAction("PickupAndDrop", throwIfNotFound: true);
        m_Crane_ShrinkRope = m_Crane.FindAction("ShrinkRope", throwIfNotFound: true);
        m_Crane_LooseRope = m_Crane.FindAction("LooseRope", throwIfNotFound: true);
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

    // Crane
    private readonly InputActionMap m_Crane;
    private List<ICraneActions> m_CraneActionsCallbackInterfaces = new List<ICraneActions>();
    private readonly InputAction m_Crane_Movement;
    private readonly InputAction m_Crane_PickupAndDrop;
    private readonly InputAction m_Crane_ShrinkRope;
    private readonly InputAction m_Crane_LooseRope;
    public struct CraneActions
    {
        private @CraneInputActions m_Wrapper;
        public CraneActions(@CraneInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Crane_Movement;
        public InputAction @PickupAndDrop => m_Wrapper.m_Crane_PickupAndDrop;
        public InputAction @ShrinkRope => m_Wrapper.m_Crane_ShrinkRope;
        public InputAction @LooseRope => m_Wrapper.m_Crane_LooseRope;
        public InputActionMap Get() { return m_Wrapper.m_Crane; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CraneActions set) { return set.Get(); }
        public void AddCallbacks(ICraneActions instance)
        {
            if (instance == null || m_Wrapper.m_CraneActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_CraneActionsCallbackInterfaces.Add(instance);
            @Movement.started += instance.OnMovement;
            @Movement.performed += instance.OnMovement;
            @Movement.canceled += instance.OnMovement;
            @PickupAndDrop.started += instance.OnPickupAndDrop;
            @PickupAndDrop.performed += instance.OnPickupAndDrop;
            @PickupAndDrop.canceled += instance.OnPickupAndDrop;
            @ShrinkRope.started += instance.OnShrinkRope;
            @ShrinkRope.performed += instance.OnShrinkRope;
            @ShrinkRope.canceled += instance.OnShrinkRope;
            @LooseRope.started += instance.OnLooseRope;
            @LooseRope.performed += instance.OnLooseRope;
            @LooseRope.canceled += instance.OnLooseRope;
        }

        private void UnregisterCallbacks(ICraneActions instance)
        {
            @Movement.started -= instance.OnMovement;
            @Movement.performed -= instance.OnMovement;
            @Movement.canceled -= instance.OnMovement;
            @PickupAndDrop.started -= instance.OnPickupAndDrop;
            @PickupAndDrop.performed -= instance.OnPickupAndDrop;
            @PickupAndDrop.canceled -= instance.OnPickupAndDrop;
            @ShrinkRope.started -= instance.OnShrinkRope;
            @ShrinkRope.performed -= instance.OnShrinkRope;
            @ShrinkRope.canceled -= instance.OnShrinkRope;
            @LooseRope.started -= instance.OnLooseRope;
            @LooseRope.performed -= instance.OnLooseRope;
            @LooseRope.canceled -= instance.OnLooseRope;
        }

        public void RemoveCallbacks(ICraneActions instance)
        {
            if (m_Wrapper.m_CraneActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ICraneActions instance)
        {
            foreach (var item in m_Wrapper.m_CraneActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_CraneActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public CraneActions @Crane => new CraneActions(this);
    public interface ICraneActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnPickupAndDrop(InputAction.CallbackContext context);
        void OnShrinkRope(InputAction.CallbackContext context);
        void OnLooseRope(InputAction.CallbackContext context);
    }
}
