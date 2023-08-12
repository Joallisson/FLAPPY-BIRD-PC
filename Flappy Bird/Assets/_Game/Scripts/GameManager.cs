using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Text scoreText;
    [SerializeField] private int score;
    [SerializeField] private GameObject gameOverObj;
    [SerializeField] private GameObject startGameObj;
    private Player player;
    void Start()
    {
        player = FindObjectOfType<Player>();
        player.enabled = false; //NÃO FAZER O PLAYER PULAR QUANDO EU CLICO PARA INICIAR O JOGO
        startGameObj.SetActive(true);
        Time.timeScale = 0;
    }


    void Update()
    {
       
    }

    public void StartButton()
    {
        Time.timeScale = 1f;
        gameOverObj.SetActive(false);
        startGameObj.SetActive(false);
        player.enabled = true;
    }

    public void GameOver()
    {
        gameOverObj.SetActive(true);
        Time.timeScale = 0;
        player.enabled = false; //NÃO FAZER O PLAYER PULAR QUANDO EU CLICO PARA INICIAR O JOGO
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(0);
        player.enabled = true;
    }

    public void Scoring()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
