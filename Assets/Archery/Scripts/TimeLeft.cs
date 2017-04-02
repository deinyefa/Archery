using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeLeft : MonoBehaviour {

    private Text timeLeftText;

    public float gameDuration = 10f;

	// Use this for initialization
	void Start () {
        timeLeftText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {

        float timeLeft;

        timeLeft = Time.time;
        timeLeftText.text = timeLeft.ToString();

        if (timeLeft > gameDuration)
            Time.timeScale = 0;
        if (timeLeft > gameDuration / 2)
            timeLeftText.color = Color.red;
    }
}
