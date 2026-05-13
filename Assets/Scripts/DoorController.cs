using UnityEngine;

public class DoorController : MonoBehaviour
{
    public Animator animator;

    private BoxCollider doorCollider;

    public bool playerNear = false;

    private bool opened = false;

    void Start()
    {
        doorCollider = GetComponent<BoxCollider>();
    }

    void Update()
    {
        if (playerNear && Input.GetKeyDown(KeyCode.C) && !opened)
        {
            opened = true;

            animator.SetTrigger("OpenDoor");

            Invoke("DisableCollider", 1f);
        }
    }

    void DisableCollider()
    {
        doorCollider.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerNear = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerNear = false;
        }
    }
}