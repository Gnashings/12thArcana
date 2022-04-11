// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/BossScripts/BossControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @BossControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @BossControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""BossControls"",
    ""maps"": [
        {
            ""name"": ""BossInputs"",
            ""id"": ""9a989c66-8e11-492c-a58c-f81c07ca3d31"",
            ""actions"": [
                {
                    ""name"": ""Projectile"",
                    ""type"": ""Button"",
                    ""id"": ""59140370-03d1-48c4-b8ba-c1ffe80bfd6d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Plume"",
                    ""type"": ""Button"",
                    ""id"": ""728ca945-8e13-4f31-8f9c-6e15f4ec5cb7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Homing"",
                    ""type"": ""Button"",
                    ""id"": ""2647907c-83e2-4b93-8e2b-820c7c4d57b2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""d4be76a5-8c71-40cc-ba95-f8f57893256b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ce5d4c5a-57bb-4a4a-a021-3170ebd64b25"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""BossControls"",
                    ""action"": ""Projectile"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5cd22605-2d57-4855-b0d1-db5ca80bcbf2"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""BossControls"",
                    ""action"": ""Projectile"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aac10c31-4cfd-47ef-b007-db7c1c96bb7a"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""BossControls"",
                    ""action"": ""Plume"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d5ac3176-1842-4434-9c74-ce9e66680ba4"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""BossControls"",
                    ""action"": ""Plume"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d75408f6-cf3b-4513-8beb-21d96e0396a9"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""BossControls"",
                    ""action"": ""Homing"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6bf9dd84-9863-4c3b-a61a-17856cf9366e"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""BossControls"",
                    ""action"": ""Homing"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""90ee4f3c-ae37-419b-8d94-8b5d580cbf7d"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""BossControls"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""347b9538-172e-4841-8781-271ee8ed5b75"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""BossControls"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""BossControls"",
            ""bindingGroup"": ""BossControls"",
            ""devices"": []
        }
    ]
}");
        // BossInputs
        m_BossInputs = asset.FindActionMap("BossInputs", throwIfNotFound: true);
        m_BossInputs_Projectile = m_BossInputs.FindAction("Projectile", throwIfNotFound: true);
        m_BossInputs_Plume = m_BossInputs.FindAction("Plume", throwIfNotFound: true);
        m_BossInputs_Homing = m_BossInputs.FindAction("Homing", throwIfNotFound: true);
        m_BossInputs_Pause = m_BossInputs.FindAction("Pause", throwIfNotFound: true);
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

    // BossInputs
    private readonly InputActionMap m_BossInputs;
    private IBossInputsActions m_BossInputsActionsCallbackInterface;
    private readonly InputAction m_BossInputs_Projectile;
    private readonly InputAction m_BossInputs_Plume;
    private readonly InputAction m_BossInputs_Homing;
    private readonly InputAction m_BossInputs_Pause;
    public struct BossInputsActions
    {
        private @BossControls m_Wrapper;
        public BossInputsActions(@BossControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Projectile => m_Wrapper.m_BossInputs_Projectile;
        public InputAction @Plume => m_Wrapper.m_BossInputs_Plume;
        public InputAction @Homing => m_Wrapper.m_BossInputs_Homing;
        public InputAction @Pause => m_Wrapper.m_BossInputs_Pause;
        public InputActionMap Get() { return m_Wrapper.m_BossInputs; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BossInputsActions set) { return set.Get(); }
        public void SetCallbacks(IBossInputsActions instance)
        {
            if (m_Wrapper.m_BossInputsActionsCallbackInterface != null)
            {
                @Projectile.started -= m_Wrapper.m_BossInputsActionsCallbackInterface.OnProjectile;
                @Projectile.performed -= m_Wrapper.m_BossInputsActionsCallbackInterface.OnProjectile;
                @Projectile.canceled -= m_Wrapper.m_BossInputsActionsCallbackInterface.OnProjectile;
                @Plume.started -= m_Wrapper.m_BossInputsActionsCallbackInterface.OnPlume;
                @Plume.performed -= m_Wrapper.m_BossInputsActionsCallbackInterface.OnPlume;
                @Plume.canceled -= m_Wrapper.m_BossInputsActionsCallbackInterface.OnPlume;
                @Homing.started -= m_Wrapper.m_BossInputsActionsCallbackInterface.OnHoming;
                @Homing.performed -= m_Wrapper.m_BossInputsActionsCallbackInterface.OnHoming;
                @Homing.canceled -= m_Wrapper.m_BossInputsActionsCallbackInterface.OnHoming;
                @Pause.started -= m_Wrapper.m_BossInputsActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_BossInputsActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_BossInputsActionsCallbackInterface.OnPause;
            }
            m_Wrapper.m_BossInputsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Projectile.started += instance.OnProjectile;
                @Projectile.performed += instance.OnProjectile;
                @Projectile.canceled += instance.OnProjectile;
                @Plume.started += instance.OnPlume;
                @Plume.performed += instance.OnPlume;
                @Plume.canceled += instance.OnPlume;
                @Homing.started += instance.OnHoming;
                @Homing.performed += instance.OnHoming;
                @Homing.canceled += instance.OnHoming;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
            }
        }
    }
    public BossInputsActions @BossInputs => new BossInputsActions(this);
    private int m_BossControlsSchemeIndex = -1;
    public InputControlScheme BossControlsScheme
    {
        get
        {
            if (m_BossControlsSchemeIndex == -1) m_BossControlsSchemeIndex = asset.FindControlSchemeIndex("BossControls");
            return asset.controlSchemes[m_BossControlsSchemeIndex];
        }
    }
    public interface IBossInputsActions
    {
        void OnProjectile(InputAction.CallbackContext context);
        void OnPlume(InputAction.CallbackContext context);
        void OnHoming(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
    }
}
