using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public AudioSource ButtonSound, MiddleSound;
    public AudioClip PlaySound, QuitSound, CoinSound;



    [ContextMenu("Increase Score")]
    public void addScore()
    {
        MiddleSound.clip = CoinSound;
        MiddleSound.Play();
        playerScore += 1;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        ButtonSound.clip = PlaySound;
        ButtonSound.Play();
        SceneManager.LoadScene(1);
    }

    public void gameOver()
    {

        SceneManager.LoadScene(2);
    }

    public void quitGame() {
        ButtonSound.clip = QuitSound;
        ButtonSound.Play();
        SceneManager.LoadScene(0);
    }
}
