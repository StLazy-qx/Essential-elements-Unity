using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePrefabs : MonoBehaviour
{
    public GameObject Tamplate;

    private void Start()
    {
        GameObject newObjetc = Instantiate(Tamplate, new Vector3(2,2,2), Quaternion.identity);
    }
}
