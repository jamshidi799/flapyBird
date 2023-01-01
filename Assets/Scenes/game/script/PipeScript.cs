using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PipeScript : MonoBehaviour
{
    public GameObject topPipe;
    public GameObject bottomPipe;
    public float speed = 10;
    private float deadZone = -40;
    public int gameLevel = 1;
    private Dictionary<int, Action> map;

    void Start()
    {
        map = new Dictionary<int, Action>();
        map.Add(1, Level1);
        map.Add(2, Level2);
        map.Add(3, Level3);
    }

    void Update()
    {
        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
        
        map[gameLevel]();

    }

    void Level1()
    {  
        transform.position += Vector3.left * speed * Time.deltaTime;
    }

    void Level2()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        transform.position += Vector3.down * 1 * Time.deltaTime;
    }

    void Level3()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        float factor = 0.5f;
        topPipe.transform.position += Vector3.down * Time.deltaTime * factor;
        bottomPipe.transform.position += Vector3.up * Time.deltaTime * factor;
    }
}