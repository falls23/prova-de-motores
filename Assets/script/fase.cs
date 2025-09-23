using UnityEngine;
using UnityEngine.SceneManagement;

public class fase : MonoBehaviour
{
    public string nomeDaCena;
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player") && nomeDaCena != "")
        {
            SceneManager.LoadScene(nomeDaCena);          
        }
    }
}