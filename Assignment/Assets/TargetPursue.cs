using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetPursue : SteeringBehaviour
{
    public Boid leader;
    Vector3 targetPos;
    Vector3 worldTarget;

    Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - leader.transform.position;

        offset = Quaternion.Inverse(leader.transform.rotation) * offset;
    }

    public override Vector3 Calculate()
    {
        worldTarget = leader.transform.TransformPoint(offset);
        float dist = Vector3.Distance(worldTarget, transform.position);
        float time = dist / boid.maxSpeed;
        targetPos = gameObject.GetComponent<hshooting>().FindClosestEnemy().transform.position;
        force = boid.ArriveForce(targetPos);
        return force;

    }
}
