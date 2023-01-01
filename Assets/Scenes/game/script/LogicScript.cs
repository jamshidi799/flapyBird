using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    private int score = 0;
    public Text textScore;
    public GameObject gameOverScreen;


    public void addScore()
    {
        score++;
        textScore.text = score.ToString();
    }

    public void resetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Debug.Log("reset");
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
