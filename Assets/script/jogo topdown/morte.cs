using UnityEngine;
using UnityEngine.SceneManagement;

public class morte : MonoBehaviour
{
    public int maxHealth = 10;
    private int currentHealth;

    // Nome da cena que será carregada ao morrer
    public string deathSceneName = "GameOver";

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        SceneManager.LoadScene(deathSceneName);
    }
}