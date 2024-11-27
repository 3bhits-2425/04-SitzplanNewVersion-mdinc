using UnityEngine;

[CreateAssetMenu(fileName = "NewStudent", menuName = " ")]
public class StudentData : ScriptableObject
{
    public string studentName;
    public Color eyeColor;
    public Sprite studentImage;
    public AudioClip studentClip;

}

