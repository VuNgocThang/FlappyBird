using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject gameOver;

    public Text textScore;


    public int score;

    private void Start()
    {
        score = 0;
    }

    private void Update()
    {
        if (score > 5)
        {
            Time.timeScale = 1.2f;
        }

        if(score > 10)
        {
            Time.timeScale = 2f;
        }
    }
    public void GameOver()
    {
        gameOver.SetActive(true);
        Time.timeScale = 0;
        Debug.Log("game over");
    }

    public void IncreaseScore()
    {
        score++;
        Debug.Log("scrore" + score);
        textScore.text = score.ToString();
    }

}
