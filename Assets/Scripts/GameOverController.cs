using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;  // Make sure to include the TextMeshPro namespace

public class GameOverController : MonoBehaviour
{
    [Header("Game Over UI Elements")]
    [SerializeField]
    public TextMeshProUGUI scoreText;
    [SerializeField]
    public GameObject gameOverPanel;

    public void Start()
    {
        gameOverPanel.SetActive(true);
        if (GameManager.Instance)
        {
            scoreText.text = "Score: " + GameManager.Instance.score.ToString();
        }
       
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
