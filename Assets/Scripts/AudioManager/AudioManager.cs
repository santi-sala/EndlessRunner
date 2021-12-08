using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager _Instance { get { return instance; } }
    private static AudioManager instance;

    [SerializeField] private float musicVolume = 1;

    private AudioSource music1;
    private AudioSource music2;
    private AudioSource sfxSource;

    private bool firstMusicSourceActive;

    private void Awake()
    {

        instance = this;
        DontDestroyOnLoad(this.gameObject);

        music1 = gameObject.AddComponent<AudioSource>();
        music2 = gameObject.AddComponent<AudioSource>();
        sfxSource = gameObject.AddComponent<AudioSource>();

        music1.loop = true;
        music2.loop = true;
    }

    public void PlayMusicWithFade(AudioClip musicCLip, float transitionTime = 1.0f )
    {
        // Which audiosourse is active
        AudioSource actitiveSource = firstMusicSourceActive ? music1 : music2;
        AudioSource newSource = firstMusicSourceActive ? music2 : music1;

        firstMusicSourceActive = !firstMusicSourceActive;

        newSource.clip = musicCLip;
        newSource.Play();

        StartCoroutine(UpdateXfadeMusic(actitiveSource, newSource, musicCLip, transitionTime));
    }

    private IEnumerator UpdateXfadeMusic(AudioSource original, AudioSource newSource, AudioClip music, float transitionTime)
    {
        if (!original.isPlaying)
        {
            original.Play();
        }

        newSource.Stop();
        newSource.clip = music;
        newSource.Play();

        float t = 0.0f;

        for (t = 0.0f; t <= transitionTime; t += Time.deltaTime)
        {
            original.volume = (musicVolume - ((t / transitionTime) * musicVolume));
            newSource.volume = (t / transitionTime) * musicVolume;
            yield return null;
        }

        original.volume = 0;
        newSource.volume = musicVolume;

        original.Stop();

    }

    public void PlaySFX(AudioClip sfx)
    {
        sfxSource.PlayOneShot(sfx);
    }
    public void PlaySFX(AudioClip sfx, float volume)
    {
        sfxSource.PlayOneShot(sfx, volume);
    }



}
