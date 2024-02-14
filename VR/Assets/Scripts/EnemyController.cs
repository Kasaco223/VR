using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Transform playerTransform; // Referencia al transform del jugador
    private Rigidbody rb; // Referencia al Rigidbody del objeto

    // La velocidad de movimiento del objeto
    public float speed = 0.05f;

    // Se llama al inicio del juego
    void Start()
    {
        // Buscamos el objeto del jugador por su tag
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;

        // Obtenemos el Rigidbody del objeto actual
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Hacemos que el objeto mire hacia el jugador
        Vector3 lookDirection = playerTransform.position - transform.position;
        transform.rotation = Quaternion.LookRotation(lookDirection);

        // Movemos el objeto utilizando el Rigidbody
        rb.velocity = transform.forward/16 * speed;
    }
}
