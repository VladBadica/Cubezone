using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public Slider sliderVolume;
    public Slider sliderMusic;

    void Awake()
    {
        sliderVolume.value = PlayerPrefs.GetFloat("Volume");
        sliderMusic.value = PlayerPrefs.GetFloat("MusicVolume");
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void ChangeVolume(float newVolume)
    {
        PlayerPrefs.SetFloat("Volume", newVolume);
    }

    public void ChangeMusic(float newMusicVolume)
    {
        PlayerPrefs.SetFloat("MusicVolume", newMusicVolume);
    }



}
