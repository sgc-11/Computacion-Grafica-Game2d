using UnityEngine;

public class appearingHongo : MonoBehaviour
{
    private SpriteRenderer objectRenderer;
    private Collider2D objectCollider;

    private void Start()
    {
        // Obtener los componentes correctos
        objectRenderer = GetComponent<SpriteRenderer>();
        objectCollider = GetComponent<Collider2D>();

        if (objectRenderer != null)
        {
            objectRenderer.enabled = false; // Hacer el hongo invisible al inicio
        }

        if (objectCollider != null)
        {
            objectCollider.enabled = true; // Mantener el collider activo
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Verificar si el jugador colisiona con este objeto
        if (other.CompareTag("Player"))
        {
            // Hacer visible el objeto
            if (objectRenderer != null)
            {
                objectRenderer.enabled = true; // Activar la visibilidad del hongo
            }
            
            // Desactivar el collider para evitar múltiples activaciones
            if (objectCollider != null)
            {
                objectCollider.enabled = false;
            }
        }
    }
}