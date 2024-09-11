using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Killzone : MonoBehaviour
{
    public GameObject Retry;
    public void Jugar1()
    {
        SceneManager.LoadScene("ArkanoidLV1");
    }
    public void Jugar2()
    {
        SceneManager.LoadScene("ArkanoidLV2");
    }
}
