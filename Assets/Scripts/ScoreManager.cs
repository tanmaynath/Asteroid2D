using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    float score;
    [SerializeField]
    int multiplier;
    [SerializeField]
    Text scoreText;
    bool gameover;

	// Use this for initialization
	void Start () {
        score = 0;
        gameover = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(!gameover)
        {
            score +=Time.deltaTime;
            print(Mathf.RoundToInt(score));
            
            scoreText.text = "Score: " + Mathf.RoundToInt(score).ToString();
        }
	}

    public void StopGameTimer()
    {
        gameover = true;
    }
}
