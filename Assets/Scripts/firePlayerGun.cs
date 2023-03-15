using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firePlayerGun : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject gun;
    public GameObject Laser;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void spawnLaser()
    {
         Instantiate(Laser, transform.position, Laser.transform.rotation);
    }
}
