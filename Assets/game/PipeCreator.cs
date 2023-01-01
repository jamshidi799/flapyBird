using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeCreator : MonoBehaviour
{
    public GameObject pipe;
    public float rate = 2;
    private float timer = 0;
    public float heightOffset = 10;

    // Start is called before the first frame update
    void Start()
    {
        newPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < rate)
        {
            timer += Time.deltaTime;
        } else
        {
            newPipe();
            timer = 0;
        }
    }

    private void newPipe()
    {
        float lowestHeight = transform.position.y - heightOffset;
        float highestHeight = transform.position.y + heightOffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestHeight, highestHeight), 0), transform.rotation);
    }
}
