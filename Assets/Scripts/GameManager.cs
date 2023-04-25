using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject gameOver;

    public GameObject playGame;

    public GameObject playAgain;

    public GameObject pause;

    public Text textScore;


    public int score;
    private void Awake()
    {

        Time.timeScale = 0f;
    }

    private void Start()
    {
        score = 0;
    }

    public void IncreaseScore()
    {
        score++;
        Debug.Log("scrore" + score);
        textScore.text = score.ToString();
    }

    public void Play()
    {
        playGame.SetActive(false);
        pause.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Pause()
    {
        pause.SetActive(true);
        Time.timeScale = 0f;
    }

    public void GameOver()
    {
        gameOver.SetActive(true);
        Time.timeScale = 0;
        Debug.Log("game over");
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("Game");
    }

}
