
using UnityEngine;

public class buildManeger : MonoBehaviour
{
    
    public static buildManeger instance;
    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("more than one buildmaniger");
            return;
        }
        instance = this;  
    }
    public GameObject standerdTurretPrefab;
    private void Start()
    {
        turretToBuild = standerdTurretPrefab;
    }
    private GameObject turretToBuild;
    public GameObject GetTurrrtToBuild()
    {
        return turretToBuild;
    }


}
