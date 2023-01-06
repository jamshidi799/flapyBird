using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinTriggerHandler : MonoBehaviour
{
    public LogicScript logic;

    public float speed;

    private void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    void Update()
    {
        Debug.Log(transform.rotation.y);
        transform.Rotate(Vector3.up * Time.deltaTime * speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        logic.addScore(1);
        Destroy(gameObject);
    }
}
