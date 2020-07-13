using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public GameObject destroyableObject;
    public Rigidbody rigidBody;
    [Space]
    [Header("Direction")]
    public bool isMoving = false;
    public bool goTowardsLeft = false;
    public float speed = 20f;
    
    void FixedUpdate()
    {
        if (isMoving)
        {
            Move();
            ChangeDirection();
        }
    }

    private void Move()
    {
        if (goTowardsLeft)
        {
            rigidBody.velocity = new Vector3(-speed, 0, 0);
        }else{
            rigidBody.velocity = new Vector3(speed, 0, 0);
        }
    }

    private void ChangeDirection()
    {
        if (transform.position.x < -4.5f)
        {
            goTowardsLeft = false;
        }

        if (transform.position.x > 4.5f)
        {
            goTowardsLeft = true;
        }
    }
    
}
