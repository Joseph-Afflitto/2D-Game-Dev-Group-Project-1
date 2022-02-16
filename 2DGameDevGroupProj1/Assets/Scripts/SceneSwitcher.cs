using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartGame()
    {
        SceneManager.LoadScene("GameLevel");
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void WinGame()
    {
        SceneManager.LoadScene("WinScreen");
    }
    public void Restart()
    {
        SceneManager.LoadScene("GameLevel");
        Time.timeScale = 1f;
    }
}
