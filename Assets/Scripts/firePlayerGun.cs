using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

//[RequireComponent(typeof(ActionBasedController))]
public class firePlayerGun : MonoBehaviour
{
    // Start is called before the first frame update

    ActionBasedController controller;
    public GameObject gun;
    public GameObject Laser;
    
    public Transform barrelLocation;
    public float shootPoower;
    //public bool isAutoFire;

    private bool on = false;
    
    //private bool on = false;

    void Start()
    {
        controller = GetComponent<ActionBasedController>();
       
    }

    // Update is called once per frame
    void Update()
    {
        if(on)
        {
            spawnLaser();
        }
    }

    public void turnOn(){
        on = true;
    }
    public void turnOff(){
        on = false;
    }
 
    public void spawnLaser()
    {
        Instantiate(Laser, barrelLocation.position, barrelLocation.rotation * Quaternion.Euler(90f,0f,0f)).GetComponent<Rigidbody>().AddForce(barrelLocation.forward * shootPoower);
    }
    
}
