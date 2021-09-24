using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloaterScript : MonoBehaviour
{

    public Rigidbody rigidBody;
    public float DBS = 1f; //DBS = Depth Before Submerged
    public float DA = 3f; //DA = displacement ammount
    public int floatPoints = 1;
    public float waterDrag = 1;
    public float waterAngularDrag = 0.5f;

    private void FixedUpdate()
    {

        rigidBody.AddForceAtPosition(Physics.gravity/ floatPoints, transform.position, ForceMode.Acceleration);

        float waveHeight = WaveManager.instance.GetWaveHeight(transform.position.x);

        if(transform.position.y < waveHeight) 
        {
            float DM = Mathf.Clamp01((waveHeight - transform.position.y) / DBS) * DA; // DM = Displacement ammount
            rigidBody.AddForceAtPosition(new Vector3(0f, Mathf.Abs(Physics.gravity.y) * DM, 0f), transform.position, ForceMode.Acceleration);
            rigidBody.AddForce(DM * -rigidBody.velocity * waterDrag * Time.fixedDeltaTime, ForceMode.VelocityChange);
            rigidBody.AddTorque(DM * -rigidBody.angularVelocity * waterAngularDrag * Time.fixedDeltaTime, ForceMode.VelocityChange);
        }
        
    }
}
