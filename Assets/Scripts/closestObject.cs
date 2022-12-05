using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closestObject : MonoBehaviour
{
    [SerializeField] GameObject origin;

    private Transform closestBox;
    private Transform closestCustomer;

    Collision col;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (col.hasPackage == true)
        {
            findClosestCustomer();
        }
        else
        {
            findClosestBox();
        }
    }

    private void findClosestBox()
    {
        //closestBox = GameObject.FindGameObjectsWithTag("Enemy")
        //if (Vector3.Distance(transform.position, ) <= closeDistance)
    }
    private void findClosestCustomer()
    {

    }
}
