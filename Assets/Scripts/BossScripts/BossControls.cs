// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/BossControls.inputactions'

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
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ce5d4c5a-57bb-4a4a-a021-3170ebd64b25"",
                    ""path"": ""<Keyboard>/space"",
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
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""BossControls"",
                    ""action"": ""Projectile"",
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
    public struct BossInputsActions
    {
        private @BossControls m_Wrapper;
        public BossInputsActions(@BossControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Projectile => m_Wrapper.m_BossInputs_Projectile;
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
            }
            m_Wrapper.m_BossInputsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Projectile.started += instance.OnProjectile;
                @Projectile.performed += instance.OnProjectile;
                @Projectile.canceled += instance.OnProjectile;
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
    }
}
