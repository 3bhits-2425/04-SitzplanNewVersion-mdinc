using UnityEngine;
using TMPro; // Notwendig für TextMeshPro

public class AudioMenu : MonoBehaviour
{
    [SerializeField] private AudioSource myAudioSource;
    private TMP_Text playPauseText; // Referenz auf den TMP_Text
    private GameObject playPause; // Referenz auf den PlayPause-Button

    // Initialisiere die AudioSource und den PlayPause-Text erst wenn das spiel läuft
    public void Awake()
    {
        myAudioSource = GetComponent<AudioSource>();

        // Suche den PlayPause-Button nach Name
        playPause = GameObject.Find("PlayPause");

        // Hole die TMP_Text-Komponente aus dem Button
        if (playPause != null)
        {
            playPauseText = playPause.GetComponentInChildren<TMP_Text>();
        }
        else
        {
            Debug.LogError("PlayPause-Button nicht gefunden!");
        }
    }

    public void Update() 
    {
        //aendere den Button-Text
        //abhängig vom audioSrc zustand
        if(myAudioSource.isPlaying)
        {
            playPauseText.SetText("Pause");
        } else {
            playPauseText.SetText("Play");
        }
    }
    // Funktion zum Abspielen des Audios
    public void PlayAudio()
    {
        myAudioSource.Play();
    }

    // Funktion zum Pausieren des Audios
    public void PauseAudio()
    {
        myAudioSource.Pause();
    }

    // Kombinierte Play/Pause-Funktion
    public void PlayPause()
    {
        if (myAudioSource.isPlaying) // Überprüft ob Audio gerade spielt
        {
            myAudioSource.Pause(); // Audio pausieren
        }
        else
        {
            myAudioSource.Play(); // Audio abspielen
        }
    }
}