using UnityEngine;
using System.Collections.Generic;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;
    
    [Header("Audio Sources")]
    private AudioSource sfxSource;
    private AudioSource musicSource;
    
    [Header("SFX")]
    public AudioClip shootSound;
    public AudioClip enemyHitSound;
    public AudioClip enemyDeathSound;
    public AudioClip buildingPlaceSound;
    public AudioClip levelUpSound;
    public AudioClip lootPickupSound;
    public AudioClip buttonClickSound;
    public AudioClip errorBuzzSound;
    
    [Header("Music")]
    public AudioClip menuMusic;
    public AudioClip colonyMusic;
    public AudioClip raidMusic;
    
    [Header("Settings")]
    [Range(0f, 1f)] public float sfxVolume = 1f;
    [Range(0f, 1f)] public float musicVolume = 0.5f;
    public float musicFadeTime = 1f;
    
    private Dictionary<string, AudioClip> audioClips = new Dictionary<string, AudioClip>();
    private Coroutine musicFadeCoroutine;
    
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            
            SetupAudioSources();
            LoadAudioClips();
        }
        else
        {
            Destroy(gameObject);
        }
    }
    
    void SetupAudioSources()
    {
        sfxSource = gameObject.AddComponent<AudioSource>();
        sfxSource.playOnAwake = false;
        sfxSource.volume = sfxVolume;
        
        musicSource = gameObject.AddComponent<AudioSource>();
        musicSource.playOnAwake = false;
        musicSource.loop = true;
        musicSource.volume = musicVolume;
    }
    
    void LoadAudioClips()
    {
        audioClips["shoot"] = shootSound;
        audioClips["hit"] = enemyHitSound;
        audioClips["death"] = enemyDeathSound;
        audioClips["build"] = buildingPlaceSound;
        audioClips["levelup"] = levelUpSound;
        audioClips["pickup"] = lootPickupSound;
        audioClips["click"] = buttonClickSound;
        audioClips["error"] = errorBuzzSound;
    }
    
    public void PlaySFX(AudioClip clip, float volume = 1f)
    {
        if (clip != null && sfxSource != null)
        {
            sfxSource.PlayOneShot(clip, volume * sfxVolume);
        }
    }
    
    public void PlaySFX(string clipName, float volume = 1f)
    {
        if (audioClips.ContainsKey(clipName))
        {
            PlaySFX(audioClips[clipName], volume);
        }
    }
    
    public void PlayMusic(AudioClip musicClip, bool fade = true)
    {
        if (musicClip == null || musicSource == null) return;
        
        if (musicSource.isPlaying && fade)
        {
            if (musicFadeCoroutine != null)
            {
                StopCoroutine(musicFadeCoroutine);
            }
            musicFadeCoroutine = StartCoroutine(FadeMusic(musicClip));
        }
        else
        {
            musicSource.clip = musicClip;
            musicSource.volume = musicVolume;
            musicSource.Play();
        }
    }
    
    System.Collections.IEnumerator FadeMusic(AudioClip newClip)
    {
        float startVolume = musicSource.volume;
        
        for (float t = 0; t < musicFadeTime; t += Time.deltaTime)
        {
            musicSource.volume = Mathf.Lerp(startVolume, 0, t / musicFadeTime);
            yield return null;
        }
        
        musicSource.Stop();
        musicSource.clip = newClip;
        musicSource.Play();
        
        for (float t = 0; t < musicFadeTime; t += Time.deltaTime)
        {
            musicSource.volume = Mathf.Lerp(0, musicVolume, t / musicFadeTime);
            yield return null;
        }
        
        musicSource.volume = musicVolume;
        musicFadeCoroutine = null;
    }
    
    public void StopMusic(bool fade = true)
    {
        if (musicSource == null) return;
        
        if (fade)
        {
            if (musicFadeCoroutine != null)
            {
                StopCoroutine(musicFadeCoroutine);
            }
            musicFadeCoroutine = StartCoroutine(FadeOutMusic());
        }
        else
        {
            musicSource.Stop();
        }
    }
    
    System.Collections.IEnumerator FadeOutMusic()
    {
        float startVolume = musicSource.volume;
        
        for (float t = 0; t < musicFadeTime; t += Time.deltaTime)
        {
            musicSource.volume = Mathf.Lerp(startVolume, 0, t / musicFadeTime);
            yield return null;
        }
        
        musicSource.Stop();
        musicSource.volume = musicVolume;
        musicFadeCoroutine = null;
    }
    
    public void SetSFXVolume(float volume)
    {
        sfxVolume = Mathf.Clamp01(volume);
        if (sfxSource != null)
        {
            sfxSource.volume = sfxVolume;
        }
    }
    
    public void SetMusicVolume(float volume)
    {
        musicVolume = Mathf.Clamp01(volume);
        if (musicSource != null)
        {
            musicSource.volume = musicVolume;
        }
    }
    
    public void PlayButtonClick()
    {
        PlaySFX(buttonClickSound);
    }
    
    public void PlayErrorSound()
    {
        PlaySFX(errorBuzzSound);
    }
    
    public void PlayMenuMusic()
    {
        PlayMusic(menuMusic);
    }
    
    public void PlayColonyMusic()
    {
        PlayMusic(colonyMusic);
    }
    
    public void PlayRaidMusic()
    {
        PlayMusic(raidMusic);
    }
}