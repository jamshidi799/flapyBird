using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadObjectRemover : MonoBehaviour
{
    private float deadZone = -40;

    void Update()
    {
        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
