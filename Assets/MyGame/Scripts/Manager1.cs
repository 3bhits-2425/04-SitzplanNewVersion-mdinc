using UnityEngine;

public class Manager1 : MonoBehaviour
{
    [SerializeField] private TableLayout tableLayout; // Enthält Zeilen, Spalten und Abstände
    [SerializeField] private GameObject tablePrefab; // Prefab für den Tisch
    [SerializeField] private GameObject chairPrefab; // Prefab für den Stuhl

    private void Start()
    {
        // Validierung vor der Hauptlogik
        if (tableLayout == null || tablePrefab == null || chairPrefab == null)
        {
            Debug.LogError("Manager1 cannot start because required fields are missing.");
            return;
        }

        // Tische und Stühle in einem Grid platzieren
        for (int row = 0; row < tableLayout.row; row++)
        {
            for (int col = 0; col < tableLayout.column; col++)
            {
                // Berechnung der Tischposition basierend auf den Abstandsangaben
                Vector3 tablePosition = new Vector3(
                    col * tableLayout.tableSpacing,
                    0,
                    row * tableLayout.tableSpacing
                );

                // Tisch erstellen und den Manager als Parent setzen mittels transform
                GameObject table = Instantiate(tablePrefab, tablePosition, Quaternion.identity, transform);

                // Stuhlpositionen innerhalb des Tisches finden
                Transform chairPos1 = table.transform.Find("ChairPos1");
                Transform chairPos2 = table.transform.Find("ChairPos2");

                // Stühle erstellen, falls die Positionen existieren
                if (chairPos1 != null)
                {
                    Instantiate(chairPrefab, chairPos1.position, chairPos1.rotation, table.transform);
                }
                else
                {
                    Debug.LogWarning("ChairPos1 not found in tablePrefab.");
                }

                if (chairPos2 != null)
                {
                    Instantiate(chairPrefab, chairPos2.position, chairPos2.rotation, table.transform);
                }
                else
                {
                    Debug.LogWarning("ChairPos2 not found in tablePrefab.");
                }
            }
        }
    }
}
//wie gebe ich an das alle clone auf dem manager sind
//Manager parent vom clone machen