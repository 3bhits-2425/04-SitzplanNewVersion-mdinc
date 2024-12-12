using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Manager : MonoBehaviour
{
    [SerializeField] private TableLayout tableLayout;
    [SerializeField] private StudentData[] students;
    [SerializeField] private GameObject tablePrefab;
    [SerializeField] private GameObject chairPrefab;
    [SerializeField] private GameObject studentPrefab;
    [SerializeField] private List<GameObject> chairlist;


    private void Start()
    {   
         chairlist = new List<GameObject>(); // list initialisierung
        // Tische und Stühle in einem Grid platzieren
        for (int row = 0; row < tableLayout.row; row++)
        {
            for(int col = 0; col < tableLayout.column; col++)
            {
                Vector3 tabelPosition = new Vector3 (col* tableLayout.tableSpacing,0,row* tableLayout.tableSpacing);
                 // Tisch erstellen und den Manager als Parent setzen mittels transform
                GameObject table = Instantiate(tablePrefab, tabelPosition, Quaternion.identity, transform);
                // Stuhlpositionen innerhalb des Tisches finden
                Transform pos1 = table.transform.Find("ChairPos1");
                Transform pos2 = table.transform.Find("ChairPos2");
                Transform posStudent1 = table.transform.Find("StudentPos1");
                Transform posStudent2 = table.transform.Find("StudentPos2");
 
                if (pos1 != null)
                { 
                    GameObject chair = Instantiate(chairPrefab, pos1.position, pos1.rotation,table.transform);
                    chairlist.Add(chair);
                }
                if (pos2 != null)
                {
                    chairlist.Add(Instantiate(chairPrefab, pos2.position, pos2.rotation, table.transform));
                }
                if (posStudent1 != null)
                {
                    Instantiate(studentPrefab, posStudent1.position, posStudent1.rotation, table.transform);
                }
                if (posStudent2 != null)
                {
                    Instantiate(studentPrefab, posStudent2.position, posStudent2.rotation, table.transform);
                }

            }

        }

    }  
 
}
//wie gebe ich an das alle clone auf dem manager sind
//Manager parent vom clone machen