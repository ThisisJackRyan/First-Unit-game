using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{
   // GameObject rig;
   public GameObject newLocation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void TeleportRIG()
    {
       Vector3 new_Location = newLocation.transform.position;
       transform.position = new_Location;

       // Debug.Log("This works now");
    }
}
