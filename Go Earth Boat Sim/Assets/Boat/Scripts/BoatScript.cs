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

    float positiveEnginePower = 0f;
    float negativeEnginePower = 0f;
    public float enginePowerValue = 0f;
    float maxEnginePower = 10f;
    float minEnginePower = -5f;
    float enginePowerChange = 5f;

    float leftRot = 0f;
    float rightRot = 0f;
    float maxRot = 15f;
    float minRot = -15f;
    public float rotValue = 0f;
    float rotChange = 5f;

    bool boatControlsEnabled = true;
    bool berthControlsEnabled = false;
    bool isIncreasing = false;
    bool isDecreasing = false;
    bool isTurningLeft = false;
    bool isTurningRight = false;
    bool isMoving = false;
    bool isStopped = false;

    string controlType;

    void Awake()
    {
        inputs = new BoatInputs();

        inputs.BoatControls.EnginePowerUp.performed += epUp;
        inputs.BoatControls.EnginePowerUpStop.performed += epUpStop;
        inputs.BoatControls.EnginePowerDown.performed += epDown;
        inputs.BoatControls.EnginePowerDownStop.performed += epDownStop;
        inputs.BoatControls.RotateLeft.performed += rotLeft;
        inputs.BoatControls.RotateLeftStop.performed += rotLeftStop;
        inputs.BoatControls.RotateRight.performed += rotRight;
        inputs.BoatControls.RotateRightStop.performed += rotRightStop;
        inputs.BoatControls.Handbrake.performed += StopMove;
        inputs.BoatControls.ChangeControlType.performed += ChangeControls;

        inputs.BerthingControls.Forwards.performed += BerthForwards;
        inputs.BerthingControls.Backwards.performed += BerthBackwards;
        inputs.BerthingControls.Leftways.performed += BerthLeft;
        inputs.BerthingControls.Rightways.performed += BerthRight;
        inputs.BerthingControls.ForwardsStop.performed += BerthForwardsStop;
        inputs.BerthingControls.BackwardsStop.performed += BerthBackwardsStop;
        inputs.BerthingControls.LeftwaysStop.performed += BerthLeftStop;
        inputs.BerthingControls.RightwaysStop.performed += BerthRightStop;
        inputs.BerthingControls.ChangeControlTypes.performed += ChangeControlsBack;

        boatBody = GetComponent<Rigidbody>();
    }

    void OnEnable()
    {
        inputs.BoatControls.Enable();
    }

    void OnDisable()
    {
        inputs.BoatControls.Disable();
    }

    void epUp(InputAction.CallbackContext ctx) //epUp = Engine Power Up
    {
        isIncreasing = true;
    }

    void epUpStop(InputAction.CallbackContext ctx) // stop increasing engine power
    {
        isIncreasing = false;
    }

    void epDown(InputAction.CallbackContext ctx) //epDown = Engine Power Down
    {
        isDecreasing = true;
    }

    void epDownStop(InputAction.CallbackContext ctx) // stop decreasing engine power
    {
        isDecreasing = false;
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

    void ChangeControls(InputAction.CallbackContext ctx) //change controls to berthing controls and disable regulart controls 
    {
        if (!isMoving)
        {
            inputs.BoatControls.Disable();
            inputs.BerthingControls.Enable();
            boatControlsEnabled = false;
            berthControlsEnabled = true;
        }
    }

    void BerthForwards(InputAction.CallbackContext ctx) //move forward with berth controls
    {
        isIncreasing = true;
    }

    void BerthBackwards(InputAction.CallbackContext ctx) //move backwards with berth controls
    {
        isDecreasing = true;
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
        isIncreasing = false;
    }

    void BerthBackwardsStop(InputAction.CallbackContext ctx) //stop moving backwards with berth controls
    {
        isDecreasing = false;
    }

    void BerthRightStop(InputAction.CallbackContext ctx) //stop moving right with berth controls
    {
        isTurningRight = false;
    }

    void BerthLeftStop(InputAction.CallbackContext ctx) //stop moving left with berth controls
    {
        isTurningLeft = false;
    }

    void ChangeControlsBack(InputAction.CallbackContext ctx) //swap controls back to regular controls and disable berthing controls
    {
        if (!isMoving)
        {
            inputs.BerthingControls.Disable();
            inputs.BoatControls.Enable();
            boatControlsEnabled = true;
            berthControlsEnabled = false;
        }

    }

    private void Update()
    {
        if (boatControlsEnabled)
        {
            maxEnginePower = 10f;
            minEnginePower = -5f;
            enginePowerChange = 5f;
            maxRot = 45f;
            minRot = -45f;
            rotChange = 5f;
            controlType = "Regular controls";
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
        }

        if (enginePowerValue >= 1 || enginePowerValue <= -1)
        {
            isMoving = true;
        } else
        {
            isMoving = false;
        }

        if (isIncreasing)
        {
            this.positiveEnginePower += Time.deltaTime * this.enginePowerChange;

            if (this.positiveEnginePower > maxEnginePower)
            {
                positiveEnginePower = maxEnginePower;
                isIncreasing = false;
            }

            if (positiveEnginePower == maxEnginePower && negativeEnginePower < 0)
            {
                this.negativeEnginePower += Time.deltaTime * this.enginePowerChange;
                isIncreasing = true;
            }
        }

        if (isDecreasing)
        {
            this.negativeEnginePower -= Time.deltaTime * this.enginePowerChange;

            if (this.negativeEnginePower < minEnginePower)
            {
                negativeEnginePower = minEnginePower;
                isDecreasing = false;
            }

            if (negativeEnginePower == minEnginePower && positiveEnginePower > 0)
            {
                this.positiveEnginePower -= Time.deltaTime * this.enginePowerChange;
                isDecreasing = true;
            }
        }

        if (isTurningRight && isMoving)
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
        }

        enginePowerValue = positiveEnginePower + negativeEnginePower;
        rotValue = rightRot + leftRot;

        boatBody.AddForce(0, 0, enginePowerValue, ForceMode.Force);
        boatBody.AddTorque(transform.up * Torque * (rotValue / 100));

        Debug.Log("positive engine power " + positiveEnginePower + " negative engine Power " + negativeEnginePower + " current engine power " + enginePowerValue + " rotating left at " + leftRot + " rotating right at " + rightRot + " for value of " + rotValue + " isMoving= " + isMoving + " control Type = " + controlType);
    }
}