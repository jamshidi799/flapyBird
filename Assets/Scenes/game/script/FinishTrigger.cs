using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishTrigger : MonoBehaviour
{
    public LogicManager logicManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        logicManager.LevelComplete();
    }
}
