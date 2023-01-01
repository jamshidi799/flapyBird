using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D rigidBody;
    public float strength;
    private LogicScript logic;
    private bool isBirdAlive = true;
    private int cameraSize = 17;
    private Actions actions;

    private void Awake()
    {
        actions = new Actions();
        actions.Player.Enable();
    }

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    void Update() {
        if (actions.Player.Fly.IsPressed() && isBirdAlive)
        {
            rigidBody.velocity = Vector2.up * strength;
        }

        if (Mathf.Abs(transform.position.y) > cameraSize)
        {
            finishTheGame();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        finishTheGame();
    }

    private void finishTheGame()
    {
        isBirdAlive = false;
        logic.gameOver();
    }
}