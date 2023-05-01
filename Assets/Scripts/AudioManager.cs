using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("---------Audio Source----------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource sfxSource;

    [Header("----------Audio Clip-----------")]
    public AudioClip background;
    public AudioClip flap;
    public AudioClip point;
    public AudioClip death;
    public AudioClip yls;

    // Start is called before the first frame update
    void Start()
    {
        musicSource.clip = background;
        musicSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        sfxSource.PlayOneShot(clip);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
