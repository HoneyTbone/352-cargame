using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 0.1f;

    [SerializeField] float moveSpeed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxisRaw("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount * moveSpeed, 0);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Boost")
        {
            if (moveSpeed < 10)
            {
                moveSpeed = moveSpeed + 1f;
                Destroy(other.gameObject);
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ob")
        {
            if (moveSpeed <= 1.5f)
            {
                moveSpeed = moveSpeed - 0.1f;
            }
        }

    }
}


