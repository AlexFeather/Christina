using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField]
    float hydration = 1.0f;

    [SerializeField]
    Location position;

    private void FixedUpdate()
    {
        hydration -= 0.0001f;


    }

    public void PositionUpdate(Location newPosition)
    {
        if (position != newPosition)
            position = newPosition;
    }

    private void MoveTroughIntersection()
    {

    }

}
