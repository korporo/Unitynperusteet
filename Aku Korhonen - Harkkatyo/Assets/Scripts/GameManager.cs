using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour

{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI saveText;
    public TextMeshProUGUI gameOverText;
    public Button restartButton;

    public bool isGameActive;
    public float timeLeft;

    private int score;
    private int saveCounter;

    // Start is called before the first frame update

    private void Start()
    {
        // For goals scored.
        score = 0;
        UpdateScore(0);

        // For saves made.
        SaveCounter(0);
        saveCounter = 0;

        isGameActive = true;
        timeLeft = 10;
    }
    // Update is called once per frame
    void Update()
    {
        if (isGameActive)
        {
            timeLeft -= Time.deltaTime;
            timerText.SetText("Time: " + Mathf.Round(timeLeft));
        }

        if (timeLeft <= 0)
        {
            GameOver();
        }
    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }

    public void SaveCounter (int savesToAdd)
    {
        saveCounter += savesToAdd;
        saveText.text = "Saves: " + saveCounter;
    }

    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
        isGameActive = false;

    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
