using UnityEngine;
using UnityEngine.UI;

public class BotonReto1Caries : MonoBehaviour
{
    [SerializeField] UIManager uiManager;
    private Button boton;

    void Start()
    {
        boton = GetComponent<Button>();

        // Si uiManager no fue asignado manualmente, buscarlo automáticamente
        if (uiManager == null)
        {
            uiManager = FindObjectOfType<UIManager>();
            if (uiManager == null)
            {
                Debug.LogError("❌ UIManager no fue asignado ni encontrado en la escena.");
                return;
            }
        }

        boton.onClick.AddListener(() => uiManager.IniciarReto1Caries());
    }
}
