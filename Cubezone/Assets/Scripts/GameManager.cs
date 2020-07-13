using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool gameHasEnded = false;
    public float restartDelay = 1f;

    void Awake()
    {
        InitializeGame();
    }

    public void InitializeGame()
    {
        PlayerPrefs.SetFloat("Score", 0);
    }

    public void EndGame()
    {
        if (gameHasEnded == true) return;

        gameHasEnded = true;
        
        Invoke("GameOver", restartDelay);
    }

    public bool gameIsOver()
    {
        return gameHasEnded;
    }


    void GameOver()
    {
        SceneManager.LoadScene("Credits");
    }
}
