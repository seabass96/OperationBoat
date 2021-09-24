using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDController : MonoBehaviour
{

    public Slider throtlle1;
    public Slider throtlle2;
    public Slider rudder;
    private BoatScript boat;

    private void Start()
    {
        boat = FindObjectOfType<BoatScript>();
    }

    private void Update()
    {
        UpdateThrottle();
        UpdateRudder();
    }

    private void UpdateThrottle()
    {
        //this wont work when we have more than one boat but handle that when you get to it 
        throtlle1.value = boat.combinedEnginePowerValue;
        throtlle1.value = boat.combinedEnginePowerValue;
    }

    private void UpdateRudder()
    {
        rudder.value = boat.rotValue;
    }
}
