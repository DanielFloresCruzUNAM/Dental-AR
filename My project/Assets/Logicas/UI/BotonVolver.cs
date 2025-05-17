using UnityEngine;
using UnityEngine.UI;

public class BotonVolver : MonoBehaviour
{
    public enum DestinoVolver { Principal, Retos }
    [SerializeField] DestinoVolver destino;
    [SerializeField] UIManager uiManager;
    
    private Button boton;

    void Start()
    {
        boton = GetComponent<Button>();
        
        if(destino == DestinoVolver.Principal)
            boton.onClick.AddListener(() => uiManager.MostrarMenuPrincipal());
        else
            boton.onClick.AddListener(() => uiManager.VolverDesdeReto1());
    }
}//prueba