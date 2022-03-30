using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Countdown : MonoBehaviour
{
    private float totalTime = 90;
    public Text countDownText;//在UI里显示时间
    private float intervalTime = 1;

    public GameObject GameOverImage;
    private bool isGameOver;

    //Use this for initialization
    public void Start()
    {
        countDownText.text = string.Format("{0:D2}:{1:D2}",
            (int)totalTime / 60, (int)totalTime % 60);

    }
    private void Update()
    {
        if(!isGameOver)
        {
            if (totalTime > 0)
            {
                intervalTime -= Time.deltaTime;
                if (intervalTime <= 0)
                {
                    intervalTime += 1;
                    totalTime--;
                    countDownText.text = string.Format("{0:D2}:{1:D2}",
                        (int)totalTime / 60, (int)totalTime % 60);
                }
            }
            else
            {
                GameOver();
            }
        }

    }
    public void GameOver()
    {
        if(!GameOverImage.activeSelf)
        {
            GameOverImage.SetActive(true);
            Time.timeScale = 0;
            isGameOver = true;
            Cursor.lockState = CursorLockMode.Confined;
        }
    }
    public void RestartGame()
    {
        SceneManager.LoadScene("BattleBear");
    }
    public void StartInterface()
    {
        SceneManager.LoadScene("Start Scene");
    }
}
