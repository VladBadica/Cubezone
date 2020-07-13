using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rigidBody;

    public float forwardForce = 1000f;
    public float horizontalForce = 500f;
    private bool moveRight = false;
    private bool moveLeft = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    void Update()
    {
        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            moveRight = true;
        }

        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            moveLeft = true;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rigidBody.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (moveRight)
        {
            rigidBody.AddForce(horizontalForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            moveRight = false;
        }

        if (moveLeft)
        {
            rigidBody.AddForce((-horizontalForce) * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            moveLeft = false;
        }

        if (rigidBody.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
