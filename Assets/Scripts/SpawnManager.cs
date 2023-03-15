using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] targetPrefabs;    

    
    private float lowerX = -3f;
    private float upperX = 4.5f;
    private float lowerY = 0.645f;
    private float upperY = 3f;
    private float lowerZ = 2.5f;
    private float upperZ = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnRandomTarget()
    {
        Vector3 spawnPos = new Vector3(Random.Range(lowerX, upperX), Random.Range(lowerY, upperY), Random.Range(lowerZ, upperZ));
        int Index = Random.Range(0, targetPrefabs.Length);
        //Debug.Log(animalIndex + " " + animalPrefabs.Length);
        Instantiate(targetPrefabs[Index], spawnPos, targetPrefabs[Index].transform.rotation);
    }
}
