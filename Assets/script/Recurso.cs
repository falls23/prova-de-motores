using UnityEngine;

public class ResourceItem : MonoBehaviour
{
    public string nomeRecurso;
    public int quantidade = 1;

    private void OnTriggerEnter(Collider other)
    {
        ResourceCollector coletor = other.GetComponent<ResourceCollector>();

        if (coletor != null)
        {
            coletor.ColetarRecurso(nomeRecurso, quantidade);
            Destroy(gameObject); // Remove o recurso do cenário
        }
    }
}