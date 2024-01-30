using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MainMenu : MonoBehaviour
{
    public static bool isPaused;
    public float duration;
    public GameObject menuBar;
    private void Start()
    {
        Time.timeScale = 0;
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused)
            {
                Pause();
                isPaused = false;
                Show();
            }
            else
            {
                Resume();
                isPaused = true;
                Hide();
            }
        }
    }
    public void Hide()
    {
        LeanTween.moveLocalY(menuBar, 1000, duration).setIgnoreTimeScale(true); 
    }
    public void Show()
    {
        LeanTween.moveLocalY(menuBar, 0, duration).setIgnoreTimeScale(true);
    }
    void Resume() { Time.timeScale = 1;}
    void Pause(){Time.timeScale = 0; }

    public void StartGame()
    {
        isPaused = false;
        LeanTween.moveLocalY(menuBar, 1000, duration).setIgnoreTimeScale(true);
        Time.timeScale = 1;
    }
    public void OpenOptions()
    {

    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
