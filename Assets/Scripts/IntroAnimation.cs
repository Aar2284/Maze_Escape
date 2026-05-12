using UnityEngine;

public class IntroAnimation : MonoBehaviour
{
    public Animator animator;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            animator.SetTrigger("StartGame");
        }
    }
}