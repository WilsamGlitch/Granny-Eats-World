using UnityEngine;

public class MinigameAudio : MonoBehaviour
{
    [Header("---------- Audio Source ----------")]
    [SerializeField] AudioSource MusicSource;
    [SerializeField] AudioSource UFOSource;
    [SerializeField] AudioSource BGSource;
    [SerializeField] AudioSource SFXSource;

    [Header("---------- Audio Clip ----------")]
    public AudioClip cauldron;
    public AudioClip correctLetter;
    public AudioClip wrongLetter;
    public AudioClip fail;

    private void Start()
    {
        //BGSource.clip = ambiance;
        //BGSource.Play();

        MusicSource.clip = cauldron;
        MusicSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
}

