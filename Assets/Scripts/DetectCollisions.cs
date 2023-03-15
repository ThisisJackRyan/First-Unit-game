using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{

    SpawnManager spawn;
    // Start is called before the first frame update
    void Start()
    {
        spawn = GameObject.FindGameObjectWithTag("SpawnManager").GetComponent<SpawnManager>();
    }

    // Update is called once per frame
    void Update()
    {
          
    }

    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
        spawn.SpawnRandomTarget();
    }
}
