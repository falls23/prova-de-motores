using UnityEngine;
using TMPro; // Necess�rio para TextMeshPro

public class UIInventario : MonoBehaviour
{
    public ResourceCollector coletor; // Refer�ncia ao script de coleta
    public TextMeshProUGUI textoInventario; // Texto que mostra os recursos

    void Update()
    {
        if (coletor != null && textoInventario != null)
        {
            textoInventario.text = GerarTextoInventario();
        }
    }

    string GerarTextoInventario()
    {
        string texto = "Recursos:\n";

        foreach (var recurso in coletor.inventario)
        {
            texto += $"{recurso.nome}: {recurso.quantidade}\n";
        }

        return texto;
    }
}