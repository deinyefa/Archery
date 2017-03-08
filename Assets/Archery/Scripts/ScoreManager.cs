using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {

    [HideInInspector]
    public static int score;
    public static ScoreManager instance;

    private int ballonScoreIncrement = 5;
    private int targetScoreIncrement = 3;
    private int weebleScoreIncrement = 1;

    void Awake()
    {
        if (instance == null)
            instance = this;
    }

    void OnDestroy()
    {
        if (instance == this)
            instance = null;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "target")
        {
            score = score + targetScoreIncrement;

        } else if (other.gameObject.tag == "ballon")
        {
            score = score + ballonScoreIncrement;

        } else if (other.gameObject.tag == "weeble")
        {
            score = score + weebleScoreIncrement;
        }
    }
}
