using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        else if(other.tag == "Restart")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else if(other.tag == "Water")
        {
            moveSpeed = 1.5f;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag == "Water")
        {
            moveSpeed = 3f;
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


