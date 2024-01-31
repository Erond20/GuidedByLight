using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public static bool isPaused;
    [SerializeField] float duration;
    public GameObject menuBar;
    [SerializeField] LeanTweenType easeType;
    
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
        LeanTween.moveLocalY(menuBar, 1000, duration).setIgnoreTimeScale(true).setEase(easeType); 
    }
    public void Show()
    {
        LeanTween.moveLocalY(menuBar, 100, duration).setIgnoreTimeScale(true).setEase(easeType);
    }
    public void ScaleUp()
    {
        LeanTween.scale(menuBar,transform.localScale*2, duration);
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
    public void Restart()
    {
        SceneManager.LoadScene("Enemy");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
