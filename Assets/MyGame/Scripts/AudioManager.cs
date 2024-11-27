using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField]
    private Sound[] sounds;
    void Awake()
    {
        foreach(Sound oneSound in sounds) {
            // zur laufzeit erzeugtes audio source  objekt
            oneSound.audioSource = gameObject.AddComponent<AudioSource>();
            // übernehme parameter von audio element
            oneSound.audioSource.volume = oneSound.volume;
            // pitch
            oneSound.audioSource.pitch = oneSound.pitch;
        }
        // foreach(Sound s in sounds) {
        //     gameObject.AddComponent<AudioSource>();
        // }
        // Alternative mit for schleife
        for(int i = 0; i < sounds.Length; i++)
        {
            Sound s = sounds[1];
        }
    }

    private Sound findSound(string soundName) {
        foreach(Sound oneSound in sounds) {
            if (oneSound.name == soundName) {
                return oneSound;
            }
        }
        Debug.Log("Sound not found");
        return null;
    }
    
    public void Play(string soundName) {
        findSound(soundName).audioSource.Play();
            
        
    }
    
    public void Pause(string soundName) {
        findSound(soundName).audioSource.Pause();
            
    }




    // Update is called once per frame
    void Update()
    {

        
    }
}
