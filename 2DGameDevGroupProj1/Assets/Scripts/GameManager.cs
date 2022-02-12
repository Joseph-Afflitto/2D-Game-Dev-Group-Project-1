using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static bool gamePaused;
    public GameObject pauseMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            gamePaused = !gamePaused;
            PauseGame();
        }
    }
    public void PauseGame()
    {
        if (gamePaused)
        {
            pauseMenu.SetActive(true);
            Time.timeScale = 0f;
            gamePaused = true;
            Debug.Log("Game paused.");
        }
        else
        {
            pauseMenu.SetActive(false);
            Time.timeScale = 1f;
            gamePaused = false;
            Debug.Log("Game resumed.");
        }
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
