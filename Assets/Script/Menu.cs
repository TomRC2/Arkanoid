using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject MenuPrincipal;
   
    private void Jugar()
    {
        SceneManager.LoadScene("ArkanoidLV1");
    }
}
