using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
	[SerializeField] GameObject bow = null; //the bow prefab
    [SerializeField] GameObject button = null; //the button
    [SerializeField] private Text arrowsText;

    void Start()
    {

    }

    public void PlayGame()
    {
        bow = GameObject.Find("/Player/Main Camera/Bow");
        button = GameObject.Find("/Canvas/Button");
        arrowsText = GameObject.Find("arrowsText").GetComponent<Text>();
        scoreText = GameObject.Find("scoreText").GetComponent<Text>();

        bow.SetActive(true);
        button.SetActive(false);
        PlayerPrefs.SetInt("ArrowsLeft", 10);
        PlayerPrefs.SetInt("Score", 0);

        scoreText.Text = 

        PlayerPrefs.SetString("ScoreText", "Score: " + 0);
        PlayerPrefs.SetString("Arrows", "Arrows left: " + 10);
    }
}
