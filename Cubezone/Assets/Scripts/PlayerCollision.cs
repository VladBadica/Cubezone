using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public Animator camAnim;

    public PlayerMovement playerMovement;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            PlayerDeath();
        }
    }

    private void PlayerDeath()
    {
        playerMovement.enabled = false;
        FindObjectOfType<AudioManager>().Play("PlayerDeath");
        camAnim.SetTrigger("shake");
        FindObjectOfType<GameManager>().EndGame();
    }
}
