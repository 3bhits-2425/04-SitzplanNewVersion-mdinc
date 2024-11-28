using UnityEngine;

public class Manager1 : MonoBehaviour
{
    [SerializeField] private TableLayout tableLayout;
    [SerializeField] private StudentData[] students;
    [SerializeField] private GameObject tablePrefab;
    [SerializeField] private GameObject chairPrefab;

    private void Start()
    {
        //Tische und sessel  aufstellen mittels prefab, reihen und spalten
        for(int row = 0; row < tableLayout.row; row++) 
        {
            for(int col = 0; col < tableLayout.column; col++)
            {   //managen, dass tische nicht übereinander sind
                Vector3 tablePosition = new Vector3(col * tableLayout.tableSpacing, 0, row * tableLayout.tableSpacing); 
                //Tische platzieren
                GameObject table = Instantiate(tablePrefab, tablePosition, Quaternion.identity, transform); 

                //sessel platzieren
            }
        }
    }
}


//wie gebe ich an das alle clone auf dem manager sind
//Manager parent vom clone machen