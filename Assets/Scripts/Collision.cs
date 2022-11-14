using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    private bool hasPackage = false;
    private void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("you hit " + other);
    }

    public void OnTriggerEnter2D(Collider2D other) 
    {
        Debug.Log("you triggered " + other);
        if(other.tag == "Box" && hasPackage==false)
        {
            Debug.Log("Picked up a Package");
            hasPackage = true;
            Destroy(other.gameObject);
        }else if(other.tag == "Customer" && hasPackage==true)
        {
            Debug.Log("Delivered a Package");
            hasPackage = false;
        }else if(other.tag == "Box" && hasPackage==true)
        {
            Debug.Log("You already have a Package");
        }
    }
    
}
