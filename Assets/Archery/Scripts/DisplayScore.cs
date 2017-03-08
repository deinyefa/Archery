using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour {

    public Text scoreText;

	void Start () {
        scoreText.text = ScoreManager.score.ToString();
	}

    void Update()
    {
        scoreText.text = ScoreManager.score.ToString();
    }
}
