using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenuUI : MonoBehaviour
{
    [SerializeField] private Button resumeButton;
    [SerializeField] private Button mainMenuButton;

    private void Awake()
    {
        resumeButton.onClick.AddListener(() =>
        {
            Hide();
        });
        mainMenuButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("MainMenuScene");
        });
    }

    private void Start()
    {
        Hide();
    }

    public void EscapePressed()
    {
        if (gameObject.activeSelf)
        {
            Hide();
        }
        else
        {
            Show();
        }
    }

    public void Show()
    {
        Time.timeScale = 0.0f;
        gameObject.SetActive(true);
    }
    private void Hide()
    {
        Time.timeScale = 1.0f;
        gameObject.SetActive(false);
    }
}
