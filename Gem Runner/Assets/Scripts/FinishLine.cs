using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class FinishLine : MonoBehaviour
{
    public TextMeshProUGUI winMessage;
    public TextMeshProUGUI playAgainMessage;
    public GameObject winPanel;

    private bool canRestart = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            winMessage.text = "You Won!!!";
            playAgainMessage.text = "Hit P to play again";
            Time.timeScale = 0f;
            canRestart = true;

            winPanel.SetActive(true);
        }
    }

    private void Update()
    {
        if (canRestart && Input.GetKeyDown(KeyCode.P))
        {
            RestartGame();
        }
    }

    private void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
