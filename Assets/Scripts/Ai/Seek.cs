using System;
using UnityEngine;
public class Seek : SteeringBehaviour
{
    public Vector2 TargetPoint = Vector2.zero;

    public override Vector2 GetVelocity()
    {
        return ((TargetPoint - (Vector2)transform.position).normalized * agent.MaxVelocity) - agent.CurrentVelocity;
    }
}