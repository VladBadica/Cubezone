using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public Text score;

    void Start()
    {
        score.text = "Score: " + PlayerPrefs.GetFloat("Score").ToString("0");
    }

    public void Retry()
    {
        SceneManager.LoadScene("Endless");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
