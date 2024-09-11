using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Victory : MonoBehaviour
{
    public GameObject VictoryPanel;

    public void Continuar()
    {
        SceneManager.LoadScene("ArkanoidLV2");
    }
    public void LoadMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

}
