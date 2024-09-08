using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.VersionControl;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class Ejerciciso : MonoBehaviour
{
    public string nombre = "Tom";
    public int edad = 0;
    public int num1 = 0;
    public int num2 = 0;
    void Start()
    {
        Debug.Log("Hola! " + nombre + ", sos un crack!!!");
        
        int suma = Suma(num1, num2);
        Debug.Log("La suma es: " + suma);
        veredad();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    int Suma(int num1, int num2)
    {
        int resultado = num1 + num2;
        return resultado;
    }
    void veredad()
    {
        if (edad <= 18)
        {
            Debug.Log("Hola Joven, como se encuentra?");
        }
        else
        {
            Debug.Log("Hola viejo, todo bien?");
        }
    }
}
