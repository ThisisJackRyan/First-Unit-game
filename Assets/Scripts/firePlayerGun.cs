using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firePlayerGun : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject gun;
    public GameObject Laser;
    
    public Transform barrelLocation;
    public float shootPoower;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void spawnLaser()
    {
        
        Instantiate(Laser, barrelLocation.position, barrelLocation.rotation * Quaternion.Euler(90f,0f,0f)).GetComponent<Rigidbody>().AddForce(barrelLocation.forward * shootPoower);
    }
}
