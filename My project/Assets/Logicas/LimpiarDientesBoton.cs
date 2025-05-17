using UnityEngine;
using UnityEngine.UI;

public class HideCanvas : MonoBehaviour
{
    [Header("Referencias UI")]
    public GameObject retoDentalCanvas;  // Canvas del reto dental
    public GameObject imageTarget;       // Image Target con el modelo
    public GameObject InstruccionesUI;
    public GameObject AprendeMenu;
    

    [Header("Botón Limpiar Dientes")]//prueba
    public Button limpiarDientesButton;
    public Button backButton;
    
    

    void Start()
    {
        // Asignación del evento al botón "Limpiar Dientes"
        limpiarDientesButton.onClick.AddListener(HideRetoDentalCanvas);
        backButton.onClick.AddListener(RegresoDeMenu);
        
    }

    // Método para ocultar el canvas del reto dental y mostrar el Image Target
    
    void RegresoDeMenu()
    {
        try
        {
            retoDentalCanvas.SetActive(true);
            InstruccionesUI.SetActive(false);
            imageTarget.SetActive(false);
            AprendeMenu.SetActive(false);
        }
        catch (System.Exception e)
        {
            Debug.LogError("Error al ocultar el canvas o mostrar el Image Target: " + e.Message);
        }
    }
    
    
    
    void HideRetoDentalCanvas()
    {
        try
        {
            // Oculta el canvas y muestra el Image Target
            retoDentalCanvas.SetActive(false);
            InstruccionesUI.SetActive(true);
            imageTarget.SetActive(true);
        }
        catch (System.Exception e)
        {
            Debug.LogError("Error al ocultar el canvas o mostrar el Image Target: " + e.Message);
        }
    }
    
}
