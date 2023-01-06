using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public Rigidbody2D rigidBody;
    public float strength;
    private LogicManager logic;
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
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
    }

    void Update() {
        if (actions.Player.Fly.IsPressed() && isBirdAlive && transform.position.y < cameraSize - 3)
        {
            rigidBody.velocity = Vector2.up * strength;
        }

        if (transform.position.y < cameraSize * -1)
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
