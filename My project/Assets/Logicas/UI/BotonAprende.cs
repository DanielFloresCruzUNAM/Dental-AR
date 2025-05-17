using UnityEngine;
using UnityEngine.UI;

public class BotonAprende : MonoBehaviour
{
    [SerializeField] UIManager uiManager;
    private Button boton;

    void Start()
    {
        boton = GetComponent<Button>();
        boton.onClick.AddListener(() => uiManager.MostrarModoAprende());
    }
}//prueba