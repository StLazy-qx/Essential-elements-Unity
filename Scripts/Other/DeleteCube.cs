using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteCube : MonoBehaviour
{
    private void Start()
    {
        GameObject cube1 = GameObject.Find("Cube");

        //Destroy(cube1);

        GameObject[] cubes = GameObject.FindGameObjectsWithTag("CubeDelete");

        foreach (GameObject cube in cubes)
        {
            Destroy(cube);
        }
    }
}
