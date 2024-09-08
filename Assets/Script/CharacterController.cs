using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float velocidad;
    public float Salto;
    public LayerMask Suelo;
    public Collision2D Collision;
    

    private Rigidbody2D rigidBody;
    private BoxCollider2D boxcollider;
    private bool MirandoALaDerecha = true;
    private bool EnElSuelo = true;


    private void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        boxcollider = GetComponent<BoxCollider2D>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && EnElSuelo)
        {
            ProcesarSalto();
        }
        ProcesarMovimiento();
        
    }
    void ProcesarSalto()
    {
        rigidBody.AddForce(Vector2.up * Salto, ForceMode2D.Impulse);
        EnElSuelo = false;
    }
    void ProcesarMovimiento()
    {
        float Inputmovimiento = Input.GetAxis("Horizontal");
        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();

        rigidbody.velocity = new Vector2(Inputmovimiento * velocidad, rigidbody.velocity.y);
        GestionarOrientacion(Inputmovimiento);
    }
    void GestionarOrientacion(float inputMovimiento)
    {
        if ((MirandoALaDerecha = true && inputMovimiento < 0) || (MirandoALaDerecha = false && inputMovimiento > 0))
        {
            MirandoALaDerecha = !MirandoALaDerecha;
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        }
    }

    void OnCollisionEnter2D(Collision2D Collision)
    {
        if (Collision.gameObject.CompareTag("Suelo"))
        {
            EnElSuelo = true;
        }
    }

    void OnCollisionExit2D(Collision2D Collision)
    {
        if (Collision.gameObject.CompareTag("Suelo"))
        {
            EnElSuelo = false;
        }
    }

}
