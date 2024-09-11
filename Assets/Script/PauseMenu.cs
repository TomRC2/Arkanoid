using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject MenuDePausa;
    private bool pausado = false;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pausado)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }


    public void Resume()
    {
        MenuDePausa.SetActive(false); 
        Time.timeScale = 1f; 
        pausado = false;
    }

    
    void Pause()
    {
        MenuDePausa.SetActive(true); 
        Time.timeScale = 0f; 
        pausado = true;
    }

    
    public void QuitGame()
    {
        Debug.Log("Saliendo del juego...");
        Application.Quit();
    }

    public void Restart()
    {
        SceneManager.LoadScene("Arkanoid");
    }
    public void LoadMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
}
