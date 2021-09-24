// GENERATED AUTOMATICALLY FROM 'Assets/Boat/BoatInputs.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @BoatInputs : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @BoatInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""BoatInputs"",
    ""maps"": [
        {
            ""name"": ""CombinedEngineControls"",
            ""id"": ""8d5ee7f2-6fd2-4aa4-81a6-72b0283ba304"",
            ""actions"": [
                {
                    ""name"": ""EnginePowerUp"",
                    ""type"": ""Button"",
                    ""id"": ""86f5f275-cc8f-4e0f-a184-7398ff2c8dd1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""EnginePowerUpStop"",
                    ""type"": ""Button"",
                    ""id"": ""6cfe3720-a762-4eff-941e-a9dcbb6904eb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                },
                {
                    ""name"": ""EnginePowerDown"",
                    ""type"": ""Button"",
                    ""id"": ""2293b551-adf9-4ed8-be4c-c8c06a45c5ed"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""EnginePowerDownStop"",
                    ""type"": ""Button"",
                    ""id"": ""d7bed249-7363-4b50-b2d6-b81ff6ba2de4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                },
                {
                    ""name"": ""RotateLeft"",
                    ""type"": ""Button"",
                    ""id"": ""3940e206-ec91-40ed-a054-ff68d981d9f5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""RotateLeftStop"",
                    ""type"": ""Button"",
                    ""id"": ""b1f1e4ce-9086-42d9-9d20-83938ef65f23"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                },
                {
                    ""name"": ""RotateRight"",
                    ""type"": ""Button"",
                    ""id"": ""f5bed8e3-18f8-4432-9b30-c87c4bdb712d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""RotateRightStop"",
                    ""type"": ""Button"",
                    ""id"": ""6099e131-eb42-4faa-8154-fb9e89493a9a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                },
                {
                    ""name"": ""ChangeCam"",
                    ""type"": ""Button"",
                    ""id"": ""02506bed-a711-4c73-9c08-c3f997aea0cc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CameraZoom"",
                    ""type"": ""Value"",
                    ""id"": ""200bbae1-66a2-433c-94f9-ba084459bbd2"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Stop"",
                    ""type"": ""Button"",
                    ""id"": ""017bfb89-4e63-42b1-9dc1-34c3631bbdce"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ChangeControlType"",
                    ""type"": ""Button"",
                    ""id"": ""e80ea82a-b4bf-404e-b028-55b3e1b338e8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""InduvidualControlsSwitch"",
                    ""type"": ""Button"",
                    ""id"": ""a24f350d-41c9-450e-baaa-b3d3dc79839f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""063226b2-8e62-4dbd-88ce-2eef42bdc665"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""EnginePowerUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""953d0e3e-1147-4969-a1ee-baad0bcba733"",
                    ""path"": ""<Joystick>/stick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""EnginePowerUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0ba4acbf-9a70-4bf6-9a84-02af40fd5445"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""EnginePowerUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""10a68f61-e154-448a-a26b-ffcbb954f150"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""EnginePowerUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f0b36be6-3bce-4e88-8ca7-4056ac3e2f00"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""EnginePowerDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1790b6b6-12e3-44a1-9a19-fd8e97897d34"",
                    ""path"": ""<Joystick>/stick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""EnginePowerDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2fcef4f4-f246-4e1d-96f7-10f582909c31"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""EnginePowerDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6fd5d940-9b2d-4b8d-9d41-6e4e6755ba86"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4f05bc2c-1b0b-41f0-bebb-8c6694721f7f"",
                    ""path"": ""<Joystick>/stick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""RotateLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4909164f-8e32-41d7-8c10-9f72f9483c8f"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""RotateLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3c6c6e9c-cb6f-4cbf-b6e6-1f914e30c954"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cfc60b93-4d9e-4839-9d0c-e13c4ab39a4f"",
                    ""path"": ""<Joystick>/stick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""RotateRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d90b3b21-38af-4595-8620-d39097d11c41"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""RotateRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""36be46ff-0e3f-4883-aca8-f327aee526e6"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraZoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""78a0820f-5ff0-4fbf-ac15-1d16429aa846"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeCam"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0f4636dd-2c84-44e3-81da-887739a54b65"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""EnginePowerUpStop"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""92a8ac12-d7c6-429f-8cfc-cc5026c66100"",
                    ""path"": ""<Joystick>/stick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""EnginePowerUpStop"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e8492eda-5f89-46ac-915b-7c11c5ed155a"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""EnginePowerDownStop"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""210a6f45-f3b0-4892-8165-7bd55fecc5cf"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateRightStop"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5e09c615-43eb-45e8-a709-52c85c6c1a9a"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Stop"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a03f0fe8-eab4-4d1e-aad5-775476ec10fb"",
                    ""path"": ""<Keyboard>/b"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeControlType"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d548f1f5-3b9c-4cf3-bf52-6d1819613579"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateLeftStop"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ce9b07ac-2a2e-4e2a-bf6b-edefbe0660a0"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InduvidualControlsSwitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""0324255d-7d39-4feb-bded-4509ccfd16d6"",
            ""actions"": [
                {
                    ""name"": ""Navigate"",
                    ""type"": ""Value"",
                    ""id"": ""62a8d50f-f9f5-4910-8e47-3535dd6b4674"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Submit"",
                    ""type"": ""Button"",
                    ""id"": ""0acb4a33-3307-4227-8e29-4f9f388ced15"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""091ab69f-c4cc-4405-ade8-e373017ac90e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Point"",
                    ""type"": ""PassThrough"",
                    ""id"": ""5cf2d2cc-2430-44da-b88d-728cb064e086"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Click"",
                    ""type"": ""PassThrough"",
                    ""id"": ""5c4f1b0f-2bb7-4941-af72-01d0e0be9e93"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ScrollWheel"",
                    ""type"": ""PassThrough"",
                    ""id"": ""b4c9dbed-1031-49ad-a7ab-3a6c95cdc8fc"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MiddleClick"",
                    ""type"": ""PassThrough"",
                    ""id"": ""f0972415-defa-4ee0-9707-bb6bc5d6401d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightClick"",
                    ""type"": ""PassThrough"",
                    ""id"": ""04d8e5df-0f61-4b81-a9da-fcb4db63ac26"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TrackedDevicePosition"",
                    ""type"": ""PassThrough"",
                    ""id"": ""34082a1e-c18d-414e-830a-fb9bf6c8c2e9"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TrackedDeviceOrientation"",
                    ""type"": ""PassThrough"",
                    ""id"": ""241bfbf1-69b2-45c1-9550-f996fb49a8bd"",
                    ""expectedControlType"": ""Quaternion"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""809f371f-c5e2-4e7a-83a1-d867598f40dd"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""14a5d6e8-4aaf-4119-a9ef-34b8c2c548bf"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""9144cbe6-05e1-4687-a6d7-24f99d23dd81"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""2db08d65-c5fb-421b-983f-c71163608d67"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""58748904-2ea9-4a80-8579-b500e6a76df8"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8ba04515-75aa-45de-966d-393d9bbd1c14"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""712e721c-bdfb-4b23-a86c-a0d9fcfea921"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""fcd248ae-a788-4676-a12e-f4d81205600b"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""1f04d9bc-c50b-41a1-bfcc-afb75475ec20"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""fb8277d4-c5cd-4663-9dc7-ee3f0b506d90"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Joystick"",
                    ""id"": ""e25d9774-381c-4a61-b47c-7b6b299ad9f9"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""3db53b26-6601-41be-9887-63ac74e79d19"",
                    ""path"": ""<Joystick>/stick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""0cb3e13e-3d90-4178-8ae6-d9c5501d653f"",
                    ""path"": ""<Joystick>/stick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""0392d399-f6dd-4c82-8062-c1e9c0d34835"",
                    ""path"": ""<Joystick>/stick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""942a66d9-d42f-43d6-8d70-ecb4ba5363bc"",
                    ""path"": ""<Joystick>/stick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""ff527021-f211-4c02-933e-5976594c46ed"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""563fbfdd-0f09-408d-aa75-8642c4f08ef0"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""eb480147-c587-4a33-85ed-eb0ab9942c43"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""2bf42165-60bc-42ca-8072-8c13ab40239b"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""85d264ad-e0a0-4565-b7ff-1a37edde51ac"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""74214943-c580-44e4-98eb-ad7eebe17902"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""cea9b045-a000-445b-95b8-0c171af70a3b"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""8607c725-d935-4808-84b1-8354e29bab63"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""4cda81dc-9edd-4e03-9d7c-a71a14345d0b"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""9e92bb26-7e3b-4ec4-b06b-3c8f8e498ddc"",
                    ""path"": ""*/{Submit}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""82627dcc-3b13-4ba9-841d-e4b746d6553e"",
                    ""path"": ""*/{Cancel}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c52c8e0b-8179-41d3-b8a1-d149033bbe86"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e1394cbc-336e-44ce-9ea8-6007ed6193f7"",
                    ""path"": ""<Pen>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5693e57a-238a-46ed-b5ae-e64e6e574302"",
                    ""path"": ""<Touchscreen>/touch*/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touch"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4faf7dc9-b979-4210-aa8c-e808e1ef89f5"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8d66d5ba-88d7-48e6-b1cd-198bbfef7ace"",
                    ""path"": ""<Pen>/tip"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""47c2a644-3ebc-4dae-a106-589b7ca75b59"",
                    ""path"": ""<Touchscreen>/touch*/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touch"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bb9e6b34-44bf-4381-ac63-5aa15d19f677"",
                    ""path"": ""<XRController>/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""38c99815-14ea-4617-8627-164d27641299"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""ScrollWheel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""24066f69-da47-44f3-a07e-0015fb02eb2e"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""MiddleClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4c191405-5738-4d4b-a523-c6a301dbf754"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""RightClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7236c0d9-6ca3-47cf-a6ee-a97f5b59ea77"",
                    ""path"": ""<XRController>/devicePosition"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""TrackedDevicePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""23e01e3a-f935-4948-8d8b-9bcac77714fb"",
                    ""path"": ""<XRController>/deviceRotation"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""TrackedDeviceOrientation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""BerthingControls"",
            ""id"": ""502cdd64-dbd8-46f1-8dea-8a206372df35"",
            ""actions"": [
                {
                    ""name"": ""Forwards"",
                    ""type"": ""Button"",
                    ""id"": ""67fded94-4abf-47e9-b0f9-cee73aa44a84"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""ForwardsStop"",
                    ""type"": ""Button"",
                    ""id"": ""17cf3a60-827e-40cf-b25e-4bd511623e1a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                },
                {
                    ""name"": ""Backwards"",
                    ""type"": ""Button"",
                    ""id"": ""828cc383-fd4d-4885-a03d-e594ef697b9c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""BackwardsStop"",
                    ""type"": ""Button"",
                    ""id"": ""79447fb0-49b1-4eee-bc80-00c3946a265e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                },
                {
                    ""name"": ""Leftways"",
                    ""type"": ""Button"",
                    ""id"": ""9c416ebd-05e5-441d-a162-81535dd65ac9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""LeftwaysStop"",
                    ""type"": ""Button"",
                    ""id"": ""5778af3b-93d0-49df-bceb-7aecba42054e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                },
                {
                    ""name"": ""Rightways"",
                    ""type"": ""Button"",
                    ""id"": ""d2f18432-745b-460d-acde-aa62f9303b44"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""RightwaysStop"",
                    ""type"": ""Button"",
                    ""id"": ""4a0189f0-3e09-42dd-86ae-e61ded8f2182"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                },
                {
                    ""name"": ""ChangeControlTypes"",
                    ""type"": ""Button"",
                    ""id"": ""5ca6acc5-5ef9-4f69-8399-a1e5b445c12c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""49bc103e-98aa-48c9-adf9-5d7d765be5f5"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightwaysStop"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d9c49382-1e5a-4c14-b966-a65d9d0daaf4"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Forwards"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1ecd0871-7d82-41b5-8913-de7c86f13087"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ForwardsStop"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""803d4be8-e71d-4d76-8f52-6043499461c5"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Backwards"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""244c7434-b8a1-420c-9aba-88a589162a82"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BackwardsStop"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d5e0101a-f84c-4634-82a3-0794c3a029e9"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Leftways"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""feef495e-efe8-40ba-bbe2-e759a9cf87aa"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftwaysStop"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""410feb5b-6749-4e0e-b54f-b8e50be91e65"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rightways"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ede69635-c0e6-40fc-8618-9615d2f43574"",
                    ""path"": ""<Keyboard>/b"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeControlTypes"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""InduvidualEngineControls"",
            ""id"": ""ffcc0f40-3f5c-48a2-8f46-5a2b223f7707"",
            ""actions"": [
                {
                    ""name"": ""LeftForwards"",
                    ""type"": ""Button"",
                    ""id"": ""f3e0aefb-4ae2-4608-83fc-a64e95dc2de7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""LeftForwardsStop"",
                    ""type"": ""Button"",
                    ""id"": ""2ea503a3-ab10-457a-ad67-f9cd9c1555f3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                },
                {
                    ""name"": ""LeftBackwards"",
                    ""type"": ""Button"",
                    ""id"": ""c778f33d-dde2-4a1f-8044-2325a1ca76e7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""LeftBackwardsStop"",
                    ""type"": ""Button"",
                    ""id"": ""ea9a14d7-6529-4bc5-baf9-5f3e2cb5cd09"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                },
                {
                    ""name"": ""RightForwards"",
                    ""type"": ""Button"",
                    ""id"": ""d345575c-59c2-4eda-80c7-9665ba5df4c2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""RightForwardsStop"",
                    ""type"": ""Button"",
                    ""id"": ""2cebdee6-031a-496a-8be8-00c76892e5d6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                },
                {
                    ""name"": ""RightBackwards"",
                    ""type"": ""Button"",
                    ""id"": ""c1d059cc-b8dd-464b-afe7-3dee5870111b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""RightBackwardsStop"",
                    ""type"": ""Button"",
                    ""id"": ""017c5639-b2be-468d-adbb-83756dd77a40"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                },
                {
                    ""name"": ""CombinedControlsSwitch"",
                    ""type"": ""Button"",
                    ""id"": ""4883701c-cc3c-4cc3-b610-9263218bd547"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b421b155-b3ec-4e48-aade-99d1bc7e86e6"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftForwards"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ff3753d0-c990-4771-8ee7-c80494a608f3"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftForwardsStop"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""60929a30-bb89-4a7d-a489-847d696c85b6"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftBackwards"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""168ae1ef-2cd0-4bc2-bbeb-0f0c0f4e18e0"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftBackwardsStop"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1178e19f-a9b4-4183-8a24-07ec3f2ed4d2"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightBackwardsStop"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8d3cd40e-ad2c-4652-ae86-4fed081be784"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CombinedControlsSwitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""deafdf5b-6dad-4aef-9c71-d451ea590ffe"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightForwards"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""408554f2-673e-41c9-9f3d-04ca26b9085f"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightForwardsStop"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""727cd145-3bc3-4e34-a2fe-a219997179c3"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightBackwards"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard&Mouse"",
            ""bindingGroup"": ""Keyboard&Mouse"",
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
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Touch"",
            ""bindingGroup"": ""Touch"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Joystick"",
            ""bindingGroup"": ""Joystick"",
            ""devices"": [
                {
                    ""devicePath"": ""<Joystick>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""XR"",
            ""bindingGroup"": ""XR"",
            ""devices"": [
                {
                    ""devicePath"": ""<XRController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // CombinedEngineControls
        m_CombinedEngineControls = asset.FindActionMap("CombinedEngineControls", throwIfNotFound: true);
        m_CombinedEngineControls_EnginePowerUp = m_CombinedEngineControls.FindAction("EnginePowerUp", throwIfNotFound: true);
        m_CombinedEngineControls_EnginePowerUpStop = m_CombinedEngineControls.FindAction("EnginePowerUpStop", throwIfNotFound: true);
        m_CombinedEngineControls_EnginePowerDown = m_CombinedEngineControls.FindAction("EnginePowerDown", throwIfNotFound: true);
        m_CombinedEngineControls_EnginePowerDownStop = m_CombinedEngineControls.FindAction("EnginePowerDownStop", throwIfNotFound: true);
        m_CombinedEngineControls_RotateLeft = m_CombinedEngineControls.FindAction("RotateLeft", throwIfNotFound: true);
        m_CombinedEngineControls_RotateLeftStop = m_CombinedEngineControls.FindAction("RotateLeftStop", throwIfNotFound: true);
        m_CombinedEngineControls_RotateRight = m_CombinedEngineControls.FindAction("RotateRight", throwIfNotFound: true);
        m_CombinedEngineControls_RotateRightStop = m_CombinedEngineControls.FindAction("RotateRightStop", throwIfNotFound: true);
        m_CombinedEngineControls_ChangeCam = m_CombinedEngineControls.FindAction("ChangeCam", throwIfNotFound: true);
        m_CombinedEngineControls_CameraZoom = m_CombinedEngineControls.FindAction("CameraZoom", throwIfNotFound: true);
        m_CombinedEngineControls_Stop = m_CombinedEngineControls.FindAction("Stop", throwIfNotFound: true);
        m_CombinedEngineControls_ChangeControlType = m_CombinedEngineControls.FindAction("ChangeControlType", throwIfNotFound: true);
        m_CombinedEngineControls_InduvidualControlsSwitch = m_CombinedEngineControls.FindAction("InduvidualControlsSwitch", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_Navigate = m_UI.FindAction("Navigate", throwIfNotFound: true);
        m_UI_Submit = m_UI.FindAction("Submit", throwIfNotFound: true);
        m_UI_Cancel = m_UI.FindAction("Cancel", throwIfNotFound: true);
        m_UI_Point = m_UI.FindAction("Point", throwIfNotFound: true);
        m_UI_Click = m_UI.FindAction("Click", throwIfNotFound: true);
        m_UI_ScrollWheel = m_UI.FindAction("ScrollWheel", throwIfNotFound: true);
        m_UI_MiddleClick = m_UI.FindAction("MiddleClick", throwIfNotFound: true);
        m_UI_RightClick = m_UI.FindAction("RightClick", throwIfNotFound: true);
        m_UI_TrackedDevicePosition = m_UI.FindAction("TrackedDevicePosition", throwIfNotFound: true);
        m_UI_TrackedDeviceOrientation = m_UI.FindAction("TrackedDeviceOrientation", throwIfNotFound: true);
        // BerthingControls
        m_BerthingControls = asset.FindActionMap("BerthingControls", throwIfNotFound: true);
        m_BerthingControls_Forwards = m_BerthingControls.FindAction("Forwards", throwIfNotFound: true);
        m_BerthingControls_ForwardsStop = m_BerthingControls.FindAction("ForwardsStop", throwIfNotFound: true);
        m_BerthingControls_Backwards = m_BerthingControls.FindAction("Backwards", throwIfNotFound: true);
        m_BerthingControls_BackwardsStop = m_BerthingControls.FindAction("BackwardsStop", throwIfNotFound: true);
        m_BerthingControls_Leftways = m_BerthingControls.FindAction("Leftways", throwIfNotFound: true);
        m_BerthingControls_LeftwaysStop = m_BerthingControls.FindAction("LeftwaysStop", throwIfNotFound: true);
        m_BerthingControls_Rightways = m_BerthingControls.FindAction("Rightways", throwIfNotFound: true);
        m_BerthingControls_RightwaysStop = m_BerthingControls.FindAction("RightwaysStop", throwIfNotFound: true);
        m_BerthingControls_ChangeControlTypes = m_BerthingControls.FindAction("ChangeControlTypes", throwIfNotFound: true);
        // InduvidualEngineControls
        m_InduvidualEngineControls = asset.FindActionMap("InduvidualEngineControls", throwIfNotFound: true);
        m_InduvidualEngineControls_LeftForwards = m_InduvidualEngineControls.FindAction("LeftForwards", throwIfNotFound: true);
        m_InduvidualEngineControls_LeftForwardsStop = m_InduvidualEngineControls.FindAction("LeftForwardsStop", throwIfNotFound: true);
        m_InduvidualEngineControls_LeftBackwards = m_InduvidualEngineControls.FindAction("LeftBackwards", throwIfNotFound: true);
        m_InduvidualEngineControls_LeftBackwardsStop = m_InduvidualEngineControls.FindAction("LeftBackwardsStop", throwIfNotFound: true);
        m_InduvidualEngineControls_RightForwards = m_InduvidualEngineControls.FindAction("RightForwards", throwIfNotFound: true);
        m_InduvidualEngineControls_RightForwardsStop = m_InduvidualEngineControls.FindAction("RightForwardsStop", throwIfNotFound: true);
        m_InduvidualEngineControls_RightBackwards = m_InduvidualEngineControls.FindAction("RightBackwards", throwIfNotFound: true);
        m_InduvidualEngineControls_RightBackwardsStop = m_InduvidualEngineControls.FindAction("RightBackwardsStop", throwIfNotFound: true);
        m_InduvidualEngineControls_CombinedControlsSwitch = m_InduvidualEngineControls.FindAction("CombinedControlsSwitch", throwIfNotFound: true);
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

    // CombinedEngineControls
    private readonly InputActionMap m_CombinedEngineControls;
    private ICombinedEngineControlsActions m_CombinedEngineControlsActionsCallbackInterface;
    private readonly InputAction m_CombinedEngineControls_EnginePowerUp;
    private readonly InputAction m_CombinedEngineControls_EnginePowerUpStop;
    private readonly InputAction m_CombinedEngineControls_EnginePowerDown;
    private readonly InputAction m_CombinedEngineControls_EnginePowerDownStop;
    private readonly InputAction m_CombinedEngineControls_RotateLeft;
    private readonly InputAction m_CombinedEngineControls_RotateLeftStop;
    private readonly InputAction m_CombinedEngineControls_RotateRight;
    private readonly InputAction m_CombinedEngineControls_RotateRightStop;
    private readonly InputAction m_CombinedEngineControls_ChangeCam;
    private readonly InputAction m_CombinedEngineControls_CameraZoom;
    private readonly InputAction m_CombinedEngineControls_Stop;
    private readonly InputAction m_CombinedEngineControls_ChangeControlType;
    private readonly InputAction m_CombinedEngineControls_InduvidualControlsSwitch;
    public struct CombinedEngineControlsActions
    {
        private @BoatInputs m_Wrapper;
        public CombinedEngineControlsActions(@BoatInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @EnginePowerUp => m_Wrapper.m_CombinedEngineControls_EnginePowerUp;
        public InputAction @EnginePowerUpStop => m_Wrapper.m_CombinedEngineControls_EnginePowerUpStop;
        public InputAction @EnginePowerDown => m_Wrapper.m_CombinedEngineControls_EnginePowerDown;
        public InputAction @EnginePowerDownStop => m_Wrapper.m_CombinedEngineControls_EnginePowerDownStop;
        public InputAction @RotateLeft => m_Wrapper.m_CombinedEngineControls_RotateLeft;
        public InputAction @RotateLeftStop => m_Wrapper.m_CombinedEngineControls_RotateLeftStop;
        public InputAction @RotateRight => m_Wrapper.m_CombinedEngineControls_RotateRight;
        public InputAction @RotateRightStop => m_Wrapper.m_CombinedEngineControls_RotateRightStop;
        public InputAction @ChangeCam => m_Wrapper.m_CombinedEngineControls_ChangeCam;
        public InputAction @CameraZoom => m_Wrapper.m_CombinedEngineControls_CameraZoom;
        public InputAction @Stop => m_Wrapper.m_CombinedEngineControls_Stop;
        public InputAction @ChangeControlType => m_Wrapper.m_CombinedEngineControls_ChangeControlType;
        public InputAction @InduvidualControlsSwitch => m_Wrapper.m_CombinedEngineControls_InduvidualControlsSwitch;
        public InputActionMap Get() { return m_Wrapper.m_CombinedEngineControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CombinedEngineControlsActions set) { return set.Get(); }
        public void SetCallbacks(ICombinedEngineControlsActions instance)
        {
            if (m_Wrapper.m_CombinedEngineControlsActionsCallbackInterface != null)
            {
                @EnginePowerUp.started -= m_Wrapper.m_CombinedEngineControlsActionsCallbackInterface.OnEnginePowerUp;
                @EnginePowerUp.performed -= m_Wrapper.m_CombinedEngineControlsActionsCallbackInterface.OnEnginePowerUp;
                @EnginePowerUp.canceled -= m_Wrapper.m_CombinedEngineControlsActionsCallbackInterface.OnEnginePowerUp;
                @EnginePowerUpStop.started -= m_Wrapper.m_CombinedEngineControlsActionsCallbackInterface.OnEnginePowerUpStop;
                @EnginePowerUpStop.performed -= m_Wrapper.m_CombinedEngineControlsActionsCallbackInterface.OnEnginePowerUpStop;
                @EnginePowerUpStop.canceled -= m_Wrapper.m_CombinedEngineControlsActionsCallbackInterface.OnEnginePowerUpStop;
                @EnginePowerDown.started -= m_Wrapper.m_CombinedEngineControlsActionsCallbackInterface.OnEnginePowerDown;
                @EnginePowerDown.performed -= m_Wrapper.m_CombinedEngineControlsActionsCallbackInterface.OnEnginePowerDown;
                @EnginePowerDown.canceled -= m_Wrapper.m_CombinedEngineControlsActionsCallbackInterface.OnEnginePowerDown;
                @EnginePowerDownStop.started -= m_Wrapper.m_CombinedEngineControlsActionsCallbackInterface.OnEnginePowerDownStop;
                @EnginePowerDownStop.performed -= m_Wrapper.m_CombinedEngineControlsActionsCallbackInterface.OnEnginePowerDownStop;
                @EnginePowerDownStop.canceled -= m_Wrapper.m_CombinedEngineControlsActionsCallbackInterface.OnEnginePowerDownStop;
                @RotateLeft.started -= m_Wrapper.m_CombinedEngineControlsActionsCallbackInterface.OnRotateLeft;
                @RotateLeft.performed -= m_Wrapper.m_CombinedEngineControlsActionsCallbackInterface.OnRotateLeft;
                @RotateLeft.canceled -= m_Wrapper.m_CombinedEngineControlsActionsCallbackInterface.OnRotateLeft;
                @RotateLeftStop.started -= m_Wrapper.m_CombinedEngineControlsActionsCallbackInterface.OnRotateLeftStop;
                @RotateLeftStop.performed -= m_Wrapper.m_CombinedEngineControlsActionsCallbackInterface.OnRotateLeftStop;
                @RotateLeftStop.canceled -= m_Wrapper.m_CombinedEngineControlsActionsCallbackInterface.OnRotateLeftStop;
                @RotateRight.started -= m_Wrapper.m_CombinedEngineControlsActionsCallbackInterface.OnRotateRight;
                @RotateRight.performed -= m_Wrapper.m_CombinedEngineControlsActionsCallbackInterface.OnRotateRight;
                @RotateRight.canceled -= m_Wrapper.m_CombinedEngineControlsActionsCallbackInterface.OnRotateRight;
                @RotateRightStop.started -= m_Wrapper.m_CombinedEngineControlsActionsCallbackInterface.OnRotateRightStop;
                @RotateRightStop.performed -= m_Wrapper.m_CombinedEngineControlsActionsCallbackInterface.OnRotateRightStop;
                @RotateRightStop.canceled -= m_Wrapper.m_CombinedEngineControlsActionsCallbackInterface.OnRotateRightStop;
                @ChangeCam.started -= m_Wrapper.m_CombinedEngineControlsActionsCallbackInterface.OnChangeCam;
                @ChangeCam.performed -= m_Wrapper.m_CombinedEngineControlsActionsCallbackInterface.OnChangeCam;
                @ChangeCam.canceled -= m_Wrapper.m_CombinedEngineControlsActionsCallbackInterface.OnChangeCam;
                @CameraZoom.started -= m_Wrapper.m_CombinedEngineControlsActionsCallbackInterface.OnCameraZoom;
                @CameraZoom.performed -= m_Wrapper.m_CombinedEngineControlsActionsCallbackInterface.OnCameraZoom;
                @CameraZoom.canceled -= m_Wrapper.m_CombinedEngineControlsActionsCallbackInterface.OnCameraZoom;
                @Stop.started -= m_Wrapper.m_CombinedEngineControlsActionsCallbackInterface.OnStop;
                @Stop.performed -= m_Wrapper.m_CombinedEngineControlsActionsCallbackInterface.OnStop;
                @Stop.canceled -= m_Wrapper.m_CombinedEngineControlsActionsCallbackInterface.OnStop;
                @ChangeControlType.started -= m_Wrapper.m_CombinedEngineControlsActionsCallbackInterface.OnChangeControlType;
                @ChangeControlType.performed -= m_Wrapper.m_CombinedEngineControlsActionsCallbackInterface.OnChangeControlType;
                @ChangeControlType.canceled -= m_Wrapper.m_CombinedEngineControlsActionsCallbackInterface.OnChangeControlType;
                @InduvidualControlsSwitch.started -= m_Wrapper.m_CombinedEngineControlsActionsCallbackInterface.OnInduvidualControlsSwitch;
                @InduvidualControlsSwitch.performed -= m_Wrapper.m_CombinedEngineControlsActionsCallbackInterface.OnInduvidualControlsSwitch;
                @InduvidualControlsSwitch.canceled -= m_Wrapper.m_CombinedEngineControlsActionsCallbackInterface.OnInduvidualControlsSwitch;
            }
            m_Wrapper.m_CombinedEngineControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @EnginePowerUp.started += instance.OnEnginePowerUp;
                @EnginePowerUp.performed += instance.OnEnginePowerUp;
                @EnginePowerUp.canceled += instance.OnEnginePowerUp;
                @EnginePowerUpStop.started += instance.OnEnginePowerUpStop;
                @EnginePowerUpStop.performed += instance.OnEnginePowerUpStop;
                @EnginePowerUpStop.canceled += instance.OnEnginePowerUpStop;
                @EnginePowerDown.started += instance.OnEnginePowerDown;
                @EnginePowerDown.performed += instance.OnEnginePowerDown;
                @EnginePowerDown.canceled += instance.OnEnginePowerDown;
                @EnginePowerDownStop.started += instance.OnEnginePowerDownStop;
                @EnginePowerDownStop.performed += instance.OnEnginePowerDownStop;
                @EnginePowerDownStop.canceled += instance.OnEnginePowerDownStop;
                @RotateLeft.started += instance.OnRotateLeft;
                @RotateLeft.performed += instance.OnRotateLeft;
                @RotateLeft.canceled += instance.OnRotateLeft;
                @RotateLeftStop.started += instance.OnRotateLeftStop;
                @RotateLeftStop.performed += instance.OnRotateLeftStop;
                @RotateLeftStop.canceled += instance.OnRotateLeftStop;
                @RotateRight.started += instance.OnRotateRight;
                @RotateRight.performed += instance.OnRotateRight;
                @RotateRight.canceled += instance.OnRotateRight;
                @RotateRightStop.started += instance.OnRotateRightStop;
                @RotateRightStop.performed += instance.OnRotateRightStop;
                @RotateRightStop.canceled += instance.OnRotateRightStop;
                @ChangeCam.started += instance.OnChangeCam;
                @ChangeCam.performed += instance.OnChangeCam;
                @ChangeCam.canceled += instance.OnChangeCam;
                @CameraZoom.started += instance.OnCameraZoom;
                @CameraZoom.performed += instance.OnCameraZoom;
                @CameraZoom.canceled += instance.OnCameraZoom;
                @Stop.started += instance.OnStop;
                @Stop.performed += instance.OnStop;
                @Stop.canceled += instance.OnStop;
                @ChangeControlType.started += instance.OnChangeControlType;
                @ChangeControlType.performed += instance.OnChangeControlType;
                @ChangeControlType.canceled += instance.OnChangeControlType;
                @InduvidualControlsSwitch.started += instance.OnInduvidualControlsSwitch;
                @InduvidualControlsSwitch.performed += instance.OnInduvidualControlsSwitch;
                @InduvidualControlsSwitch.canceled += instance.OnInduvidualControlsSwitch;
            }
        }
    }
    public CombinedEngineControlsActions @CombinedEngineControls => new CombinedEngineControlsActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_Navigate;
    private readonly InputAction m_UI_Submit;
    private readonly InputAction m_UI_Cancel;
    private readonly InputAction m_UI_Point;
    private readonly InputAction m_UI_Click;
    private readonly InputAction m_UI_ScrollWheel;
    private readonly InputAction m_UI_MiddleClick;
    private readonly InputAction m_UI_RightClick;
    private readonly InputAction m_UI_TrackedDevicePosition;
    private readonly InputAction m_UI_TrackedDeviceOrientation;
    public struct UIActions
    {
        private @BoatInputs m_Wrapper;
        public UIActions(@BoatInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Navigate => m_Wrapper.m_UI_Navigate;
        public InputAction @Submit => m_Wrapper.m_UI_Submit;
        public InputAction @Cancel => m_Wrapper.m_UI_Cancel;
        public InputAction @Point => m_Wrapper.m_UI_Point;
        public InputAction @Click => m_Wrapper.m_UI_Click;
        public InputAction @ScrollWheel => m_Wrapper.m_UI_ScrollWheel;
        public InputAction @MiddleClick => m_Wrapper.m_UI_MiddleClick;
        public InputAction @RightClick => m_Wrapper.m_UI_RightClick;
        public InputAction @TrackedDevicePosition => m_Wrapper.m_UI_TrackedDevicePosition;
        public InputAction @TrackedDeviceOrientation => m_Wrapper.m_UI_TrackedDeviceOrientation;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @Navigate.started -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigate;
                @Navigate.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigate;
                @Navigate.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigate;
                @Submit.started -= m_Wrapper.m_UIActionsCallbackInterface.OnSubmit;
                @Submit.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnSubmit;
                @Submit.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnSubmit;
                @Cancel.started -= m_Wrapper.m_UIActionsCallbackInterface.OnCancel;
                @Cancel.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnCancel;
                @Cancel.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnCancel;
                @Point.started -= m_Wrapper.m_UIActionsCallbackInterface.OnPoint;
                @Point.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnPoint;
                @Point.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnPoint;
                @Click.started -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
                @Click.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
                @Click.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
                @ScrollWheel.started -= m_Wrapper.m_UIActionsCallbackInterface.OnScrollWheel;
                @ScrollWheel.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnScrollWheel;
                @ScrollWheel.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnScrollWheel;
                @MiddleClick.started -= m_Wrapper.m_UIActionsCallbackInterface.OnMiddleClick;
                @MiddleClick.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnMiddleClick;
                @MiddleClick.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnMiddleClick;
                @RightClick.started -= m_Wrapper.m_UIActionsCallbackInterface.OnRightClick;
                @RightClick.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnRightClick;
                @RightClick.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnRightClick;
                @TrackedDevicePosition.started -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDevicePosition;
                @TrackedDevicePosition.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDevicePosition;
                @TrackedDevicePosition.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDevicePosition;
                @TrackedDeviceOrientation.started -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDeviceOrientation;
                @TrackedDeviceOrientation.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDeviceOrientation;
                @TrackedDeviceOrientation.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDeviceOrientation;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Navigate.started += instance.OnNavigate;
                @Navigate.performed += instance.OnNavigate;
                @Navigate.canceled += instance.OnNavigate;
                @Submit.started += instance.OnSubmit;
                @Submit.performed += instance.OnSubmit;
                @Submit.canceled += instance.OnSubmit;
                @Cancel.started += instance.OnCancel;
                @Cancel.performed += instance.OnCancel;
                @Cancel.canceled += instance.OnCancel;
                @Point.started += instance.OnPoint;
                @Point.performed += instance.OnPoint;
                @Point.canceled += instance.OnPoint;
                @Click.started += instance.OnClick;
                @Click.performed += instance.OnClick;
                @Click.canceled += instance.OnClick;
                @ScrollWheel.started += instance.OnScrollWheel;
                @ScrollWheel.performed += instance.OnScrollWheel;
                @ScrollWheel.canceled += instance.OnScrollWheel;
                @MiddleClick.started += instance.OnMiddleClick;
                @MiddleClick.performed += instance.OnMiddleClick;
                @MiddleClick.canceled += instance.OnMiddleClick;
                @RightClick.started += instance.OnRightClick;
                @RightClick.performed += instance.OnRightClick;
                @RightClick.canceled += instance.OnRightClick;
                @TrackedDevicePosition.started += instance.OnTrackedDevicePosition;
                @TrackedDevicePosition.performed += instance.OnTrackedDevicePosition;
                @TrackedDevicePosition.canceled += instance.OnTrackedDevicePosition;
                @TrackedDeviceOrientation.started += instance.OnTrackedDeviceOrientation;
                @TrackedDeviceOrientation.performed += instance.OnTrackedDeviceOrientation;
                @TrackedDeviceOrientation.canceled += instance.OnTrackedDeviceOrientation;
            }
        }
    }
    public UIActions @UI => new UIActions(this);

    // BerthingControls
    private readonly InputActionMap m_BerthingControls;
    private IBerthingControlsActions m_BerthingControlsActionsCallbackInterface;
    private readonly InputAction m_BerthingControls_Forwards;
    private readonly InputAction m_BerthingControls_ForwardsStop;
    private readonly InputAction m_BerthingControls_Backwards;
    private readonly InputAction m_BerthingControls_BackwardsStop;
    private readonly InputAction m_BerthingControls_Leftways;
    private readonly InputAction m_BerthingControls_LeftwaysStop;
    private readonly InputAction m_BerthingControls_Rightways;
    private readonly InputAction m_BerthingControls_RightwaysStop;
    private readonly InputAction m_BerthingControls_ChangeControlTypes;
    public struct BerthingControlsActions
    {
        private @BoatInputs m_Wrapper;
        public BerthingControlsActions(@BoatInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Forwards => m_Wrapper.m_BerthingControls_Forwards;
        public InputAction @ForwardsStop => m_Wrapper.m_BerthingControls_ForwardsStop;
        public InputAction @Backwards => m_Wrapper.m_BerthingControls_Backwards;
        public InputAction @BackwardsStop => m_Wrapper.m_BerthingControls_BackwardsStop;
        public InputAction @Leftways => m_Wrapper.m_BerthingControls_Leftways;
        public InputAction @LeftwaysStop => m_Wrapper.m_BerthingControls_LeftwaysStop;
        public InputAction @Rightways => m_Wrapper.m_BerthingControls_Rightways;
        public InputAction @RightwaysStop => m_Wrapper.m_BerthingControls_RightwaysStop;
        public InputAction @ChangeControlTypes => m_Wrapper.m_BerthingControls_ChangeControlTypes;
        public InputActionMap Get() { return m_Wrapper.m_BerthingControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BerthingControlsActions set) { return set.Get(); }
        public void SetCallbacks(IBerthingControlsActions instance)
        {
            if (m_Wrapper.m_BerthingControlsActionsCallbackInterface != null)
            {
                @Forwards.started -= m_Wrapper.m_BerthingControlsActionsCallbackInterface.OnForwards;
                @Forwards.performed -= m_Wrapper.m_BerthingControlsActionsCallbackInterface.OnForwards;
                @Forwards.canceled -= m_Wrapper.m_BerthingControlsActionsCallbackInterface.OnForwards;
                @ForwardsStop.started -= m_Wrapper.m_BerthingControlsActionsCallbackInterface.OnForwardsStop;
                @ForwardsStop.performed -= m_Wrapper.m_BerthingControlsActionsCallbackInterface.OnForwardsStop;
                @ForwardsStop.canceled -= m_Wrapper.m_BerthingControlsActionsCallbackInterface.OnForwardsStop;
                @Backwards.started -= m_Wrapper.m_BerthingControlsActionsCallbackInterface.OnBackwards;
                @Backwards.performed -= m_Wrapper.m_BerthingControlsActionsCallbackInterface.OnBackwards;
                @Backwards.canceled -= m_Wrapper.m_BerthingControlsActionsCallbackInterface.OnBackwards;
                @BackwardsStop.started -= m_Wrapper.m_BerthingControlsActionsCallbackInterface.OnBackwardsStop;
                @BackwardsStop.performed -= m_Wrapper.m_BerthingControlsActionsCallbackInterface.OnBackwardsStop;
                @BackwardsStop.canceled -= m_Wrapper.m_BerthingControlsActionsCallbackInterface.OnBackwardsStop;
                @Leftways.started -= m_Wrapper.m_BerthingControlsActionsCallbackInterface.OnLeftways;
                @Leftways.performed -= m_Wrapper.m_BerthingControlsActionsCallbackInterface.OnLeftways;
                @Leftways.canceled -= m_Wrapper.m_BerthingControlsActionsCallbackInterface.OnLeftways;
                @LeftwaysStop.started -= m_Wrapper.m_BerthingControlsActionsCallbackInterface.OnLeftwaysStop;
                @LeftwaysStop.performed -= m_Wrapper.m_BerthingControlsActionsCallbackInterface.OnLeftwaysStop;
                @LeftwaysStop.canceled -= m_Wrapper.m_BerthingControlsActionsCallbackInterface.OnLeftwaysStop;
                @Rightways.started -= m_Wrapper.m_BerthingControlsActionsCallbackInterface.OnRightways;
                @Rightways.performed -= m_Wrapper.m_BerthingControlsActionsCallbackInterface.OnRightways;
                @Rightways.canceled -= m_Wrapper.m_BerthingControlsActionsCallbackInterface.OnRightways;
                @RightwaysStop.started -= m_Wrapper.m_BerthingControlsActionsCallbackInterface.OnRightwaysStop;
                @RightwaysStop.performed -= m_Wrapper.m_BerthingControlsActionsCallbackInterface.OnRightwaysStop;
                @RightwaysStop.canceled -= m_Wrapper.m_BerthingControlsActionsCallbackInterface.OnRightwaysStop;
                @ChangeControlTypes.started -= m_Wrapper.m_BerthingControlsActionsCallbackInterface.OnChangeControlTypes;
                @ChangeControlTypes.performed -= m_Wrapper.m_BerthingControlsActionsCallbackInterface.OnChangeControlTypes;
                @ChangeControlTypes.canceled -= m_Wrapper.m_BerthingControlsActionsCallbackInterface.OnChangeControlTypes;
            }
            m_Wrapper.m_BerthingControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Forwards.started += instance.OnForwards;
                @Forwards.performed += instance.OnForwards;
                @Forwards.canceled += instance.OnForwards;
                @ForwardsStop.started += instance.OnForwardsStop;
                @ForwardsStop.performed += instance.OnForwardsStop;
                @ForwardsStop.canceled += instance.OnForwardsStop;
                @Backwards.started += instance.OnBackwards;
                @Backwards.performed += instance.OnBackwards;
                @Backwards.canceled += instance.OnBackwards;
                @BackwardsStop.started += instance.OnBackwardsStop;
                @BackwardsStop.performed += instance.OnBackwardsStop;
                @BackwardsStop.canceled += instance.OnBackwardsStop;
                @Leftways.started += instance.OnLeftways;
                @Leftways.performed += instance.OnLeftways;
                @Leftways.canceled += instance.OnLeftways;
                @LeftwaysStop.started += instance.OnLeftwaysStop;
                @LeftwaysStop.performed += instance.OnLeftwaysStop;
                @LeftwaysStop.canceled += instance.OnLeftwaysStop;
                @Rightways.started += instance.OnRightways;
                @Rightways.performed += instance.OnRightways;
                @Rightways.canceled += instance.OnRightways;
                @RightwaysStop.started += instance.OnRightwaysStop;
                @RightwaysStop.performed += instance.OnRightwaysStop;
                @RightwaysStop.canceled += instance.OnRightwaysStop;
                @ChangeControlTypes.started += instance.OnChangeControlTypes;
                @ChangeControlTypes.performed += instance.OnChangeControlTypes;
                @ChangeControlTypes.canceled += instance.OnChangeControlTypes;
            }
        }
    }
    public BerthingControlsActions @BerthingControls => new BerthingControlsActions(this);

    // InduvidualEngineControls
    private readonly InputActionMap m_InduvidualEngineControls;
    private IInduvidualEngineControlsActions m_InduvidualEngineControlsActionsCallbackInterface;
    private readonly InputAction m_InduvidualEngineControls_LeftForwards;
    private readonly InputAction m_InduvidualEngineControls_LeftForwardsStop;
    private readonly InputAction m_InduvidualEngineControls_LeftBackwards;
    private readonly InputAction m_InduvidualEngineControls_LeftBackwardsStop;
    private readonly InputAction m_InduvidualEngineControls_RightForwards;
    private readonly InputAction m_InduvidualEngineControls_RightForwardsStop;
    private readonly InputAction m_InduvidualEngineControls_RightBackwards;
    private readonly InputAction m_InduvidualEngineControls_RightBackwardsStop;
    private readonly InputAction m_InduvidualEngineControls_CombinedControlsSwitch;
    public struct InduvidualEngineControlsActions
    {
        private @BoatInputs m_Wrapper;
        public InduvidualEngineControlsActions(@BoatInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @LeftForwards => m_Wrapper.m_InduvidualEngineControls_LeftForwards;
        public InputAction @LeftForwardsStop => m_Wrapper.m_InduvidualEngineControls_LeftForwardsStop;
        public InputAction @LeftBackwards => m_Wrapper.m_InduvidualEngineControls_LeftBackwards;
        public InputAction @LeftBackwardsStop => m_Wrapper.m_InduvidualEngineControls_LeftBackwardsStop;
        public InputAction @RightForwards => m_Wrapper.m_InduvidualEngineControls_RightForwards;
        public InputAction @RightForwardsStop => m_Wrapper.m_InduvidualEngineControls_RightForwardsStop;
        public InputAction @RightBackwards => m_Wrapper.m_InduvidualEngineControls_RightBackwards;
        public InputAction @RightBackwardsStop => m_Wrapper.m_InduvidualEngineControls_RightBackwardsStop;
        public InputAction @CombinedControlsSwitch => m_Wrapper.m_InduvidualEngineControls_CombinedControlsSwitch;
        public InputActionMap Get() { return m_Wrapper.m_InduvidualEngineControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InduvidualEngineControlsActions set) { return set.Get(); }
        public void SetCallbacks(IInduvidualEngineControlsActions instance)
        {
            if (m_Wrapper.m_InduvidualEngineControlsActionsCallbackInterface != null)
            {
                @LeftForwards.started -= m_Wrapper.m_InduvidualEngineControlsActionsCallbackInterface.OnLeftForwards;
                @LeftForwards.performed -= m_Wrapper.m_InduvidualEngineControlsActionsCallbackInterface.OnLeftForwards;
                @LeftForwards.canceled -= m_Wrapper.m_InduvidualEngineControlsActionsCallbackInterface.OnLeftForwards;
                @LeftForwardsStop.started -= m_Wrapper.m_InduvidualEngineControlsActionsCallbackInterface.OnLeftForwardsStop;
                @LeftForwardsStop.performed -= m_Wrapper.m_InduvidualEngineControlsActionsCallbackInterface.OnLeftForwardsStop;
                @LeftForwardsStop.canceled -= m_Wrapper.m_InduvidualEngineControlsActionsCallbackInterface.OnLeftForwardsStop;
                @LeftBackwards.started -= m_Wrapper.m_InduvidualEngineControlsActionsCallbackInterface.OnLeftBackwards;
                @LeftBackwards.performed -= m_Wrapper.m_InduvidualEngineControlsActionsCallbackInterface.OnLeftBackwards;
                @LeftBackwards.canceled -= m_Wrapper.m_InduvidualEngineControlsActionsCallbackInterface.OnLeftBackwards;
                @LeftBackwardsStop.started -= m_Wrapper.m_InduvidualEngineControlsActionsCallbackInterface.OnLeftBackwardsStop;
                @LeftBackwardsStop.performed -= m_Wrapper.m_InduvidualEngineControlsActionsCallbackInterface.OnLeftBackwardsStop;
                @LeftBackwardsStop.canceled -= m_Wrapper.m_InduvidualEngineControlsActionsCallbackInterface.OnLeftBackwardsStop;
                @RightForwards.started -= m_Wrapper.m_InduvidualEngineControlsActionsCallbackInterface.OnRightForwards;
                @RightForwards.performed -= m_Wrapper.m_InduvidualEngineControlsActionsCallbackInterface.OnRightForwards;
                @RightForwards.canceled -= m_Wrapper.m_InduvidualEngineControlsActionsCallbackInterface.OnRightForwards;
                @RightForwardsStop.started -= m_Wrapper.m_InduvidualEngineControlsActionsCallbackInterface.OnRightForwardsStop;
                @RightForwardsStop.performed -= m_Wrapper.m_InduvidualEngineControlsActionsCallbackInterface.OnRightForwardsStop;
                @RightForwardsStop.canceled -= m_Wrapper.m_InduvidualEngineControlsActionsCallbackInterface.OnRightForwardsStop;
                @RightBackwards.started -= m_Wrapper.m_InduvidualEngineControlsActionsCallbackInterface.OnRightBackwards;
                @RightBackwards.performed -= m_Wrapper.m_InduvidualEngineControlsActionsCallbackInterface.OnRightBackwards;
                @RightBackwards.canceled -= m_Wrapper.m_InduvidualEngineControlsActionsCallbackInterface.OnRightBackwards;
                @RightBackwardsStop.started -= m_Wrapper.m_InduvidualEngineControlsActionsCallbackInterface.OnRightBackwardsStop;
                @RightBackwardsStop.performed -= m_Wrapper.m_InduvidualEngineControlsActionsCallbackInterface.OnRightBackwardsStop;
                @RightBackwardsStop.canceled -= m_Wrapper.m_InduvidualEngineControlsActionsCallbackInterface.OnRightBackwardsStop;
                @CombinedControlsSwitch.started -= m_Wrapper.m_InduvidualEngineControlsActionsCallbackInterface.OnCombinedControlsSwitch;
                @CombinedControlsSwitch.performed -= m_Wrapper.m_InduvidualEngineControlsActionsCallbackInterface.OnCombinedControlsSwitch;
                @CombinedControlsSwitch.canceled -= m_Wrapper.m_InduvidualEngineControlsActionsCallbackInterface.OnCombinedControlsSwitch;
            }
            m_Wrapper.m_InduvidualEngineControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @LeftForwards.started += instance.OnLeftForwards;
                @LeftForwards.performed += instance.OnLeftForwards;
                @LeftForwards.canceled += instance.OnLeftForwards;
                @LeftForwardsStop.started += instance.OnLeftForwardsStop;
                @LeftForwardsStop.performed += instance.OnLeftForwardsStop;
                @LeftForwardsStop.canceled += instance.OnLeftForwardsStop;
                @LeftBackwards.started += instance.OnLeftBackwards;
                @LeftBackwards.performed += instance.OnLeftBackwards;
                @LeftBackwards.canceled += instance.OnLeftBackwards;
                @LeftBackwardsStop.started += instance.OnLeftBackwardsStop;
                @LeftBackwardsStop.performed += instance.OnLeftBackwardsStop;
                @LeftBackwardsStop.canceled += instance.OnLeftBackwardsStop;
                @RightForwards.started += instance.OnRightForwards;
                @RightForwards.performed += instance.OnRightForwards;
                @RightForwards.canceled += instance.OnRightForwards;
                @RightForwardsStop.started += instance.OnRightForwardsStop;
                @RightForwardsStop.performed += instance.OnRightForwardsStop;
                @RightForwardsStop.canceled += instance.OnRightForwardsStop;
                @RightBackwards.started += instance.OnRightBackwards;
                @RightBackwards.performed += instance.OnRightBackwards;
                @RightBackwards.canceled += instance.OnRightBackwards;
                @RightBackwardsStop.started += instance.OnRightBackwardsStop;
                @RightBackwardsStop.performed += instance.OnRightBackwardsStop;
                @RightBackwardsStop.canceled += instance.OnRightBackwardsStop;
                @CombinedControlsSwitch.started += instance.OnCombinedControlsSwitch;
                @CombinedControlsSwitch.performed += instance.OnCombinedControlsSwitch;
                @CombinedControlsSwitch.canceled += instance.OnCombinedControlsSwitch;
            }
        }
    }
    public InduvidualEngineControlsActions @InduvidualEngineControls => new InduvidualEngineControlsActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard&Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_TouchSchemeIndex = -1;
    public InputControlScheme TouchScheme
    {
        get
        {
            if (m_TouchSchemeIndex == -1) m_TouchSchemeIndex = asset.FindControlSchemeIndex("Touch");
            return asset.controlSchemes[m_TouchSchemeIndex];
        }
    }
    private int m_JoystickSchemeIndex = -1;
    public InputControlScheme JoystickScheme
    {
        get
        {
            if (m_JoystickSchemeIndex == -1) m_JoystickSchemeIndex = asset.FindControlSchemeIndex("Joystick");
            return asset.controlSchemes[m_JoystickSchemeIndex];
        }
    }
    private int m_XRSchemeIndex = -1;
    public InputControlScheme XRScheme
    {
        get
        {
            if (m_XRSchemeIndex == -1) m_XRSchemeIndex = asset.FindControlSchemeIndex("XR");
            return asset.controlSchemes[m_XRSchemeIndex];
        }
    }
    public interface ICombinedEngineControlsActions
    {
        void OnEnginePowerUp(InputAction.CallbackContext context);
        void OnEnginePowerUpStop(InputAction.CallbackContext context);
        void OnEnginePowerDown(InputAction.CallbackContext context);
        void OnEnginePowerDownStop(InputAction.CallbackContext context);
        void OnRotateLeft(InputAction.CallbackContext context);
        void OnRotateLeftStop(InputAction.CallbackContext context);
        void OnRotateRight(InputAction.CallbackContext context);
        void OnRotateRightStop(InputAction.CallbackContext context);
        void OnChangeCam(InputAction.CallbackContext context);
        void OnCameraZoom(InputAction.CallbackContext context);
        void OnStop(InputAction.CallbackContext context);
        void OnChangeControlType(InputAction.CallbackContext context);
        void OnInduvidualControlsSwitch(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnNavigate(InputAction.CallbackContext context);
        void OnSubmit(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
        void OnPoint(InputAction.CallbackContext context);
        void OnClick(InputAction.CallbackContext context);
        void OnScrollWheel(InputAction.CallbackContext context);
        void OnMiddleClick(InputAction.CallbackContext context);
        void OnRightClick(InputAction.CallbackContext context);
        void OnTrackedDevicePosition(InputAction.CallbackContext context);
        void OnTrackedDeviceOrientation(InputAction.CallbackContext context);
    }
    public interface IBerthingControlsActions
    {
        void OnForwards(InputAction.CallbackContext context);
        void OnForwardsStop(InputAction.CallbackContext context);
        void OnBackwards(InputAction.CallbackContext context);
        void OnBackwardsStop(InputAction.CallbackContext context);
        void OnLeftways(InputAction.CallbackContext context);
        void OnLeftwaysStop(InputAction.CallbackContext context);
        void OnRightways(InputAction.CallbackContext context);
        void OnRightwaysStop(InputAction.CallbackContext context);
        void OnChangeControlTypes(InputAction.CallbackContext context);
    }
    public interface IInduvidualEngineControlsActions
    {
        void OnLeftForwards(InputAction.CallbackContext context);
        void OnLeftForwardsStop(InputAction.CallbackContext context);
        void OnLeftBackwards(InputAction.CallbackContext context);
        void OnLeftBackwardsStop(InputAction.CallbackContext context);
        void OnRightForwards(InputAction.CallbackContext context);
        void OnRightForwardsStop(InputAction.CallbackContext context);
        void OnRightBackwards(InputAction.CallbackContext context);
        void OnRightBackwardsStop(InputAction.CallbackContext context);
        void OnCombinedControlsSwitch(InputAction.CallbackContext context);
    }
}
