using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.InputSystem;

public class RubysMovement : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 movimiento;
    public InputAction MoveAction;
    public Vector2 posicionInicial;
    float movX;
    float movY;
    public float velocidad;
    void Start()
    {
        MoveAction.Enable();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movimiento = MoveAction.ReadValue<Vector2>();
        Debug.Log(movimiento);
        /*Vector2 posicion = (Vector2)transform.position + movimiento * Time.deltaTime * velocidad;
        transform.position = posicion;
        */
    }
    private void FixedUpdate()
    {
        Vector2 posicion = (Vector2)rb.position + movimiento * Time.deltaTime * velocidad;
        rb.MovePosition(posicion);
    }
}
