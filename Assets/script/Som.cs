using UnityEngine;

public class Som : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player")) ;
        {
            AudioSource.SetActive(true);     
        }
    }

   
}