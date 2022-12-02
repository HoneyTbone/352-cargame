using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{

    [SerializeField] Color hasPackageColor = Color.yellow;
    [SerializeField] Color noPackageColor = Color.white;

    SpriteRenderer sR;
    private bool hasPackage = false;
    private void Start()
    {
        sR = GetComponent<SpriteRenderer>();
    }
    private void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("you hit " + other);
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        Debug.Log("you triggered " + other);
        if(other.tag == "Box" && hasPackage==false)
        {
            Debug.Log("Picked up a Package");
            hasPackage = true;
            Destroy(other.gameObject);
            sR.color = hasPackageColor;
        }else if(other.tag == "Customer" && hasPackage==true)
        {
            Debug.Log("Delivered a Package");
            hasPackage = false;
            sR.color = noPackageColor;
            Destroy(other.gameObject);
        }else if(other.tag == "Box" && hasPackage==true)
        {
            Debug.Log("You already have a Package");
        }
    }
    
}
