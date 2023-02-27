using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    private int score = 0;
    private float elapsedTime;
    private float bestScore;
    private bool isPlay;

    [SerializeField] private Text scoreText;

    [SerializeField] private GameObject gameOverSet;
    private Text gameOverScoreText;
   
    void Start()
    {
        gameOverScoreText = gameOverSet.transform.Find("GameOverScoreText").gameObject.GetComponent<Text>();
        gameOverSet.SetActive(false);
        elapsedTime = 0;
        isPlay = true;
    }

    void Update()
    {
        if(isPlay)
            elapsedTime += Time.deltaTime;
    }

    public void AddSocre()
    {
        score++;
        scoreText.text = score.ToString();
    }

    public void GameOver()
    {
        gameOverSet.SetActive(true);
        bestScore = JudgmentBestScore(score + elapsedTime);
        gameOverScoreText.text = "BestScore:" + bestScore.ToString("F0");
        isPlay = false;
        Time.timeScale = 0;
    }

    public float JudgmentBestScore(float x)
    {
        if (x > PlayerPrefs.GetFloat("Best", 0))
        {
            PlayerPrefs.SetFloat("Best", x);
            return x;
        }
            
        return PlayerPrefs.GetFloat("Best", score + elapsedTime);
    }

}
