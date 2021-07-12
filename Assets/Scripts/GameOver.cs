using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Text;

public class GameOver : MonoBehaviour
{
    [SerializeField] GameObject bow = null; //the bow prefab
    [SerializeField] GameObject arrowPrefab = null; //base arrow prefab
    private GameObject button = null; //the button
    private GameObject arrow; //the created arrow (duplicate of the arrow prefab)
    private TrailRenderer trail; //trail for the arrow
    private Quaternion originalRot;
    private Vector3 originalPos;
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

        originalRot = bow.transform.localRotation; //store the bow's original rotatation
        originalPos = bow.transform.localPosition; //store the bow's original pos

        bow.SetActive(true);
        button.SetActive(false);
        PlayerPrefs.SetInt("ArrowsLeft", 10);
        PlayerPrefs.SetInt("Score", 0);

        scoreText.text = "Score: 0";
        arrowsText.text = "Arrows left: 10";

        PlayerPrefs.SetString("ScoreText", "Score: " + 0);
        PlayerPrefs.SetString("Arrows", "Arrows left: " + 10);

        SpawnArrow();
    }

     //Spawn an arrow at the transform's position
    private void SpawnArrow() {
        arrow = Instantiate(arrowPrefab, transform.position, transform.rotation) as GameObject; //create new arrow
        arrow.transform.SetParent(transform, true); //set the arrow's parent
        arrow.transform.localScale = new Vector3(0.6f, 0.6f, 0.6f);
        trail = arrow.GetComponent<TrailRenderer>(); //get the new trail component
    }
    
    
}
