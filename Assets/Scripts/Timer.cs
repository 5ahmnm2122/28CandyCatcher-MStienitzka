using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 10;
    public bool timerIsRunning = false;
    public Text timeText;
    public Text scoreText;
    public Storage infoStorage;

    private void Start()
    {
        // Starts the timer automatically
        timerIsRunning = true;
        infoStorage.score = 0;
    }

    void Update()
    {
        infoStorage.time = timeRemaining;
        timeText.text = Mathf.Round(infoStorage.time).ToString();
        scoreText.text = infoStorage.score.ToString();


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
                timerIsRunning = false;
            }
        }
    }
}
