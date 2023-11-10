using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameTimer : MonoBehaviour
{
    [SerializeField] float initialTime = 60f;
    private float currentTime;
    public TextMeshProUGUI timerText;

    private void Start()
    {
        currentTime = initialTime;
    }

    void Update()
    {
        UpdateTimer();
    }

    void UpdateTimer()
    {
        currentTime -= Time.deltaTime;


        timerText.text = "Time: " + Mathf.Round(currentTime);

        if (currentTime <= 0.5f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void AddTime(float timeToAdd)
    {
        currentTime += timeToAdd;
    }
}