using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;

public class BoatScript : MonoBehaviour
{
    BoatInputs inputs;

    [SerializeField] Rigidbody boatBody;
    [SerializeField] float Torque;

    float positiveCombinedEnginePower = 0f;
    float negativeCombinedEnginePower = 0f;

    float positiveLeftEnginePower = 0f;
    float negativeLeftEnginePower = 0f;

    float positiveRightEnginePower = 0f;
    float negativeRightEnginePower = 0f;

    public float combinedEnginePowerValue = 0f;
    public float leftEnginePowerValue = 0f;
    public float rightEnginePower = 0f;
    public float rotValue = 0f;

    float maxEnginePower = 10f;
    float minEnginePower = -5f;
    float enginePowerChange = 5f;

    float leftRot = 0f;
    float rightRot = 0f;
    float maxRot = 15f;
    float minRot = -15f;
    float rotChange = 5f;

    bool combinedControlsEnabled = true;
    bool berthControlsEnabled = false;
    bool induviualControlsEnbaled = false;

    bool combinedPowerIncreasing = false;
    bool combinedPowerDecreasing = false;

    bool leftPowerIncreasing = false;
    bool leftPowerDecreasing = false;

    bool rightPowerIncreasing = false;
    bool rightPowerDecreasing = false;

    bool isTurningLeft = false;
    bool isTurningRight = false;

    bool isMoving = false;
    bool isStopped = false;

    string controlType;

    void Awake()
    {
        inputs = new BoatInputs();

        inputs.CombinedEngineControls.EnginePowerUp.performed += epUp;
        inputs.CombinedEngineControls.EnginePowerUpStop.performed += epUpStop;
        inputs.CombinedEngineControls.EnginePowerDown.performed += epDown;
        inputs.CombinedEngineControls.EnginePowerDownStop.performed += epDownStop;
        inputs.CombinedEngineControls.RotateLeft.performed += rotLeft;
        inputs.CombinedEngineControls.RotateLeftStop.performed += rotLeftStop;
        inputs.CombinedEngineControls.RotateRight.performed += rotRight;
        inputs.CombinedEngineControls.RotateRightStop.performed += rotRightStop;
        inputs.CombinedEngineControls.Stop.performed += StopMove;
        inputs.CombinedEngineControls.ChangeControlType.performed += ChangeControls;
        inputs.CombinedEngineControls.InduvidualControlsSwitch.performed += ChangeInduvidualControls;

        inputs.BerthingControls.Forwards.performed += BerthForwards;
        inputs.BerthingControls.Backwards.performed += BerthBackwards;
        inputs.BerthingControls.Leftways.performed += BerthLeft;
        inputs.BerthingControls.Rightways.performed += BerthRight;
        inputs.BerthingControls.ForwardsStop.performed += BerthForwardsStop;
        inputs.BerthingControls.BackwardsStop.performed += BerthBackwardsStop;
        inputs.BerthingControls.LeftwaysStop.performed += BerthLeftStop;
        inputs.BerthingControls.RightwaysStop.performed += BerthRightStop;
        inputs.BerthingControls.ChangeControlTypes.performed += ChangeControlsBack;

        inputs.InduvidualEngineControls.CombinedControlsSwitch.performed += ChangeCombinedControls;
        inputs.InduvidualEngineControls.LeftForwards.performed += leUp;
        inputs.InduvidualEngineControls.LeftForwardsStop.performed += leUpStop;
        inputs.InduvidualEngineControls.RightBackwards.performed += reUpStop;
        inputs.InduvidualEngineControls.RightBackwardsStop.performed += reUpStop;

        boatBody = GetComponent<Rigidbody>();
    }

    void OnEnable()
    {
        inputs.CombinedEngineControls.Enable();
    }

    void OnDisable()
    {
        inputs.CombinedEngineControls.Disable();
    }

    void epUp(InputAction.CallbackContext ctx) //epUp = Engine Power Up
    {
        combinedPowerIncreasing = true;
    }

    void epUpStop(InputAction.CallbackContext ctx) // stop increasing engine power
    {
        combinedPowerIncreasing = false;
    }

    void epDown(InputAction.CallbackContext ctx) //epDown = Engine Power Down
    {
        combinedPowerDecreasing = true;
    }

    void epDownStop(InputAction.CallbackContext ctx) // stop decreasing engine power
    {
        combinedPowerDecreasing = false;
    }

    void rotLeft(InputAction.CallbackContext ctx) //rotLeft = Left Rotation
    {
        isTurningLeft = true;
    }

    void rotLeftStop(InputAction.CallbackContext ctx) //stop Left Rotation
    {
        isTurningLeft = false;
    }

    void rotRight(InputAction.CallbackContext ctx) //rotRight = Right Rotation
    {
        isTurningRight = true;
    }

    void rotRightStop(InputAction.CallbackContext ctx) //stop right rotation
    {
        isTurningRight = false;
    }

    void StopMove(InputAction.CallbackContext ctx) // stop moving
    {
        isStopped = true;
    }

    void reUp(InputAction.CallbackContext ctx) //right enigne power up
    {
        rightPowerIncreasing = true;
    }

    void reUpStop(InputAction.CallbackContext ctx) //right enigne power up stop
    {
        rightPowerIncreasing = false;
    }

    void reDown(InputAction.CallbackContext ctx) //right engine power down
    {
        rightPowerDecreasing = true;
    }

    void reDownStop(InputAction.CallbackContext ctx) //right engine power down stop
    {
        rightPowerDecreasing = false;
    }

    void leUp(InputAction.CallbackContext ctx) //left enigne power up
    {
        leftPowerIncreasing = true;
    }

    void leUpStop(InputAction.CallbackContext ctx) //left enigne power up stop
    {
        leftPowerIncreasing = false;
    }

    void leDown(InputAction.CallbackContext ctx) //left engine power down
    {
        leftPowerDecreasing = true;
    }

    void leDownStop(InputAction.CallbackContext ctx) //left engine power down stop
    {
        leftPowerDecreasing = false;
    }

    void ChangeControls(InputAction.CallbackContext ctx) //change controls to berthing controls and disable regulart controls 
    {
        if (!isMoving)
        {
            inputs.CombinedEngineControls.Disable();
            inputs.BerthingControls.Enable();
            combinedControlsEnabled = false;
            berthControlsEnabled = true;
        }
    }

    void ChangeControlsBack(InputAction.CallbackContext ctx) //swap controls back to regular controls and disable berthing controls
    {
        if (!isMoving)
        {
            inputs.BerthingControls.Disable();
            inputs.CombinedEngineControls.Enable();
            combinedControlsEnabled = true;
            berthControlsEnabled = false;
        }

    }

    void ChangeInduvidualControls(InputAction.CallbackContext ctx) 
    {
        if (!isMoving)
        {
            inputs.CombinedEngineControls.Disable();
            inputs.InduvidualEngineControls.Enable();
            induviualControlsEnbaled = true;
            combinedControlsEnabled = false;
            berthControlsEnabled = false;
        }
    }

    void ChangeCombinedControls(InputAction.CallbackContext ctx) 
    {
        if (!isMoving)
        {
            inputs.CombinedEngineControls.Enable();
            inputs.InduvidualEngineControls.Disable();
            induviualControlsEnbaled = false;
            combinedControlsEnabled = true;
            berthControlsEnabled = false;

        }
    }

    void BerthForwards(InputAction.CallbackContext ctx) //move forward with berth controls
    {
        combinedPowerIncreasing = true;
    }

    void BerthBackwards(InputAction.CallbackContext ctx) //move backwards with berth controls
    {
        combinedPowerIncreasing = true;
    }

    void BerthRight(InputAction.CallbackContext ctx) //move right with berth controls
    {
        isTurningRight = true;
    }

    void BerthLeft(InputAction.CallbackContext ctx) //move left with berth controls
    {
        isTurningLeft = true;
    }

    void BerthForwardsStop(InputAction.CallbackContext ctx) //stop moving forwards with berth controls
    {
        combinedPowerIncreasing = false;
    }

    void BerthBackwardsStop(InputAction.CallbackContext ctx) //stop moving backwards with berth controls
    {
        combinedPowerIncreasing = false;
    }

    void BerthRightStop(InputAction.CallbackContext ctx) //stop moving right with berth controls
    {
        isTurningRight = false;
    }

    void BerthLeftStop(InputAction.CallbackContext ctx) //stop moving left with berth controls
    {
        isTurningLeft = false;
    }

    private void Update()
    {
        if (combinedControlsEnabled)
        {
            maxEnginePower = 10f;
            minEnginePower = -5f;
            enginePowerChange = 5f;
            maxRot = 45f;
            minRot = -45f;
            rotChange = 5f;
            controlType = "Regular Controls";
        }
        else if (berthControlsEnabled)
        {
            maxEnginePower = 5;
            minEnginePower = -2f;
            enginePowerChange = 1f;
            maxRot = 25f;
            minRot = -25f;
            rotChange = 1f;
            controlType = "Berthing Controls";
        } else if(induviualControlsEnbaled)
        {
            maxEnginePower = 10f;
            minEnginePower = -5f;
            enginePowerChange = 5f;
            maxRot = 45f;
            minRot = -45f;
            rotChange = 5f;
            controlType = "Induvidual Controls";
        }

        if (combinedEnginePowerValue >= 1 || combinedEnginePowerValue <= -1)
        {
            isMoving = true;
        } else
        {
            isMoving = false;
        }

        if (combinedPowerIncreasing)
        {
            this.positiveCombinedEnginePower += Time.deltaTime * this.enginePowerChange;

            if (this.positiveCombinedEnginePower > maxEnginePower)
            {
                positiveCombinedEnginePower = maxEnginePower;
                combinedPowerIncreasing = false;
            }

            if (positiveCombinedEnginePower == maxEnginePower && negativeCombinedEnginePower < 0)
            {
                this.negativeCombinedEnginePower += Time.deltaTime * this.enginePowerChange;
                combinedPowerIncreasing = true;
            }
        }

        if (combinedPowerDecreasing)
        {
            this.negativeCombinedEnginePower -= Time.deltaTime * this.enginePowerChange;

            if (this.negativeCombinedEnginePower < minEnginePower)
            {
                negativeCombinedEnginePower = minEnginePower;
                combinedPowerDecreasing = false;
            }

            if (negativeCombinedEnginePower == minEnginePower && positiveCombinedEnginePower > 0)
            {
                this.positiveCombinedEnginePower -= Time.deltaTime * this.enginePowerChange;
                combinedPowerDecreasing = true;
            }
        }

        /*if (isTurningRight && isMoving)
        {
            this.rightRot += Time.deltaTime * this.rotChange;

            if (this.rightRot > maxRot)
            {
                rightRot = maxRot;
                isTurningRight = false;
            }

            if (rightRot == maxRot && leftRot < 0)
            {
                this.leftRot += Time.deltaTime * this.rotChange;
                isTurningRight = true;
            }
        }

        if (isTurningLeft && isMoving)
        {
            this.leftRot -= Time.deltaTime * this.rotChange;

            if (this.leftRot < minRot)
            {
                leftRot = minRot;
                isTurningLeft = false;
            }

            if (leftRot == minRot && rightRot > 0)
            {
                this.rightRot -= Time.deltaTime * this.rotChange;
                isTurningLeft = true;
            }
        }*/

        combinedEnginePowerValue = positiveCombinedEnginePower + negativeCombinedEnginePower;
        rotValue = rightRot + leftRot;

        Debug.Log("positive engine power " + positiveCombinedEnginePower + " negative engine Power " + negativeCombinedEnginePower + " current engine power " + combinedEnginePowerValue + " rotating left at " + leftRot + " rotating right at " + rightRot + " for value of " + rotValue + " isMoving= " + isMoving + " control Type = " + controlType);
    }
}