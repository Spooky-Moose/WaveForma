using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public static bool isPaused;
    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
        else if(Input.GetKeyDown(KeyCode.Keypad1))
        {
            GoToVisualizerOne();
        }
        else if(Input.GetKeyDown(KeyCode.Keypad2))
        {
            GoToVisualizerTwo();
        }
        else if(Input.GetKeyDown(KeyCode.Keypad3))
        {
            GoToVisualizerThree();
        }
        else if(Input.GetKeyDown(KeyCode.Keypad4))
        {
            GoToVisualizerFour();
        }
        else if(Input.GetKeyDown(KeyCode.Keypad5))
        {
            GoToVisualizerFive();
        }
        else if(Input.GetKeyDown(KeyCode.Keypad6))
        {
            GoToVisualizerSix();
        }
        else if(Input.GetKeyDown(KeyCode.Keypad7))
        {
            GoToVisualizerSeven();
        }
        else if(Input.GetKeyDown(KeyCode.Keypad8))
        {
            GoToVisualizerEight();
        }
        else if(Input.GetKeyDown(KeyCode.Keypad9))
        {
            GoToVisualizerNine();
        }
        else if(Input.GetKeyDown(KeyCode.Keypad0))
        {
            GoToVisualizerTen();
        }
        else if(Input.GetKeyDown(KeyCode.Space))
        {
            GoToMainMenu();
        }
    }

    //Public Functions for transitioning scenes when a specific button is pressed
    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void GoToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("SampleScene");
    }

    public void GoToVisualizerOne()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Visualizer 1");
    }

    public void GoToVisualizerTwo()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Visualizer 2");
    }

    public void GoToVisualizerThree()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Visualizer 3");
    }

    public void GoToVisualizerFour()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Visualizer 4");
    }

    public void GoToVisualizerFive()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Visualizer 5");
    }

    public void GoToVisualizerSix()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Visualizer 6");
    }

    public void GoToVisualizerSeven()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Visualizer 7");
    }

    public void GoToVisualizerEight()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Visualizer 8");
    }

    public void GoToVisualizerNine()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Visualizer 9");
    }

    public void GoToVisualizerTen()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Visualizer 10");
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
