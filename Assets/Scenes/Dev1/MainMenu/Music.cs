using UnityEngine;

public class Music : MonoBehaviour
{
    [SerializeField]
    private AudioClip musicClip;

    private AudioSource musicSource;

    void Awake()
    {
        int musicPlayers = FindObjectsOfType<Music>().Length;
        if (musicPlayers > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);

            musicSource = GetComponent<AudioSource>();
            if (musicSource == null)
            {
                musicSource = gameObject.AddComponent<AudioSource>();
            }

            musicSource.clip = musicClip;
            musicSource.loop = true;
            musicSource.Play();
        }
    }
}
