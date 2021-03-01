using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public Audio[] sounds;

    public static AudioManager instance;

    // Start is called before the first frame update
    void Awake()
    {

        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject); 

        foreach(Audio a in sounds)
        {
            a.source = gameObject.AddComponent<AudioSource>();
            a.source.clip = a.clip;

            a.source.volume = a.volume;
            a.source.pitch = a.pitch;
            a.source.loop = a.loop;
        }
    }

    void Start()
    {
        Play("Level_Theme");
    }
    public void Play (string name)
    {
       Audio a = Array.Find(sounds, sound => sound.name == name);
        if(a == null)
        {
            Debug.LogWarning("Audio: " + name + " not found!");
            return;
        }
        a.source.Play();
    }
}
