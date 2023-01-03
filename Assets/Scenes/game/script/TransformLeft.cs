using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformLeft : MonoBehaviour
{
    public float speed = 10;

    void Update()
    {
        applytTransform();
    }

    private void applytTransform()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
