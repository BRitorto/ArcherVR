using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Text;

public class GameOver : MonoBehaviour
{
	private GameObject bow = null; //the bow prefab
    private GameObject button = null; //the button
    private Text arrowsText;
    private Text scoreText;

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

        scoreText.text = "Score: 0";
        arrowsText.text = "Arrows left: 10";

        PlayerPrefs.SetString("ScoreText", "Score: " + 0);
        PlayerPrefs.SetString("Arrows", "Arrows left: " + 10);
    }
}
