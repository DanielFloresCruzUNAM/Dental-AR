using UnityEngine;

public class QuitarCaries : MonoBehaviour
{
    [Header("Efectos opcionales")]
    public ParticleSystem efectoDestruccion;
    public AudioClip sonidoDestruccion;

    [Header("Referencias")]
    public ManagerRetoDental managerRetoDental;

    private bool yaFueEliminada = false;

    void OnMouseDown()
    {
        if (!Application.isPlaying || yaFueEliminada) return;

        yaFueEliminada = true;

        // Efectos visuales y sonoros
        if (efectoDestruccion != null)
            Instantiate(efectoDestruccion, transform.position, Quaternion.identity);

        if (sonidoDestruccion != null)
            AudioSource.PlayClipAtPoint(sonidoDestruccion, transform.position);

        // Ocultar SOLO este objeto (la carie)
        gameObject.SetActive(false);

        // Notificar al manager
        if (managerRetoDental != null)
            managerRetoDental.CarieEliminada();
        else
            Debug.LogError("ManagerRetoDental no asignado en " + gameObject.name);
    }
}//prueba
