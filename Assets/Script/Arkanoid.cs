using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Arkanoid : MonoBehaviour
{
    public float speed = 10f;
    float horizontal;
    
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        transform.position += new Vector3(horizontal * speed * Time.deltaTime, 0,0);
    }
}
