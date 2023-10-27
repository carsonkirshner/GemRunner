using UnityEngine;

public class Gem : MonoBehaviour
{
    [SerializeField] float timeToAdd = 5f; 

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.collider.CompareTag("Player"))
        {
            HandlePlayerCollision();
        }
    }

    private void HandlePlayerCollision()
    {
        GameTimer gameTimer = FindObjectOfType<GameTimer>();
        if (gameTimer != null)
        {
            gameTimer.AddTime(timeToAdd);
            Debug.Log("Time added: " + timeToAdd);
        }
        else
        {
            Debug.LogWarning("GameTimer not found!");
        }

        Destroy(gameObject);
        Debug.Log("Gem destroyed");
    }
}
