using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopLights : MonoBehaviour
{
    [SerializeField] GameObject blueLight;
    [SerializeField] GameObject redLight;
    private bool blueFlip;

    private void Start() 
    {
        blueFlip = true;
        blueLight.SetActive(false);
        redLight.SetActive(true);
    }

    private void FixedUpdate()
    {
            if(blueFlip == true)
            {
                blueLight.SetActive(false);
                redLight.SetActive(true);
                blueFlip = false;
            }
            else
            {
                blueLight.SetActive(true);
                redLight.SetActive(false);
                blueFlip = true;
            }
        
    }
}
