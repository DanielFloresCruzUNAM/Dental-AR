using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToothInfoSingle : MonoBehaviour
{
    [Header("Modelo de muela")]
    public GameObject toothModel;      // El modelo 3D de la muela
    public GameObject objectToShow;    // El objeto 3D que aparecerá al hacer clic

    void Start()
    {
        // Asegúrate de que el objeto esté oculto al inicio
        if (objectToShow != null)
            objectToShow.SetActive(false);
    }

    void OnMouseDown()//prueba
    {
        // Verifica que el objeto no sea nulo
        if (objectToShow != null)
        {
            // Alterna la visibilidad del objeto 3D al hacer clic
            bool isActive = objectToShow.activeSelf;
            objectToShow.SetActive(!isActive);
        }
        else
        {
            Debug.LogWarning("No se ha asignado el objeto a mostrar.");
        }
    }
}

