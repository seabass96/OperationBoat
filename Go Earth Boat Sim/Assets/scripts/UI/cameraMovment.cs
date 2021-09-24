using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Cinemachine;

public class cameraMovment : MonoBehaviour
{
    public enum cameraStates { FIRSTPERSON, BIRDSEYEVIEW, THIRDPERSON}
    public cameraStates currentstate;
    public GameObject cam;
    public float additionalHeightBEV;
    public Vector3 camOffset;
    public GameObject CinemMachine;
    public float ZoomeStrength = 0.4f;
    private BoatInputs inputs;
    private float zoomAmount;
    private CinemachineFreeLook.Orbit[] orbits;
    private float thirdPaersonCameZoomAmount = 0;

    private void Awake()
    {
        orbits = CinemMachine.GetComponent<CinemachineFreeLook>().m_Orbits;
        inputs = new BoatInputs();
        inputs.CombinedEngineControls.CameraZoom.performed += Zoom;
        inputs.CombinedEngineControls.ChangeCam.performed += ChangeCam;
    }

    private void OnEnable()
    {
        inputs.CombinedEngineControls.Enable();
    }

    private void OnDisable()
    {
        inputs.CombinedEngineControls.Disable();
    }

    void Zoom(InputAction.CallbackContext context)
    {
        float cont = context.ReadValue<float>();
        switch (currentstate)
        {
            case cameraStates.FIRSTPERSON:
                break;
            case cameraStates.BIRDSEYEVIEW:
                //add to y here based on mouse input
                

                if (cont > 0)
                {
                    zoomAmount -= ZoomeStrength;
                }
                else if (cont < 0)
                {
                    zoomAmount += ZoomeStrength;
                }
                Mathf.Clamp(zoomAmount, 2, 50);
                break;

            case cameraStates.THIRDPERSON:
                //increas ring radius orbits do this in zoom
                if (cont > 0)
                {
                    if (thirdPaersonCameZoomAmount > 0)
                    {
                        thirdPaersonCameZoomAmount -= ZoomeStrength;
                    }                       
                }
                else if (cont < 0)
                {
                    if (thirdPaersonCameZoomAmount  < 50)
                    {
                        thirdPaersonCameZoomAmount += ZoomeStrength;
                    }
                }
                break;
        }
    }

    private void ChangeCam(InputAction.CallbackContext context)
    {
        currentstate++;
        if ((int)currentstate > 2)
        {
            currentstate = 0;
        }
    }

    private void LateUpdate()
    {
        StateMachine();
        CameraZoom();
    }

    private void StateMachine()
    {
        switch (currentstate)
        {
            case cameraStates.FIRSTPERSON:
                CinemMachine.SetActive(false);
                cam.transform.position = gameObject.transform.position;
                cam.transform.rotation = gameObject.transform.rotation;
                break;

            case cameraStates.BIRDSEYEVIEW:
                CinemMachine.SetActive(false);
                //position
                Vector3 camPos = new Vector3(gameObject.transform.position.x,
                    gameObject.transform.position.y + additionalHeightBEV, 
                    gameObject.transform.position.z);

                cam.transform.position = camPos;

                //rotation
                float yPos = gameObject.transform.rotation.eulerAngles.y;
                Vector3 camRot = new Vector3(90, yPos, 0);
                cam.transform.rotation = Quaternion.Euler(camRot);
                break;

            case cameraStates.THIRDPERSON:
                CinemMachine.SetActive(true);
                break;

        }
    }

    private void CameraZoom()
    {
        switch (currentstate)
        {
            case cameraStates.FIRSTPERSON:
                break;
            case cameraStates.BIRDSEYEVIEW:
                //add to y here based on mouse input
                cam.transform.position += new Vector3(0, zoomAmount, 0);

                break;
            case cameraStates.THIRDPERSON:
                orbits[0].m_Radius = 12 + thirdPaersonCameZoomAmount;
                orbits[1].m_Radius = 17 + thirdPaersonCameZoomAmount;
                orbits[2].m_Radius = 12 + thirdPaersonCameZoomAmount;
                break;
        }
    }
}
