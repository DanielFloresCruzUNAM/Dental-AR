using UnityEngine;

public class DentalModel : MonoBehaviour
{
    public GameObject[] cariesPrefabs;  // Array de prefabs de caries
    private GameObject currentCaries;

    void Start()
    {
        // Generar la primera caries al inicio
        GenerarCaries();
    }

    void GenerarCaries()
    {
        // Seleccionar una posición aleatoria dentro del modelo dental
        Vector3 randomPosition = new Vector3(Random.Range(-0.5f, 0.5f), Random.Range(-0.5f, 0.5f), Random.Range(-0.5f, 0.5f));
        
        // Elegir aleatoriamente un prefab de caries
        int randomIndex = Random.Range(0, cariesPrefabs.Length);
        currentCaries = Instantiate(cariesPrefabs[randomIndex], transform.position + randomPosition, Quaternion.identity, transform);
    }

    void Update()
    {
        // Verificar clic izquierdo del mouse
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject == currentCaries)
                {
                    // Eliminar la caries actual
                    Destroy(currentCaries);

                    // Generar una nueva caries en una posición aleatoria
                    GenerarCaries();
                }
            }
        }
    }
}
