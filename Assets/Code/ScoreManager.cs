using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    [Header("UI")]
    public TextMeshProUGUI currentScoreText;
    public TextMeshProUGUI highScoreText;

    private int currentScore = 0;
    private const string HIGH_SCORE_KEY = "HighScore";

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        UpdateUI();
    }

    public void SetScore(int value)
    {
        currentScore = value;
        UpdateUI();
    }

    public void SaveHighScore()
    {
        int best = PlayerPrefs.GetInt(HIGH_SCORE_KEY, 0);
        if (currentScore > best)
        {
            PlayerPrefs.SetInt(HIGH_SCORE_KEY, currentScore);
            PlayerPrefs.Save();
        }
        UpdateUI();
    }

    public int GetHighScore()
    {
        return PlayerPrefs.GetInt(HIGH_SCORE_KEY, 0);
    }

    private void UpdateUI()
    {
        if (currentScoreText != null)
            currentScoreText.text = "SCORE: " + currentScore;

        if (highScoreText != null)
            highScoreText.text = "HIGH SCORE: " + GetHighScore();
    }
}
