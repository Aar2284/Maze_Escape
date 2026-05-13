using UnityEngine;

public class ObstacleHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Obstacle"))
        {
            GameManager.instance.AddScore(-5);
        }
    }
}