using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person : MonoBehaviour
{
    [SerializeField] float speed;
    private Waypoints points;
    [SerializeField] GameObject blood;

    [SerializeField] bool reverseDirection;
    [SerializeField] int pointNumber = 0;

    // Start is called before the first frame update
    void Start()
    {
        if(reverseDirection == true)
        {
            if(pointNumber > 0)
            {
                pointNumber = pointNumber - 1;
            }
            else
            {
                pointNumber = 12;
            }
            

        }
        points = GameObject.FindGameObjectWithTag("Waypoints").GetComponent<Waypoints>();
    }


    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, points.points[pointNumber].position, speed * Time.deltaTime);
        if(Vector2.Distance(transform.position, points.points[pointNumber].position) < 0.1f)
        {
            if(reverseDirection == false)
            {
                if(pointNumber < points.points.Length - 1)
                {
                    pointNumber++;
                }
                else
                {   
                    pointNumber = 0;
                }
            }
            else
            {
                if(pointNumber > 0)
                {
                    pointNumber--;
                }
                else
                {   
                    pointNumber = 12;
                }
            }
        }
    }


    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Player")
        {
            blood.SetActive(true);
            this.GetComponent<Person>().enabled = false;
        }
    }
}

