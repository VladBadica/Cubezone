using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text textScore;
    public Transform playerTransform;
    private float score = 0f;

    void Start()
    {
        score = PlayerPrefs.GetFloat("Score");
    }

    // Update is called once per frame
    void Update()
    {
        if (!FindObjectOfType<GameManager>().gameHasEnded)
        {
            score = playerTransform.position.z * 0.8f;
            textScore.text = score.ToString("0");
            PlayerPrefs.SetFloat("Score", score);
        }
    }
}
