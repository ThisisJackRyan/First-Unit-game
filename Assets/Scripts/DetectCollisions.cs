using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{

    SpawnManager spawn;
    GameObject f;
    // Start is called before the first frame update
    void Start()
    {
        spawn = GameObject.FindGameObjectWithTag("SpawnManager").GetComponent<SpawnManager>();
    }

    // Update is called once per frame
    void Update()
    {
          if(GameObject.FindGameObjectsWithTag("Target").Length > 1){
                f = GameObject.FindGameObjectWithTag("Target");
                Destroy(f);
          }
    }

    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
        spawn.SpawnRandomTarget();
    }
}
