//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/InputAction/RocketInputAction.inputactions
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

public partial class @RocketInputAction: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @RocketInputAction()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""RocketInputAction"",
    ""maps"": [
        {
            ""name"": ""Rocket"",
            ""id"": ""6d25d125-b3f1-43b8-a7a2-a9b95c289d38"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""282b1f60-71ea-4192-ae0c-4abeb8acfefe"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Booster"",
                    ""type"": ""Value"",
                    ""id"": ""d12e881e-e981-42d4-902f-2a701b469710"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Energy"",
                    ""type"": ""Value"",
                    ""id"": ""3a44061b-6f72-415c-b5f6-af6f03c47f8d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b7a72634-05bf-4a07-bcc0-d93fe292628b"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseKeyBoard"",
                    ""action"": ""Booster"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8df989af-6a67-4610-9c12-663855680237"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Energy"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""b907dc39-d234-4527-82c1-04b8c57ad08c"",
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
                    ""id"": ""e0a4f52d-a10d-44d0-b1d9-538c96537c4c"",
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
                    ""id"": ""c51e9f8f-0de6-4f5b-9f9b-c957fea00a6c"",
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
                    ""id"": ""dda29dd8-5e7a-46ff-a55b-7e5b4130eeff"",
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
                    ""id"": ""80b766db-b925-4d44-ab4f-cbd18002cdd7"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseKeyBoard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""MouseKeyBoard"",
            ""bindingGroup"": ""MouseKeyBoard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Rocket
        m_Rocket = asset.FindActionMap("Rocket", throwIfNotFound: true);
        m_Rocket_Move = m_Rocket.FindAction("Move", throwIfNotFound: true);
        m_Rocket_Booster = m_Rocket.FindAction("Booster", throwIfNotFound: true);
        m_Rocket_Energy = m_Rocket.FindAction("Energy", throwIfNotFound: true);
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

    // Rocket
    private readonly InputActionMap m_Rocket;
    private List<IRocketActions> m_RocketActionsCallbackInterfaces = new List<IRocketActions>();
    private readonly InputAction m_Rocket_Move;
    private readonly InputAction m_Rocket_Booster;
    private readonly InputAction m_Rocket_Energy;
    public struct RocketActions
    {
        private @RocketInputAction m_Wrapper;
        public RocketActions(@RocketInputAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Rocket_Move;
        public InputAction @Booster => m_Wrapper.m_Rocket_Booster;
        public InputAction @Energy => m_Wrapper.m_Rocket_Energy;
        public InputActionMap Get() { return m_Wrapper.m_Rocket; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(RocketActions set) { return set.Get(); }
        public void AddCallbacks(IRocketActions instance)
        {
            if (instance == null || m_Wrapper.m_RocketActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_RocketActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
            @Booster.started += instance.OnBooster;
            @Booster.performed += instance.OnBooster;
            @Booster.canceled += instance.OnBooster;
            @Energy.started += instance.OnEnergy;
            @Energy.performed += instance.OnEnergy;
            @Energy.canceled += instance.OnEnergy;
        }

        private void UnregisterCallbacks(IRocketActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @Booster.started -= instance.OnBooster;
            @Booster.performed -= instance.OnBooster;
            @Booster.canceled -= instance.OnBooster;
            @Energy.started -= instance.OnEnergy;
            @Energy.performed -= instance.OnEnergy;
            @Energy.canceled -= instance.OnEnergy;
        }

        public void RemoveCallbacks(IRocketActions instance)
        {
            if (m_Wrapper.m_RocketActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IRocketActions instance)
        {
            foreach (var item in m_Wrapper.m_RocketActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_RocketActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public RocketActions @Rocket => new RocketActions(this);
    private int m_MouseKeyBoardSchemeIndex = -1;
    public InputControlScheme MouseKeyBoardScheme
    {
        get
        {
            if (m_MouseKeyBoardSchemeIndex == -1) m_MouseKeyBoardSchemeIndex = asset.FindControlSchemeIndex("MouseKeyBoard");
            return asset.controlSchemes[m_MouseKeyBoardSchemeIndex];
        }
    }
    public interface IRocketActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnBooster(InputAction.CallbackContext context);
        void OnEnergy(InputAction.CallbackContext context);
    }
}
