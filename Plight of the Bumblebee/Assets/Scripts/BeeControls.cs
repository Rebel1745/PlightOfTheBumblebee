// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/BeeControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @BeeControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @BeeControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""BeeControls"",
    ""maps"": [
        {
            ""name"": ""Bee"",
            ""id"": ""c0f63433-e221-4f5c-920b-4fa7fdc5a47a"",
            ""actions"": [
                {
                    ""name"": ""Cyclic"",
                    ""type"": ""PassThrough"",
                    ""id"": ""dfa40751-ab7c-454a-964d-8917e5260061"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pedals"",
                    ""type"": ""Button"",
                    ""id"": ""c352a792-9f1c-42db-b251-dfd81d571098"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Power"",
                    ""type"": ""Button"",
                    ""id"": ""ce080582-7340-4c70-a8d5-10ddbfbe0491"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Land"",
                    ""type"": ""Button"",
                    ""id"": ""bb57d1d3-b2d4-4b75-9379-3ca062fd45ed"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""dee0f0d1-bb94-4229-b504-701cfd9f6b0b"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cyclic"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""c6e91522-e31c-4cb3-aa3d-dd801d88c68b"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cyclic"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""382391b9-c658-4ca4-b590-0b301826fc5f"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cyclic"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""10a5a2c4-0169-4be0-853e-663ad82f5ba5"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cyclic"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""5862fa3c-3bfb-4463-afc5-0d3ab31265e4"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cyclic"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""LStick"",
                    ""id"": ""e3355f73-ffe5-4e4a-81f9-14a60be3a4f2"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cyclic"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""2380f0cc-5796-459b-90f6-e7380f882b4b"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cyclic"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""dd87bfd3-b552-47fc-9d81-12260b6e6a2b"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cyclic"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""6ac8bc3e-df6f-4022-8d87-0e09ede91af8"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cyclic"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""fb99aa46-57a6-40a9-b104-26d6ec89ed7a"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cyclic"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""8a55faf2-7916-4956-9ffe-c104dc8c9127"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pedals"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""696fd762-e9d7-4a98-8de2-d62661be945d"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pedals"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""5fe7ea18-7b22-4875-ba52-4fa02b8787c6"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pedals"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""RStick"",
                    ""id"": ""2f946982-e6e1-482e-9b2b-766b0e1eb03b"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pedals"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""e1f469aa-6f09-4705-8338-65139cb51b18"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pedals"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""eb267eb3-7550-4457-b8e3-1989c208c4c0"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pedals"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""006b8fd9-8c43-4159-812e-6caa189c5030"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Power"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""43485c96-6408-4a35-aebb-f8cb616c7960"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Power"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""5f892003-ec87-496b-b907-ad0b551592c6"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Power"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""RStick"",
                    ""id"": ""4175c3bb-5f8e-4ac3-9b90-21df22e160ca"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Power"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""e5562c76-ae9d-4fd9-9c30-352bc9aa77af"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Power"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""8be52f13-7e94-4a46-a639-23714e278aa0"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Power"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""2889f85d-f71b-4171-b530-376d8a981f84"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Land"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""152e698d-923e-413d-9314-7d5addbb8e54"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Land"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Bee
        m_Bee = asset.FindActionMap("Bee", throwIfNotFound: true);
        m_Bee_Cyclic = m_Bee.FindAction("Cyclic", throwIfNotFound: true);
        m_Bee_Pedals = m_Bee.FindAction("Pedals", throwIfNotFound: true);
        m_Bee_Power = m_Bee.FindAction("Power", throwIfNotFound: true);
        m_Bee_Land = m_Bee.FindAction("Land", throwIfNotFound: true);
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

    // Bee
    private readonly InputActionMap m_Bee;
    private IBeeActions m_BeeActionsCallbackInterface;
    private readonly InputAction m_Bee_Cyclic;
    private readonly InputAction m_Bee_Pedals;
    private readonly InputAction m_Bee_Power;
    private readonly InputAction m_Bee_Land;
    public struct BeeActions
    {
        private @BeeControls m_Wrapper;
        public BeeActions(@BeeControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Cyclic => m_Wrapper.m_Bee_Cyclic;
        public InputAction @Pedals => m_Wrapper.m_Bee_Pedals;
        public InputAction @Power => m_Wrapper.m_Bee_Power;
        public InputAction @Land => m_Wrapper.m_Bee_Land;
        public InputActionMap Get() { return m_Wrapper.m_Bee; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BeeActions set) { return set.Get(); }
        public void SetCallbacks(IBeeActions instance)
        {
            if (m_Wrapper.m_BeeActionsCallbackInterface != null)
            {
                @Cyclic.started -= m_Wrapper.m_BeeActionsCallbackInterface.OnCyclic;
                @Cyclic.performed -= m_Wrapper.m_BeeActionsCallbackInterface.OnCyclic;
                @Cyclic.canceled -= m_Wrapper.m_BeeActionsCallbackInterface.OnCyclic;
                @Pedals.started -= m_Wrapper.m_BeeActionsCallbackInterface.OnPedals;
                @Pedals.performed -= m_Wrapper.m_BeeActionsCallbackInterface.OnPedals;
                @Pedals.canceled -= m_Wrapper.m_BeeActionsCallbackInterface.OnPedals;
                @Power.started -= m_Wrapper.m_BeeActionsCallbackInterface.OnPower;
                @Power.performed -= m_Wrapper.m_BeeActionsCallbackInterface.OnPower;
                @Power.canceled -= m_Wrapper.m_BeeActionsCallbackInterface.OnPower;
                @Land.started -= m_Wrapper.m_BeeActionsCallbackInterface.OnLand;
                @Land.performed -= m_Wrapper.m_BeeActionsCallbackInterface.OnLand;
                @Land.canceled -= m_Wrapper.m_BeeActionsCallbackInterface.OnLand;
            }
            m_Wrapper.m_BeeActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Cyclic.started += instance.OnCyclic;
                @Cyclic.performed += instance.OnCyclic;
                @Cyclic.canceled += instance.OnCyclic;
                @Pedals.started += instance.OnPedals;
                @Pedals.performed += instance.OnPedals;
                @Pedals.canceled += instance.OnPedals;
                @Power.started += instance.OnPower;
                @Power.performed += instance.OnPower;
                @Power.canceled += instance.OnPower;
                @Land.started += instance.OnLand;
                @Land.performed += instance.OnLand;
                @Land.canceled += instance.OnLand;
            }
        }
    }
    public BeeActions @Bee => new BeeActions(this);
    public interface IBeeActions
    {
        void OnCyclic(InputAction.CallbackContext context);
        void OnPedals(InputAction.CallbackContext context);
        void OnPower(InputAction.CallbackContext context);
        void OnLand(InputAction.CallbackContext context);
    }
}
