using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAIController : MonoBehaviour
{
    private Transform playerTransform; // Referencia al transform del jugador
    public NavMeshAgent nav; // Referencia al componente NavMeshAgent

    // Se llama al inicio del juego
    void Start()
    {
        // Obtener referencias a los componentes necesarios
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        nav = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        // Configurar la ruta hacia la posición del jugador
        nav.SetDestination(playerTransform.position);
        transform.LookAt(playerTransform);
    }
}
