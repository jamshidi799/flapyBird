using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicManager : MonoBehaviour
{

    public Text textScore;
    public GameObject gameOverScreen;
    public GameObject levelCompleteScreen;

    private int score = 0;
    private bool isLevelComplete = false;

    public void addScore(int count)
    {
        score += count;
        textScore.text = score.ToString();
    }

    public void resetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        if (!isLevelComplete)
            gameOverScreen.SetActive(true);
    }

    public void LevelComplete()
    {
        isLevelComplete = true;
        levelCompleteScreen.SetActive(true);
    }
}
