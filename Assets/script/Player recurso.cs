using UnityEngine;

public class ResourceCollector : MonoBehaviour
{
    [System.Serializable]
    public class ResourceData
    {
        public string nome;
        public int quantidade;
    }

    public ResourceData[] inventario; // Lista de recursos do jogador

    // M�todo para adicionar recurso ao invent�rio
    public void ColetarRecurso(string nomeRecurso, int quantidade)
    {
        for (int i = 0; i < inventario.Length; i++)
        {
            if (inventario[i].nome == nomeRecurso)
            {
                inventario[i].quantidade += quantidade;
                Debug.Log($"Coletou {quantidade}x {nomeRecurso}. Total: {inventario[i].quantidade}");
                return;
            }
        }

        Debug.LogWarning($"Recurso '{nomeRecurso}' n�o encontrado no invent�rio.");
    }
}