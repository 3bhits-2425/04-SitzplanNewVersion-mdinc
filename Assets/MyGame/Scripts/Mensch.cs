using UnityEngine;

public class Mensch : MonoBehaviour
{
    public string personName;
    public string rolleInKlasse;
    public Color augenFarbe;
    [SerializeField] private AudioSource myAudioSource;

    void Start() 
    {
        Debug.Log("Mein Name " + personName);
        Debug.Log("Meine Rolle " + rolleInKlasse);
        Debug.Log("Meine Augenfarbe " + augenFarbe);

        myAudioSource = GetComponent<AudioSource>();
    }

    void Update()
    {   //sobald die Leertaste gedrückt wird
        if(Input.GetKeyDown(KeyCode.Space)) {
            Debug.Log("Leertaste gedrueckt");
            //Audio Wiedergabe Starten
            myAudioSource.Play();
        } else if (Input.GetKeyUp(KeyCode.Space)) {
            Debug.Log("Leertaste Losgelassen");
            myAudioSource.Pause();
        }
        
    }
}
