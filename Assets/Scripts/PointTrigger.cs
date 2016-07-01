using UnityEngine;
using System.Collections;
using System;

public class PointTrigger : MonoBehaviour {
    private GameObject scoreObject;
    private int score = 0;
    // Use this for initialization
    void Awake()
    {
        scoreObject = GameObject.Find("New Text");
        TextMesh thing = scoreObject.GetComponent<TextMesh>();
        thing.text = getScore();
    }

    private string getScore()
    {
        return "Score: " + score;
    }

    void OnTriggerEnter(Collider ball)
    {
        score++;
    }
	
	// Update is called once per frame
	void Update () {
        scoreObject = GameObject.Find("New Text");
        TextMesh thing = scoreObject.GetComponent<TextMesh>();
        thing.text = getScore();
    }
}
