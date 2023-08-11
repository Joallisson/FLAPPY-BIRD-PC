using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Text scoreText;
    [SerializeField] private int score;
    [SerializeField] private GameObject gameOverObj;
    [SerializeField] private GameObject startGameObj;
    void Start()
    {
        startGameObj.SetActive(true);
        Time.timeScale = 0;
    }


    void Update()
    {
        scoreText.text = score.ToString();
    }

    public void StartButton()
    {
        Time.timeScale = 1f;
        gameOverObj.SetActive(false);
        startGameObj.SetActive(false);
    }

    public void GameOver()
    {
        gameOverObj.SetActive(true);
        Time.timeScale = 0;
    }
}
