using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject butonObject;
    public GameObject pauseButton;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        gameObject.SetActive(false);
        butonObject.SetActive(true);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void TapIt()
    {
        butonObject.SetActive(false);
        pauseButton.SetActive(true);
        Time.timeScale = 1f;
    }

    public void pasueButton()
    {
        SceneManager.LoadScene(0);
    }
}
