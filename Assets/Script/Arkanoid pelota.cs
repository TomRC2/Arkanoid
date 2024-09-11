using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Arkanoidpelota : MonoBehaviour
{
    public Vector2 velocidadInicial;
    private Rigidbody2D pelota;
    public Collision2D collision;
    bool moviendose;
    public GameObject VictoryPanel;
    public GameObject Retry;
    public Puntos sumarScore;
    public int puntos;
    void Start()
    {
        pelota = GetComponent<Rigidbody2D>();
        Time.timeScale = 1f;

    }

    
    void Update()
    {
        if (!moviendose)
        {
            pelota.velocity = velocidadInicial;
            moviendose = true;
        }
        Victoria();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ladrillos"))
        {
            Destroy(collision.gameObject);
            sumarScore.Contador(10);
            
        }
        if (collision.gameObject.CompareTag("Killzone"))
        {
            Time.timeScale = 0f;
            Retry.SetActive(true);
        }
        
    }

    void Victoria()
    {
        GameObject[] bricks = GameObject.FindGameObjectsWithTag("Ladrillos");
        if (bricks.Length == 0) 
        {
            VictoryPanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    
}
