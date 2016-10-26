using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {


    public ScoreManager theScoreManager;

	void Start ()
    {
        theScoreManager = FindObjectOfType<ScoreManager>();
	}
	
	void Update () {
	
	}

    public void RestartGame()
    {
        theScoreManager.scoreIncreasing = false;
        theScoreManager.scoreCount = 0;
        theScoreManager.scoreIncreasing = true;
    }
}
