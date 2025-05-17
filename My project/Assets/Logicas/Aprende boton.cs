using UnityEngine;
using UnityEngine.UI;

public class Aprendeboton : MonoBehaviour
{
    [Header("Referencias UI")]
    public GameObject mainMenuCanvas;
    public GameObject learnMenuCanvas;
    public GameObject dentalModel;

    [Header("Botones")]
    public Button learnButton;
    public Button backButton;

    void Start()
    {
        // Configuración inicial
        ShowMainMenu(true);

        // Asignación CORREGIDA de eventos
        learnButton.onClick.AddListener(() => ShowMainMenu(false)); // Usando lambda
        backButton.onClick.AddListener(ReturnToMainMenu); // Método sin parámetros
    }

    // Método modificado
    void ShowMainMenu(bool show)
    {
        mainMenuCanvas.SetActive(show);
        learnMenuCanvas.SetActive(!show);
        dentalModel.SetActive(!show);
    }

    // Nuevo método para el botón de regreso
    void ReturnToMainMenu()
    {
        ShowMainMenu(true);
    }
}