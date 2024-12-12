using UnityEngine;
using UnityEngine.UI;

public class Student : MonoBehaviour
{
    [SerializeField] private Image studentImage; // Bereits vorhandenes Image im Prefab

    // Methode, um Daten aus StudentData zu setzen
    public void Initialize(StudentData data)
    {
        if (data != null)
        {
            // Sprite des Images aus StudentData setzen
            if (studentImage != null)
            {
                studentImage.sprite = data.studentImage;
            }
        }
        else
        {
            Debug.LogWarning("StudentData ist null!");
        }
    }
}
