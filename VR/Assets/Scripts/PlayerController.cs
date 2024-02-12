using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 1f; // Velocidad de movimiento

    void Update()
    {
        // Obtener las entradas de teclado
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Verticall");

        // Calcular la dirección del movimiento
        Vector3 moveDirection = new Vector3(horizontalInput, verticalInput, 0f).normalized;

        // Aplicar movimiento solo en los ejes X y Z (arriba y los lados)
        Vector3 movement = transform.TransformDirection(moveDirection) * moveSpeed * Time.deltaTime;
        transform.Translate(movement/8);
    }
}
