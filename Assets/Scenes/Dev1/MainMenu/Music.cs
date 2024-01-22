using UnityEngine;

public class Music : MonoBehaviour
{
    [SerializeField]
    private AudioClip musicClip;

    [SerializeField]
    [Range(0f, 1f)]
    private float volume = 0.5f;

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
            musicSource.volume = volume; // Set the volume
            musicSource.Play();
        }
    }
}
