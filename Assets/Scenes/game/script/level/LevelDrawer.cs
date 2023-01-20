using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelDrawer : MonoBehaviour
{
    public GameObject level;
    public GameObject canvas;

    private int currentLevel;

    void Start()
    {
        currentLevel = PlayerPrefs.GetInt("level", 1);
        for (int i = 1; i <= 32; i++)
        {
            draw(i);
        }
    }

    private void draw(int index)
    {
        int offset = index - 1;
        int y = 315 - (offset / 8) * 200;
        int x = -680 + (offset % 8) * 200;
        GameObject l = Instantiate(level, new Vector3(x, y, 0), transform.rotation);
        l.transform.SetParent(canvas.transform, false);
        l.name = "level" + index;
        l.GetComponentInChildren<TextMeshProUGUI>().text = index.ToString();


        if (index <= currentLevel)
        {
            l.GetComponentInChildren<TextMeshProUGUI>().enabled = true;
            l.GetComponentInChildren<SpriteRenderer>().enabled = false;

            l.GetComponent<Button>().onClick.AddListener(() =>
            {
                Debug.Log("click");
                SceneManager.LoadScene("Level " + index);
            });
        }
        else
        {
            l.GetComponentInChildren<TextMeshProUGUI>().enabled = false;
            l.GetComponentInChildren<SpriteRenderer>().enabled = true;
            l.GetComponent<Button>().enabled = false;
        }
    }

}
