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
            ""name"": ""BoatControls"",
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
                    ""name"": ""Handbrake"",
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
                    ""id"": ""bebe814b-740a-4efb-98cb-6a6f56d1101a"",
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
                    ""action"": ""Handbrake"",
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
                    ""name"": ""ChangeControlTypes"",
                    ""type"": ""Button"",
                    ""id"": ""68f69d67-a4a1-414e-8845-f1a87d8893b5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
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
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0712bcc3-e384-4cfe-8d3b-776c420c5da9"",
                    ""path"": ""<Keyboard>/b"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeControlTypes"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
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
                }
            ]
        },
        {
            ""name"": ""Mouse"",
            ""id"": ""02627140-dc9b-478e-9200-4dc2fd48bb20"",
            ""actions"": [
                {
                    ""name"": ""MouseLook"",
                    ""type"": ""PassThrough"",
                    ""id"": ""6036e596-1e76-4e6d-99df-bd77fe539e1a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""85e39b8e-6f16-40dd-a178-f9516c3f8824"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseLook"",
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
        // BoatControls
        m_BoatControls = asset.FindActionMap("BoatControls", throwIfNotFound: true);
        m_BoatControls_EnginePowerUp = m_BoatControls.FindAction("EnginePowerUp", throwIfNotFound: true);
        m_BoatControls_EnginePowerUpStop = m_BoatControls.FindAction("EnginePowerUpStop", throwIfNotFound: true);
        m_BoatControls_EnginePowerDown = m_BoatControls.FindAction("EnginePowerDown", throwIfNotFound: true);
        m_BoatControls_EnginePowerDownStop = m_BoatControls.FindAction("EnginePowerDownStop", throwIfNotFound: true);
        m_BoatControls_RotateLeft = m_BoatControls.FindAction("RotateLeft", throwIfNotFound: true);
        m_BoatControls_RotateLeftStop = m_BoatControls.FindAction("RotateLeftStop", throwIfNotFound: true);
        m_BoatControls_RotateRight = m_BoatControls.FindAction("RotateRight", throwIfNotFound: true);
        m_BoatControls_RotateRightStop = m_BoatControls.FindAction("RotateRightStop", throwIfNotFound: true);
        m_BoatControls_ChangeCam = m_BoatControls.FindAction("ChangeCam", throwIfNotFound: true);
        m_BoatControls_CameraZoom = m_BoatControls.FindAction("CameraZoom", throwIfNotFound: true);
        m_BoatControls_Handbrake = m_BoatControls.FindAction("Handbrake", throwIfNotFound: true);
        m_BoatControls_ChangeControlType = m_BoatControls.FindAction("ChangeControlType", throwIfNotFound: true);
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
        m_BerthingControls_ChangeControlTypes = m_BerthingControls.FindAction("ChangeControlTypes", throwIfNotFound: true);
        m_BerthingControls_Forwards = m_BerthingControls.FindAction("Forwards", throwIfNotFound: true);
        m_BerthingControls_ForwardsStop = m_BerthingControls.FindAction("ForwardsStop", throwIfNotFound: true);
        m_BerthingControls_Backwards = m_BerthingControls.FindAction("Backwards", throwIfNotFound: true);
        m_BerthingControls_BackwardsStop = m_BerthingControls.FindAction("BackwardsStop", throwIfNotFound: true);
        m_BerthingControls_Leftways = m_BerthingControls.FindAction("Leftways", throwIfNotFound: true);
        m_BerthingControls_LeftwaysStop = m_BerthingControls.FindAction("LeftwaysStop", throwIfNotFound: true);
        m_BerthingControls_Rightways = m_BerthingControls.FindAction("Rightways", throwIfNotFound: true);
        m_BerthingControls_RightwaysStop = m_BerthingControls.FindAction("RightwaysStop", throwIfNotFound: true);
        // Mouse
        m_Mouse = asset.FindActionMap("Mouse", throwIfNotFound: true);
        m_Mouse_MouseLook = m_Mouse.FindAction("MouseLook", throwIfNotFound: true);
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

    // BoatControls
    private readonly InputActionMap m_BoatControls;
    private IBoatControlsActions m_BoatControlsActionsCallbackInterface;
    private readonly InputAction m_BoatControls_EnginePowerUp;
    private readonly InputAction m_BoatControls_EnginePowerUpStop;
    private readonly InputAction m_BoatControls_EnginePowerDown;
    private readonly InputAction m_BoatControls_EnginePowerDownStop;
    private readonly InputAction m_BoatControls_RotateLeft;
    private readonly InputAction m_BoatControls_RotateLeftStop;
    private readonly InputAction m_BoatControls_RotateRight;
    private readonly InputAction m_BoatControls_RotateRightStop;
    private readonly InputAction m_BoatControls_ChangeCam;
    private readonly InputAction m_BoatControls_CameraZoom;
    private readonly InputAction m_BoatControls_Handbrake;
    private readonly InputAction m_BoatControls_ChangeControlType;
    public struct BoatControlsActions
    {
        private @BoatInputs m_Wrapper;
        public BoatControlsActions(@BoatInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @EnginePowerUp => m_Wrapper.m_BoatControls_EnginePowerUp;
        public InputAction @EnginePowerUpStop => m_Wrapper.m_BoatControls_EnginePowerUpStop;
        public InputAction @EnginePowerDown => m_Wrapper.m_BoatControls_EnginePowerDown;
        public InputAction @EnginePowerDownStop => m_Wrapper.m_BoatControls_EnginePowerDownStop;
        public InputAction @RotateLeft => m_Wrapper.m_BoatControls_RotateLeft;
        public InputAction @RotateLeftStop => m_Wrapper.m_BoatControls_RotateLeftStop;
        public InputAction @RotateRight => m_Wrapper.m_BoatControls_RotateRight;
        public InputAction @RotateRightStop => m_Wrapper.m_BoatControls_RotateRightStop;
        public InputAction @ChangeCam => m_Wrapper.m_BoatControls_ChangeCam;
        public InputAction @CameraZoom => m_Wrapper.m_BoatControls_CameraZoom;
        public InputAction @Handbrake => m_Wrapper.m_BoatControls_Handbrake;
        public InputAction @ChangeControlType => m_Wrapper.m_BoatControls_ChangeControlType;
        public InputActionMap Get() { return m_Wrapper.m_BoatControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BoatControlsActions set) { return set.Get(); }
        public void SetCallbacks(IBoatControlsActions instance)
        {
            if (m_Wrapper.m_BoatControlsActionsCallbackInterface != null)
            {
                @EnginePowerUp.started -= m_Wrapper.m_BoatControlsActionsCallbackInterface.OnEnginePowerUp;
                @EnginePowerUp.performed -= m_Wrapper.m_BoatControlsActionsCallbackInterface.OnEnginePowerUp;
                @EnginePowerUp.canceled -= m_Wrapper.m_BoatControlsActionsCallbackInterface.OnEnginePowerUp;
                @EnginePowerUpStop.started -= m_Wrapper.m_BoatControlsActionsCallbackInterface.OnEnginePowerUpStop;
                @EnginePowerUpStop.performed -= m_Wrapper.m_BoatControlsActionsCallbackInterface.OnEnginePowerUpStop;
                @EnginePowerUpStop.canceled -= m_Wrapper.m_BoatControlsActionsCallbackInterface.OnEnginePowerUpStop;
                @EnginePowerDown.started -= m_Wrapper.m_BoatControlsActionsCallbackInterface.OnEnginePowerDown;
                @EnginePowerDown.performed -= m_Wrapper.m_BoatControlsActionsCallbackInterface.OnEnginePowerDown;
                @EnginePowerDown.canceled -= m_Wrapper.m_BoatControlsActionsCallbackInterface.OnEnginePowerDown;
                @EnginePowerDownStop.started -= m_Wrapper.m_BoatControlsActionsCallbackInterface.OnEnginePowerDownStop;
                @EnginePowerDownStop.performed -= m_Wrapper.m_BoatControlsActionsCallbackInterface.OnEnginePowerDownStop;
                @EnginePowerDownStop.canceled -= m_Wrapper.m_BoatControlsActionsCallbackInterface.OnEnginePowerDownStop;
                @RotateLeft.started -= m_Wrapper.m_BoatControlsActionsCallbackInterface.OnRotateLeft;
                @RotateLeft.performed -= m_Wrapper.m_BoatControlsActionsCallbackInterface.OnRotateLeft;
                @RotateLeft.canceled -= m_Wrapper.m_BoatControlsActionsCallbackInterface.OnRotateLeft;
                @RotateLeftStop.started -= m_Wrapper.m_BoatControlsActionsCallbackInterface.OnRotateLeftStop;
                @RotateLeftStop.performed -= m_Wrapper.m_BoatControlsActionsCallbackInterface.OnRotateLeftStop;
                @RotateLeftStop.canceled -= m_Wrapper.m_BoatControlsActionsCallbackInterface.OnRotateLeftStop;
                @RotateRight.started -= m_Wrapper.m_BoatControlsActionsCallbackInterface.OnRotateRight;
                @RotateRight.performed -= m_Wrapper.m_BoatControlsActionsCallbackInterface.OnRotateRight;
                @RotateRight.canceled -= m_Wrapper.m_BoatControlsActionsCallbackInterface.OnRotateRight;
                @RotateRightStop.started -= m_Wrapper.m_BoatControlsActionsCallbackInterface.OnRotateRightStop;
                @RotateRightStop.performed -= m_Wrapper.m_BoatControlsActionsCallbackInterface.OnRotateRightStop;
                @RotateRightStop.canceled -= m_Wrapper.m_BoatControlsActionsCallbackInterface.OnRotateRightStop;
                @ChangeCam.started -= m_Wrapper.m_BoatControlsActionsCallbackInterface.OnChangeCam;
                @ChangeCam.performed -= m_Wrapper.m_BoatControlsActionsCallbackInterface.OnChangeCam;
                @ChangeCam.canceled -= m_Wrapper.m_BoatControlsActionsCallbackInterface.OnChangeCam;
                @CameraZoom.started -= m_Wrapper.m_BoatControlsActionsCallbackInterface.OnCameraZoom;
                @CameraZoom.performed -= m_Wrapper.m_BoatControlsActionsCallbackInterface.OnCameraZoom;
                @CameraZoom.canceled -= m_Wrapper.m_BoatControlsActionsCallbackInterface.OnCameraZoom;
                @Handbrake.started -= m_Wrapper.m_BoatControlsActionsCallbackInterface.OnHandbrake;
                @Handbrake.performed -= m_Wrapper.m_BoatControlsActionsCallbackInterface.OnHandbrake;
                @Handbrake.canceled -= m_Wrapper.m_BoatControlsActionsCallbackInterface.OnHandbrake;
                @ChangeControlType.started -= m_Wrapper.m_BoatControlsActionsCallbackInterface.OnChangeControlType;
                @ChangeControlType.performed -= m_Wrapper.m_BoatControlsActionsCallbackInterface.OnChangeControlType;
                @ChangeControlType.canceled -= m_Wrapper.m_BoatControlsActionsCallbackInterface.OnChangeControlType;
            }
            m_Wrapper.m_BoatControlsActionsCallbackInterface = instance;
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
                @Handbrake.started += instance.OnHandbrake;
                @Handbrake.performed += instance.OnHandbrake;
                @Handbrake.canceled += instance.OnHandbrake;
                @ChangeControlType.started += instance.OnChangeControlType;
                @ChangeControlType.performed += instance.OnChangeControlType;
                @ChangeControlType.canceled += instance.OnChangeControlType;
            }
        }
    }
    public BoatControlsActions @BoatControls => new BoatControlsActions(this);

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
    private readonly InputAction m_BerthingControls_ChangeControlTypes;
    private readonly InputAction m_BerthingControls_Forwards;
    private readonly InputAction m_BerthingControls_ForwardsStop;
    private readonly InputAction m_BerthingControls_Backwards;
    private readonly InputAction m_BerthingControls_BackwardsStop;
    private readonly InputAction m_BerthingControls_Leftways;
    private readonly InputAction m_BerthingControls_LeftwaysStop;
    private readonly InputAction m_BerthingControls_Rightways;
    private readonly InputAction m_BerthingControls_RightwaysStop;
    public struct BerthingControlsActions
    {
        private @BoatInputs m_Wrapper;
        public BerthingControlsActions(@BoatInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @ChangeControlTypes => m_Wrapper.m_BerthingControls_ChangeControlTypes;
        public InputAction @Forwards => m_Wrapper.m_BerthingControls_Forwards;
        public InputAction @ForwardsStop => m_Wrapper.m_BerthingControls_ForwardsStop;
        public InputAction @Backwards => m_Wrapper.m_BerthingControls_Backwards;
        public InputAction @BackwardsStop => m_Wrapper.m_BerthingControls_BackwardsStop;
        public InputAction @Leftways => m_Wrapper.m_BerthingControls_Leftways;
        public InputAction @LeftwaysStop => m_Wrapper.m_BerthingControls_LeftwaysStop;
        public InputAction @Rightways => m_Wrapper.m_BerthingControls_Rightways;
        public InputAction @RightwaysStop => m_Wrapper.m_BerthingControls_RightwaysStop;
        public InputActionMap Get() { return m_Wrapper.m_BerthingControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BerthingControlsActions set) { return set.Get(); }
        public void SetCallbacks(IBerthingControlsActions instance)
        {
            if (m_Wrapper.m_BerthingControlsActionsCallbackInterface != null)
            {
                @ChangeControlTypes.started -= m_Wrapper.m_BerthingControlsActionsCallbackInterface.OnChangeControlTypes;
                @ChangeControlTypes.performed -= m_Wrapper.m_BerthingControlsActionsCallbackInterface.OnChangeControlTypes;
                @ChangeControlTypes.canceled -= m_Wrapper.m_BerthingControlsActionsCallbackInterface.OnChangeControlTypes;
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
            }
            m_Wrapper.m_BerthingControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ChangeControlTypes.started += instance.OnChangeControlTypes;
                @ChangeControlTypes.performed += instance.OnChangeControlTypes;
                @ChangeControlTypes.canceled += instance.OnChangeControlTypes;
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
            }
        }
    }
    public BerthingControlsActions @BerthingControls => new BerthingControlsActions(this);

    // Mouse
    private readonly InputActionMap m_Mouse;
    private IMouseActions m_MouseActionsCallbackInterface;
    private readonly InputAction m_Mouse_MouseLook;
    public struct MouseActions
    {
        private @BoatInputs m_Wrapper;
        public MouseActions(@BoatInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @MouseLook => m_Wrapper.m_Mouse_MouseLook;
        public InputActionMap Get() { return m_Wrapper.m_Mouse; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MouseActions set) { return set.Get(); }
        public void SetCallbacks(IMouseActions instance)
        {
            if (m_Wrapper.m_MouseActionsCallbackInterface != null)
            {
                @MouseLook.started -= m_Wrapper.m_MouseActionsCallbackInterface.OnMouseLook;
                @MouseLook.performed -= m_Wrapper.m_MouseActionsCallbackInterface.OnMouseLook;
                @MouseLook.canceled -= m_Wrapper.m_MouseActionsCallbackInterface.OnMouseLook;
            }
            m_Wrapper.m_MouseActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MouseLook.started += instance.OnMouseLook;
                @MouseLook.performed += instance.OnMouseLook;
                @MouseLook.canceled += instance.OnMouseLook;
            }
        }
    }
    public MouseActions @Mouse => new MouseActions(this);
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
    public interface IBoatControlsActions
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
        void OnHandbrake(InputAction.CallbackContext context);
        void OnChangeControlType(InputAction.CallbackContext context);
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
        void OnChangeControlTypes(InputAction.CallbackContext context);
        void OnForwards(InputAction.CallbackContext context);
        void OnForwardsStop(InputAction.CallbackContext context);
        void OnBackwards(InputAction.CallbackContext context);
        void OnBackwardsStop(InputAction.CallbackContext context);
        void OnLeftways(InputAction.CallbackContext context);
        void OnLeftwaysStop(InputAction.CallbackContext context);
        void OnRightways(InputAction.CallbackContext context);
        void OnRightwaysStop(InputAction.CallbackContext context);
    }
    public interface IMouseActions
    {
        void OnMouseLook(InputAction.CallbackContext context);
    }
}
