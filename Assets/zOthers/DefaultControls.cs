//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/zOthers/DefaultControls.inputactions
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

public partial class @DefaultControls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @DefaultControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""DefaultControls"",
    ""maps"": [
        {
            ""name"": ""DesktopControls"",
            ""id"": ""6a65baf1-ab7f-42a7-a2bd-39f1c2fad1ca"",
            ""actions"": [
                {
                    ""name"": ""CurrentMousePosition"",
                    ""type"": ""Value"",
                    ""id"": ""e388e1da-6497-4462-944f-365ba948faac"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""CurrentMousePosDelta"",
                    ""type"": ""Value"",
                    ""id"": ""581938fb-fa90-432d-b565-a476996cad2d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""6dc1da5c-eba4-46f6-b080-d0d22e35d73e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""DirectionalMovement"",
                    ""type"": ""Value"",
                    ""id"": ""e96a699b-15a1-423f-abff-5cbeb9f0f8d7"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Zoom"",
                    ""type"": ""Value"",
                    ""id"": ""0cce4233-2a24-4ee8-ad90-bff6c7d7e482"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""CameraRotation"",
                    ""type"": ""Button"",
                    ""id"": ""6e9f5925-1275-4d8f-b4e3-10818384253b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ResetCamera"",
                    ""type"": ""Button"",
                    ""id"": ""931527c0-d7ea-47ec-a8ab-493198787b37"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""CancelOperation"",
                    ""type"": ""Button"",
                    ""id"": ""ca37f6a8-3413-44a7-9351-42ae5147285f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""697d2744-e325-4250-a055-845aed744091"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CurrentMousePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f3c503d7-5245-486c-9e81-ec383e5b76b1"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CurrentMousePosDelta"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""252ccc37-06b6-4383-9e24-59c770ea2a9d"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""bb334676-bd32-4daa-b34c-fb2c74a6c033"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DirectionalMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""3649a2df-a3c8-4f19-9bc8-4bd6668e589b"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DirectionalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""44ef88a3-5ec9-4003-8611-1ee30cb6908b"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DirectionalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""2b0411c5-91f3-4a93-bb97-3541fd42b4fe"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DirectionalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""3d7e0669-4b4b-44ff-b773-8eb10509bd85"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DirectionalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b2cd3767-e053-4352-9760-fce32ce28258"",
                    ""path"": ""<Mouse>/scroll/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dde1ac4c-640e-4903-9363-dd95bce855c6"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""f838abda-0695-433f-8cad-ca85fcfd606b"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraRotation"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""e619e918-7bc9-4fa1-adc6-1e511eb79615"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""1af8071c-82b7-4488-8afa-c7074693a6ba"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""de59cf4d-1445-43f8-8504-4cf423a09d48"",
                    ""path"": ""<Keyboard>/backquote"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ResetCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""63de1161-6629-417c-8f70-05b967fac6a0"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CancelOperation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // DesktopControls
        m_DesktopControls = asset.FindActionMap("DesktopControls", throwIfNotFound: true);
        m_DesktopControls_CurrentMousePosition = m_DesktopControls.FindAction("CurrentMousePosition", throwIfNotFound: true);
        m_DesktopControls_CurrentMousePosDelta = m_DesktopControls.FindAction("CurrentMousePosDelta", throwIfNotFound: true);
        m_DesktopControls_Interact = m_DesktopControls.FindAction("Interact", throwIfNotFound: true);
        m_DesktopControls_DirectionalMovement = m_DesktopControls.FindAction("DirectionalMovement", throwIfNotFound: true);
        m_DesktopControls_Zoom = m_DesktopControls.FindAction("Zoom", throwIfNotFound: true);
        m_DesktopControls_CameraRotation = m_DesktopControls.FindAction("CameraRotation", throwIfNotFound: true);
        m_DesktopControls_ResetCamera = m_DesktopControls.FindAction("ResetCamera", throwIfNotFound: true);
        m_DesktopControls_CancelOperation = m_DesktopControls.FindAction("CancelOperation", throwIfNotFound: true);
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

    // DesktopControls
    private readonly InputActionMap m_DesktopControls;
    private IDesktopControlsActions m_DesktopControlsActionsCallbackInterface;
    private readonly InputAction m_DesktopControls_CurrentMousePosition;
    private readonly InputAction m_DesktopControls_CurrentMousePosDelta;
    private readonly InputAction m_DesktopControls_Interact;
    private readonly InputAction m_DesktopControls_DirectionalMovement;
    private readonly InputAction m_DesktopControls_Zoom;
    private readonly InputAction m_DesktopControls_CameraRotation;
    private readonly InputAction m_DesktopControls_ResetCamera;
    private readonly InputAction m_DesktopControls_CancelOperation;
    public struct DesktopControlsActions
    {
        private @DefaultControls m_Wrapper;
        public DesktopControlsActions(@DefaultControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @CurrentMousePosition => m_Wrapper.m_DesktopControls_CurrentMousePosition;
        public InputAction @CurrentMousePosDelta => m_Wrapper.m_DesktopControls_CurrentMousePosDelta;
        public InputAction @Interact => m_Wrapper.m_DesktopControls_Interact;
        public InputAction @DirectionalMovement => m_Wrapper.m_DesktopControls_DirectionalMovement;
        public InputAction @Zoom => m_Wrapper.m_DesktopControls_Zoom;
        public InputAction @CameraRotation => m_Wrapper.m_DesktopControls_CameraRotation;
        public InputAction @ResetCamera => m_Wrapper.m_DesktopControls_ResetCamera;
        public InputAction @CancelOperation => m_Wrapper.m_DesktopControls_CancelOperation;
        public InputActionMap Get() { return m_Wrapper.m_DesktopControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DesktopControlsActions set) { return set.Get(); }
        public void SetCallbacks(IDesktopControlsActions instance)
        {
            if (m_Wrapper.m_DesktopControlsActionsCallbackInterface != null)
            {
                @CurrentMousePosition.started -= m_Wrapper.m_DesktopControlsActionsCallbackInterface.OnCurrentMousePosition;
                @CurrentMousePosition.performed -= m_Wrapper.m_DesktopControlsActionsCallbackInterface.OnCurrentMousePosition;
                @CurrentMousePosition.canceled -= m_Wrapper.m_DesktopControlsActionsCallbackInterface.OnCurrentMousePosition;
                @CurrentMousePosDelta.started -= m_Wrapper.m_DesktopControlsActionsCallbackInterface.OnCurrentMousePosDelta;
                @CurrentMousePosDelta.performed -= m_Wrapper.m_DesktopControlsActionsCallbackInterface.OnCurrentMousePosDelta;
                @CurrentMousePosDelta.canceled -= m_Wrapper.m_DesktopControlsActionsCallbackInterface.OnCurrentMousePosDelta;
                @Interact.started -= m_Wrapper.m_DesktopControlsActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_DesktopControlsActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_DesktopControlsActionsCallbackInterface.OnInteract;
                @DirectionalMovement.started -= m_Wrapper.m_DesktopControlsActionsCallbackInterface.OnDirectionalMovement;
                @DirectionalMovement.performed -= m_Wrapper.m_DesktopControlsActionsCallbackInterface.OnDirectionalMovement;
                @DirectionalMovement.canceled -= m_Wrapper.m_DesktopControlsActionsCallbackInterface.OnDirectionalMovement;
                @Zoom.started -= m_Wrapper.m_DesktopControlsActionsCallbackInterface.OnZoom;
                @Zoom.performed -= m_Wrapper.m_DesktopControlsActionsCallbackInterface.OnZoom;
                @Zoom.canceled -= m_Wrapper.m_DesktopControlsActionsCallbackInterface.OnZoom;
                @CameraRotation.started -= m_Wrapper.m_DesktopControlsActionsCallbackInterface.OnCameraRotation;
                @CameraRotation.performed -= m_Wrapper.m_DesktopControlsActionsCallbackInterface.OnCameraRotation;
                @CameraRotation.canceled -= m_Wrapper.m_DesktopControlsActionsCallbackInterface.OnCameraRotation;
                @ResetCamera.started -= m_Wrapper.m_DesktopControlsActionsCallbackInterface.OnResetCamera;
                @ResetCamera.performed -= m_Wrapper.m_DesktopControlsActionsCallbackInterface.OnResetCamera;
                @ResetCamera.canceled -= m_Wrapper.m_DesktopControlsActionsCallbackInterface.OnResetCamera;
                @CancelOperation.started -= m_Wrapper.m_DesktopControlsActionsCallbackInterface.OnCancelOperation;
                @CancelOperation.performed -= m_Wrapper.m_DesktopControlsActionsCallbackInterface.OnCancelOperation;
                @CancelOperation.canceled -= m_Wrapper.m_DesktopControlsActionsCallbackInterface.OnCancelOperation;
            }
            m_Wrapper.m_DesktopControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @CurrentMousePosition.started += instance.OnCurrentMousePosition;
                @CurrentMousePosition.performed += instance.OnCurrentMousePosition;
                @CurrentMousePosition.canceled += instance.OnCurrentMousePosition;
                @CurrentMousePosDelta.started += instance.OnCurrentMousePosDelta;
                @CurrentMousePosDelta.performed += instance.OnCurrentMousePosDelta;
                @CurrentMousePosDelta.canceled += instance.OnCurrentMousePosDelta;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @DirectionalMovement.started += instance.OnDirectionalMovement;
                @DirectionalMovement.performed += instance.OnDirectionalMovement;
                @DirectionalMovement.canceled += instance.OnDirectionalMovement;
                @Zoom.started += instance.OnZoom;
                @Zoom.performed += instance.OnZoom;
                @Zoom.canceled += instance.OnZoom;
                @CameraRotation.started += instance.OnCameraRotation;
                @CameraRotation.performed += instance.OnCameraRotation;
                @CameraRotation.canceled += instance.OnCameraRotation;
                @ResetCamera.started += instance.OnResetCamera;
                @ResetCamera.performed += instance.OnResetCamera;
                @ResetCamera.canceled += instance.OnResetCamera;
                @CancelOperation.started += instance.OnCancelOperation;
                @CancelOperation.performed += instance.OnCancelOperation;
                @CancelOperation.canceled += instance.OnCancelOperation;
            }
        }
    }
    public DesktopControlsActions @DesktopControls => new DesktopControlsActions(this);
    public interface IDesktopControlsActions
    {
        void OnCurrentMousePosition(InputAction.CallbackContext context);
        void OnCurrentMousePosDelta(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnDirectionalMovement(InputAction.CallbackContext context);
        void OnZoom(InputAction.CallbackContext context);
        void OnCameraRotation(InputAction.CallbackContext context);
        void OnResetCamera(InputAction.CallbackContext context);
        void OnCancelOperation(InputAction.CallbackContext context);
    }
}
