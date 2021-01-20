using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject GameOverText;
    [SerializeField] GameObject GameClearText;
    [SerializeField] Text ScoreText;

    //SE
    [SerializeField] AudioClip gameClearSE;
    [SerializeField] AudioClip gameOverSE;
    AudioSource audioSource;

    const int MAX_SCORE = 9999;
    int score = 0;

    public void Start()
    {
        ScoreText.text = score.ToString();
        audioSource = GetComponent<AudioSource>();
    }

    public void AddScore(int val)
    {
        score += val;
        if (score > MAX_SCORE)
        {
            score = MAX_SCORE;
        }
        ScoreText.text = score.ToString();
    }

    public void GameOver()
    {
        GameOverText.SetActive(true);
        audioSource.PlayOneShot(gameOverSE);
        Invoke("RestartScene", 1.5f);
    }
    public void GameClear()
    {
        GameClearText.SetActive(true);
        audioSource.PlayOneShot(gameClearSE);
        Invoke("RestartScene", 1.5f);
    }

    void RestartScene()
    {
        Scene thisScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(thisScene.name);
    }
}
