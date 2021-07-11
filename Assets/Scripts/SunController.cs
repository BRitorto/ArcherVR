using UnityEngine;
using System.Collections;
using System.Text;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class SunController : MonoBehaviour
{

    [HideInInspector]
    public GameObject sun;
    [HideInInspector]
    public Light sunLight;

    [Range(0, 24)]
    public float timeOfDay = 12;

    public float secondsPerMinute = 60;
    [HideInInspector]
    public float secondsPerHour;
    [HideInInspector]
    public float secondsPerDay;

    public float timeMultiplier = 1;
    [SerializeField] private Text scoreText;


    void Start()
    {
        sun = gameObject;
        sunLight = gameObject.GetComponent<Light>();

        secondsPerHour = secondsPerMinute * 60;
        secondsPerDay = secondsPerHour * 24;

        scoreText = GameObject.Find("scoreText").GetComponent<Text>();
        scoreText.text = "Score: " + 0;
        PlayerPrefs.SetString("Score", scoreText.text);
        PlayerPrefs.SetInt("ScoreNumber", 0);

    }

    // Update is called once per frame
    void Update()
    {
        SunUpdate();

        timeOfDay += (Time.deltaTime / secondsPerDay) * timeMultiplier;

        if (timeOfDay >= 24)
        {
            timeOfDay = 0;
        }
    }

    public void SunUpdate()
    {
        sun.transform.localRotation = Quaternion.Euler(((timeOfDay / 24) * 360f) - 90, 90, 0);
    }
}