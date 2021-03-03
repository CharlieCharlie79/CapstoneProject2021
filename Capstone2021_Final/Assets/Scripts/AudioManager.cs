using UnityEngine.Audio;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

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
            instance.StopPlaying("Level_Theme");
            /*Destroy(gameObject);     
            return;*/
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


    public void StopPlaying(string sound)
    {
        Audio s = Array.Find(sounds, item => item.name == sound);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + " not found!");
            return;
        }

       // s.source.volume = s.volume * (1f + UnityEngine.Random.Range(-s.volumeVariance / 2f, s.volumeVariance / 2f));
       // s.source.pitch = s.pitch * (1f + UnityEngine.Random.Range(-s.pitchVariance / 2f, s.pitchVariance / 2f));

        s.source.Stop();
    }



}
