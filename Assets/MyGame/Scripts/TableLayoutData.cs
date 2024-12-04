using UnityEngine;
//filename besagt defaultes speichern
//menuname besagt wie es im menu angezeigt wird
[CreateAssetMenu(fileName = "NewTableLayout", menuName = "Seatplan/table")]
public class TableLayout: ScriptableObject
{
    public int row;
    public int column;
    public float tableSpacing; //abstand zwischen den tischen
    public float chairSpacing; //Abstand zwischen stühlen
}
