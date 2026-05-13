using UnityEngine;

public class EndGame : MonoBehaviour
{
    public GameObject gameOverPanel;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            gameOverPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }
}