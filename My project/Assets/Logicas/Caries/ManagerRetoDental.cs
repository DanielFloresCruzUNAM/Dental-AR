using UnityEngine;
using System.Collections.Generic;

public class ManagerRetoDental : MonoBehaviour
{
    [Header("Caries del reto")]
    public List<QuitarCaries> caries; // Asigna los 7 objetos caries con este script
    private int contadorCaries = 0;

    [Header("Referencias")]
    public GameObject modeloExito;       // Trofeo
    public UIManager uiManager;          // Manejador de UI

    public void ResetearReto()
    {
        contadorCaries = 0;

        foreach (var carie in caries)
        {
            if (carie != null)
            {
                // Reactivar la carie
                carie.gameObject.SetActive(true);

                // Resetear la lógica del script
                carie.enabled = true;

                // Resetear el estado interno
                typeof(QuitarCaries)
                    .GetField("yaFueEliminada", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                    ?.SetValue(carie, false);
            }
        }

        if (modeloExito != null)
            modeloExito.SetActive(false);

        Debug.Log("Reto reiniciado correctamente");
    }


    public void CarieEliminada()
    {
        contadorCaries++;

        Debug.Log("Caries eliminadas: " + contadorCaries);

        if (contadorCaries >= caries.Count)
        {
            MostrarVictoria();
        }
    }

    private void MostrarVictoria()
    {
        if (modeloExito != null)
            modeloExito.SetActive(true);

        if (uiManager != null)
            uiManager.MostrarVictoriaUI();
        else
            Debug.LogWarning("UIManager no asignado en ManagerRetoDental");
    }
}//prueba 
