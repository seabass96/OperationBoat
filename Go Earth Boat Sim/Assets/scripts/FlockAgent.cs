using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlockAgent : MonoBehaviour
{

    public float FOVAngle;
    public float smoothDamp;
    private List<FlockAgent> cohesionNeighbours = new List<FlockAgent>();
    private List<FlockAgent> alighnmentNeighbours = new List<FlockAgent>();
    private List<FlockAgent> avoidenceNeighbours = new List<FlockAgent>();
    private Flocking assignedFlock;
    private Vector3 currentVelocity;
    private float speed;
    private Transform trans;

    private void Awake()
    {
        trans = transform;
    }

    public void AssignFlocking(Flocking flock)
    {
        assignedFlock = flock;
    }

    public void initSpeed(float speed)
    {
        this.speed = speed;
    }

    public void MoveAgent()
    {
        findNeighbour(); //find all agents neer this agent
        CalculateSpeed(); //ge tye average speed of alkl neighbours

        Vector3 cohesionVector = CalculateCohesionVector() * assignedFlock.cohesuionWeights; //get the direction baseed on teh neighbours
        Vector3 avoidenceVector = CalculateAvoidenceVector() * assignedFlock.avoidenceWeights; 
        Vector3 alighnmentVector = CalculateAlighnmentVector() * assignedFlock.alignmentWeights;
        Vector3 boundsVector = CalculateBoundsVector() * assignedFlock.boundstWeights;
       // Vector3 obsticleAvoidenceVector = CalculateObsticleAvoidanceVector() * assignedFlock.obsticleWeights;

        Vector3 moveVector = cohesionVector + avoidenceVector + alighnmentVector + boundsVector;
        //creat the movment vector based on the cohesion giving it a velosity and smoothign it 
        moveVector = Vector3.SmoothDamp(trans.forward, moveVector, ref currentVelocity, smoothDamp);
        //normalize teh move vector then multiply it by the speed
        moveVector = moveVector.normalized * speed;


        trans.forward = moveVector; //make tthe forward vector of the trasform the move ment direction
        trans.position += moveVector * Time.deltaTime; //apply movmnet and multiply by delta time
        
        
        
        //clamp teh fish under water
        trans.position = new Vector3(trans.position.x,
                                        Mathf.Clamp(trans.position.y, -200, -1),
                                        trans.position.z);
    }

   
    private void CalculateSpeed()
    {
        if (cohesionNeighbours.Count == 0) return;
        speed = 0;
        //set teh speeed to average speed of all neighbors
        for (int i = 0; i < cohesionNeighbours.Count; i++)
        {
            speed += cohesionNeighbours[i].speed; //add up all the speeds of all agents
        }

        speed /= cohesionNeighbours.Count; //get teh average speed
        speed = Mathf.Clamp(speed, assignedFlock.minSpeed, assignedFlock.MaxSpeed); //clamp that speed between the min a amax
    }


    private void findNeighbour()
    {
        //clear the list of all memebrs
        cohesionNeighbours.Clear();
        alighnmentNeighbours.Clear();
        avoidenceNeighbours.Clear();

        var allAgents = assignedFlock.flock; //get teh whoel flock
        for (int i = 0; i < allAgents.Length; i++)
        {
            var currentAgent = allAgents[i]; //set up the surrent agent that is being looked at 
            if (currentAgent != this) // iof the current agent is this agent
            {
                float currentNeighbourDistanceSqr = Vector3.SqrMagnitude(currentAgent.trans.position - trans.position); //find teh magnitude quared
                if (currentNeighbourDistanceSqr <= assignedFlock.cohesuionDistance * assignedFlock.cohesuionDistance) //see if the magnitude suared is smaller than the cohesion distance squared
                {
                    cohesionNeighbours.Add(currentAgent); //if it is this agent is a neighbour
                }
                
                if (currentNeighbourDistanceSqr <= assignedFlock.alignmentDistance * assignedFlock.alignmentDistance) //see if the magnitude suared is smaller than the cohesion distance squared
                {
                    alighnmentNeighbours.Add(currentAgent); //if it is this agent is a neighbour
                }
                
                if (currentNeighbourDistanceSqr <= assignedFlock.avoidenceDistance * assignedFlock.avoidenceDistance) //see if the magnitude suared is smaller than the cohesion distance squared
                {
                    avoidenceNeighbours.Add(currentAgent); //if it is this agent is a neighbour
                }
            }
        }
    }
    private Vector3 CalculateCohesionVector()
    {
        Vector3 cohesionVector = Vector3.zero; //reset the vector
        //if theer are no neighbours withing its cohesion return nothing end the algo
        if (cohesionNeighbours.Count == 0)
        {
            return cohesionVector;
        }

        // rteset the amaount of neighbours in teh fov
        int neighboursInFOV = 0;
        for (int i = 0; i < cohesionNeighbours.Count; i++)//loop through all neighbours
        {
            //if teh neighbour is withing the FOV
            if (IsInFOV(cohesionNeighbours[i].trans.position))
            {
                neighboursInFOV++; //increas neighbour count
                cohesionVector += cohesionNeighbours[i].trans.position; //add the position to the cohesion vector
            }
        }

        //if after that theer is no neigbourts in fov exit algo
        if (neighboursInFOV == 0)
        {
            return  Vector3.zero;
        }

        //else fide teh average of teh vector
        cohesionVector /= neighboursInFOV;
        cohesionVector -= trans.position; //take away the current psoition so it dosent push towards itself
        cohesionVector = Vector3.Normalize(cohesionVector); //normalize the vectore
        return cohesionVector; //return teh direction
    }

    private Vector3 CalculateAlighnmentVector()
    {
        Vector3 alighnmentVector = trans.forward;
        if (alighnmentNeighbours.Count == 0)
        {
            return trans.forward;
        }

        int neighboursInFOV = 0;
        for (int i = 0; i < alighnmentNeighbours.Count; i++)//loop through all neighbours
        {
            //if teh neighbour is withing the FOV
            if (IsInFOV(alighnmentNeighbours[i].trans.position))
            {
                neighboursInFOV++; //increas neighbour count
                alighnmentVector += alighnmentNeighbours[i].trans.forward; //add the position to the cohesion vector
            }
        }

        //if after that theer is no neigbourts in fov exit algo
        if (neighboursInFOV == 0)
        {
            return trans.forward;
        }
        alighnmentVector /= neighboursInFOV;
        //alighnmentVector -= trans.position; //take away the current psoition so it dosent push towards itself
        alighnmentVector = Vector3.Normalize(alighnmentVector); //normalize the vectore
        return alighnmentVector; //return teh direction
    }

    private Vector3 CalculateAvoidenceVector()
    {
        Vector3 avoidanceVector = Vector3.zero;
        if (avoidenceNeighbours.Count == 0)
        {
            return Vector3.zero;
        }

        int neighboursInFOV = 0;
        for (int i = 0; i < avoidenceNeighbours.Count; i++)//loop through all neighbours
        {
            //if teh neighbour is withing the FOV
            if (IsInFOV(avoidenceNeighbours[i].trans.position))
            {
                neighboursInFOV++; //increas neighbour count
                avoidanceVector += trans.position - avoidenceNeighbours[i].trans.position;
            }
        }

        //if after that theer is no neigbourts in fov exit algo
        if (neighboursInFOV == 0)
        {
            return Vector3.zero;
        }
        avoidanceVector /= neighboursInFOV;
       // avoidanceVector -= trans.position; //take away the current psoition so it dosent push towards itself
        avoidanceVector = Vector3.Normalize(avoidanceVector); //normalize the vectore
        return avoidanceVector; //return teh direction
    }

    private Vector3 CalculateBoundsVector()
    {
        Vector3 centerOffset = assignedFlock.transform.position - trans.position;
        bool isNearCenter = (centerOffset.magnitude / assignedFlock.boundstDistance <= 0.9);
        return isNearCenter ? centerOffset : Vector3.zero;
    }

    //private Vector3 CalculateObsticleAvoidanceVector()
    //{

    //}

    private bool IsInFOV(Vector3 pos)
    {
        //see if teh anglke is withing teh bounds of teh fov
        return Vector3.Angle(trans.forward, pos - trans.position) <= FOVAngle;
    }
}
