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

    public bool isAutoFire;
    
    private bool on = false;

    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*public void TurnOn(){
        on = true;
    }
    public void TurnOff(){
        on = false;
    }
    */
    public void spawnLaser()
    {
        
        if(isAutoFire)
        {
            while(on){
            Instantiate(Laser, barrelLocation.position, barrelLocation.rotation * Quaternion.Euler(90f,0f,0f)).GetComponent<Rigidbody>().AddForce(barrelLocation.forward * shootPoower);
            //Instantiate(Laser, barrelLocation.position, barrelLocation.rotation * Quaternion.Euler(90f,0f,0f)).GetComponent<Rigidbody>().AddForce(barrelLocation.forward * shootPoower);
            }
        }
        Instantiate(Laser, barrelLocation.position, barrelLocation.rotation * Quaternion.Euler(90f,0f,0f)).GetComponent<Rigidbody>().AddForce(barrelLocation.forward * shootPoower);
    }
    /*private void checkTrigger()
    {

    }

    public void spawnLaser()
    {
        if(isAutoFire)
        {
           
        }
        else
        {
             shoot()
        }
    }

    public void shoot()
    {
        Instantiate(Laser, barrelLocation.position, barrelLocation.rotation * Quaternion.Euler(90f,0f,0f)).GetComponent<Rigidbody>().AddForce(barrelLocation.forward * shootPoower);
    }*/
}
