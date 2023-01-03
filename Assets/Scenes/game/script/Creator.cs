using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Creator : MonoBehaviour
{
    public GameObject pipe;
    public GameObject triangle;
    public GameObject multiTriangle;
    public GameObject capsule;

    public float rate = 2;
    private float timer = 0;
    public float heightOffset = 10;
    private Dictionary<int, Action> map;

    // Start is called before the first frame update
    void Start()
    {
        map = new Dictionary<int, Action>();
        map.Add(0, newPipe);
        map.Add(1, newBottomTriangle);
        map.Add(2, newTopTriangle);
        map.Add(3, newBottomMultiTriangle);
        map.Add(4, newTopMultiTriangle);
        map.Add(5, newCapsule);
        newBottomTriangle();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < rate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            map[UnityEngine.Random.Range(0, map.Count)]();
            //map[5]();
            timer = 0;
        }
    }

    private void newPipe()
    {
        float lowestHeight = transform.position.y - heightOffset;
        float highestHeight = transform.position.y + heightOffset;

        GameObject newPipe = Instantiate(pipe, new Vector3(transform.position.x, UnityEngine.Random.Range(lowestHeight, highestHeight), 0), transform.rotation);
        newPipe.GetComponent<PipeScript>().gameLevel = UnityEngine.Random.Range(1, 4);
    }

    private void newBottomTriangle()
    {
        Instantiate(triangle, new Vector3(transform.position.x, -10, 0), transform.rotation);
    }

    private void newTopTriangle()
    {
        Instantiate(triangle, new Vector3(transform.position.x, 10, 0), new Quaternion(180, 0, 0, 0));
    }

    private void newBottomMultiTriangle()
    {
        Instantiate(multiTriangle, new Vector3(transform.position.x, -10, 0), transform.rotation);
    }

    private void newTopMultiTriangle()
    {
        Instantiate(multiTriangle, new Vector3(transform.position.x, 10, 0), new Quaternion(180, 0, 0, 0));
    }

    private void newCapsule()
    {
        float lowestHeight = transform.position.y - heightOffset;
        float highestHeight = transform.position.y + heightOffset;

        Instantiate(capsule,
            new Vector3(transform.position.x, UnityEngine.Random.Range(lowestHeight, highestHeight), 0),
            new Quaternion(0, 0, UnityEngine.Random.Range(-0.4f, 0.4f), 1));

    }
}
