using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToggleMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool GameIsPaused = false;
    public static bool GameIsStarted = false;
    public GameObject pauseMenuUI;

    void Start()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0.0f;
        Time.fixedDeltaTime = 0.0f;
        GameIsPaused = true;
        //Cursor.visible = true;
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            if (GameIsPaused)
            {
                StartSim();
            }
            else
            {
                Pause();
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Start", LoadSceneMode.Single);
        }
    }

    public void StartSim()
    {
        pauseMenuUI.SetActive(false);
        GameIsStarted = true;
        Time.timeScale = 1.0f;
        Time.fixedDeltaTime = 1.0f;
        GameIsPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0.0f;
        Time.fixedDeltaTime = 0.0f;
        GameIsPaused = true;
        GameIsStarted = false;
    }

    public void BackToMain()
    {
        Time.timeScale = 1f;
       
    }
}
