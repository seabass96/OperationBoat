using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flocking : MonoBehaviour
{

    [Header("Spawn Setup")]
    public FlockAgent fish;
    public int flockSize;
    public Vector3 flockBounds;
    public FlockAgent[] flock;

    [Header("speedSetup")]
    [Range(0, 10)]
    public float minSpeed;
    [Range(0, 10)]
    public float MaxSpeed;


    [Header("detectionDistances")]
    [Range(0,10)]
    public float cohesuionDistance;

    [Range(0, 10)]
    public float avoidenceDistance;

    [Range(0, 10)]
    public float alignmentDistance;

    [Range(0, 100)]
    public float boundstDistance;

    //[Range(0, 10)]
    //public float obsticleDistance;


    [Header("behaviourWeights")]
    [Range(0, 10)]
    public float cohesuionWeights;

    [Range(0, 10)]
    public float avoidenceWeights;

    [Range(0, 10)]
    public float alignmentWeights;

    [Range(0, 10)]
    public float boundstWeights;

    //[Range(0, 10)]
    //public float obsticleWeights;





    private void Start()
    {
        spwanFlock();
    }

    private void Update()
    {
        for (int i = 0; i < flock.Length; i++)
        {
            flock[i].MoveAgent();
        }
    }

    private void spwanFlock()
    {
        flock = new FlockAgent[flockSize];
        for (int i = 0; i < flockSize; i++)
        {
            Vector3 randomVec = Random.insideUnitSphere;
            randomVec = new Vector3(randomVec.x * flockBounds.x,
                                    randomVec.y * flockBounds.y,
                                    randomVec.z * flockBounds.z);

            Vector3 spawPos = transform.position + randomVec;
            Quaternion rotation = Quaternion.Euler(0, Random.Range(0, 360), 0);
            flock[i] = Instantiate(fish, spawPos, rotation);
            flock[i].AssignFlocking(this);
            flock[i].initSpeed(Random.Range(minSpeed, MaxSpeed));
        }
    }

}
