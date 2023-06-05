using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    public AudioSource src;
    public AudioClip quitSound, StartSound;
    // Start is called before the first frame update
    public void playGame()
    {
        src.clip = StartSound;
        src.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void quitGame()
    {
        src.clip = quitSound;
        src.Play();
        Application.Quit();
    }
}
