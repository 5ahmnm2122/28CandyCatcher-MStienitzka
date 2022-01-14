using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float timeRemaining;
    public bool timerIsRunning = false;
    public Text timeText;
    public Image[] Hearts;
    public Text scoreText;
    public Storage infoStorage;

    private void Start()
    {
        // Starts the timer automatically
        timerIsRunning = true;
        infoStorage.score = 0;
        infoStorage.lives = 3;
    }

    void Update()
    {
        infoStorage.time = timeRemaining;
        timeText.text = Mathf.Round(infoStorage.time).ToString();
        scoreText.text = infoStorage.score.ToString();

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Intro");
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            SceneManager.LoadScene("EndScene");
        }

        if (infoStorage.lives == 2)
        {
            Destroy(Hearts[2]);

        }
        else if (infoStorage.lives == 1)
        {
            Destroy(Hearts[1]);
        }
        else if (infoStorage.lives <= 0)
        {
            Destroy(Hearts[0]);
            SceneManager.LoadScene("EndScene");
        }

        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                SceneManager.LoadScene("EndScene");
                timerIsRunning = false;
            }
        }
    }
}
