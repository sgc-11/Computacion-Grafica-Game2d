using UnityEngine;

public class SpriteDirectionHandler : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private Transform playerTransform;
    private Vector3 lastPosition;
    
    [SerializeField] private float minMovementThreshold = 0.01f; // Umbral mínimo para detectar movimiento

    private void Start()
    {
        // Obtener el SpriteRenderer de este objeto (Body)
        spriteRenderer = GetComponent<SpriteRenderer>();
        
        if (spriteRenderer == null)
        {
            Debug.LogError("No se encontró un componente SpriteRenderer en el objeto Body");
            return;
        }
        
        // Obtener referencia al objeto padre (Player)
        playerTransform = transform.parent;
        if (playerTransform == null)
        {
            Debug.LogError("Este objeto debe ser hijo de otro objeto (Player)");
            return;
        }
        
        // Inicializar la última posición conocida
        lastPosition = playerTransform.position;
    }

    private void Update()
    {
        // Calcular el desplazamiento en este frame
        Vector3 currentPosition = playerTransform.position;
        Vector3 movement = currentPosition - lastPosition;
        
        // Actualizar la dirección del sprite basado en el movimiento horizontal
        if (Mathf.Abs(movement.x) > minMovementThreshold)
        {
            // Si se mueve hacia la derecha
            if (movement.x > 0)
            {
                spriteRenderer.flipX = false;
            }
            // Si se mueve hacia la izquierda
            else if (movement.x < 0)
            {
                spriteRenderer.flipX = true;
            }
        }
        
        // Actualizar la última posición conocida
        lastPosition = currentPosition;
    }
}