using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartInterface : MonoBehaviour
{
    public GameObject Guide;
    private bool isPaused;
    void Start()
    {
        Time.timeScale = 1;
        Guide.SetActive(false);
        isPaused = false;
    }
    public void StartGame()
    {
        SceneManager.LoadScene("BattleBear");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void GuideGame()
    {
        if (Guide.activeSelf)
        {

            Guide.SetActive(false);
            Time.timeScale = 1;
            isPaused = false;
        }

        else if (!Guide.activeSelf)
        {
            Guide.SetActive(true);
            Time.timeScale = 0;
            isPaused = true;
        }
    }
}
