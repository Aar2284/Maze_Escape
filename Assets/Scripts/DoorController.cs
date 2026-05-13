using UnityEngine;

public class DoorController : MonoBehaviour
{
    public Animator animator;
    public bool playerNear = false;

    void Update()
    {
        if(playerNear && Input.GetKeyDown(KeyCode.C))
        {
            animator.SetTrigger("ExitDoor");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            playerNear = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            playerNear = false;
        }
    }
}