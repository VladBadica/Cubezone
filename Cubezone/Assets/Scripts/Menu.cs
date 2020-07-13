using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public void StartEndless()
    {
        SceneManager.LoadScene("Endless");
    }

    public void OpenSettings()
    {
        SceneManager.LoadScene("Settings");
    }
}
