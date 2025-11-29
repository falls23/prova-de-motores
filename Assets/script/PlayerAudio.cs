using UnityEngine;

public class PlayerAudio : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip coinSound;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayCoinSound()
    {
        audioSource.PlayOneShot(coinSound);
    }
}