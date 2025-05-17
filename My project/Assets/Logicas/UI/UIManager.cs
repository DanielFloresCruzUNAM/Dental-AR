using UnityEngine;

public class UIManager : MonoBehaviour
{
    [Header("Menús Principales")]
    public GameObject menuPrincipal;
    public GameObject menuAprende;
    public GameObject menuPrincipalRetos;
    public GameObject menuReto1Caries;
    public GameObject victoriaCanvas;

    [Header("Contenido del Image Target")]
    public GameObject learnContent;       // Modelos del modo "Aprender"
    public GameObject challengeContent;   // Modelos del modo "Reto" (incluye caries y trofeo)

    [Header("Image Target")]
    public GameObject imageTarget;

    [Header("Referencias Clave")]
    public ManagerRetoDental managerRetoDental;

    void Start()
    {
        ConfigurarEstadosIniciales();
        MostrarMenuPrincipal();
    }

    void ConfigurarEstadosIniciales()
    {
        // Asegurar que todo esté desactivado al inicio
        learnContent.SetActive(false);
        challengeContent.SetActive(false);
        victoriaCanvas.SetActive(false);
        imageTarget.SetActive(true); // ImageTarget siempre visible
    }

    // ---------------------- MÉTODOS PARA BOTONES ----------------------
    public void MostrarMenuPrincipal()
    {
        // Desactivar todos los menús
        menuPrincipal.SetActive(true);
        menuAprende.SetActive(false);
        menuPrincipalRetos.SetActive(false);
        menuReto1Caries.SetActive(false);
        victoriaCanvas.SetActive(false);

        // Ocultar contenido de retos/aprender
        OcultarTodoContenido();
        if (managerRetoDental != null && managerRetoDental.modeloExito != null)
        managerRetoDental.modeloExito.SetActive(false);
    }

    public void MostrarModoAprende()
    {
        menuPrincipal.SetActive(false);
        menuAprende.SetActive(true);

        // Mostrar solo el contenido de aprendizaje
        learnContent.SetActive(true);

        // Ocultar el contenido del reto por si quedó activo
        challengeContent.SetActive(false);

        // Ocultar la UI de victoria
        victoriaCanvas.SetActive(false);

        // Ocultar el trofeo
        if (managerRetoDental != null && managerRetoDental.modeloExito != null)
            managerRetoDental.modeloExito.SetActive(false);
    }


    public void MostrarMenuRetos()
    {
        menuPrincipal.SetActive(false);
        menuPrincipalRetos.SetActive(true);
    }

    public void IniciarReto1Caries()
    {
        menuPrincipalRetos.SetActive(false);
        menuReto1Caries.SetActive(true);
        challengeContent.SetActive(true); // Mostrar caries y trofeo (aunque el trofeo está oculto inicialmente)
        managerRetoDental.ResetearReto(); // Reinicia el estado del reto
    }

    public void VolverDesdeReto1()
    {
        // Oculta la UI de reto y victoria
        menuReto1Caries.SetActive(false);
        victoriaCanvas.SetActive(false);

        // Oculta el contenido visual del reto
        challengeContent.SetActive(false);

        // Regresa al menú de selección de retos
        MostrarMenuRetos();
    }


    // ---------------------- LÓGICA DE VICTORIA ----------------------
    public void MostrarVictoriaUI()
    {
        victoriaCanvas.SetActive(true);    // Activar Canvas de Victoria
        menuReto1Caries.SetActive(false);  // Ocultar menú del reto
    }

    void OcultarTodoContenido()
    {
        learnContent.SetActive(false);
        challengeContent.SetActive(false);
    }
}//pruebas