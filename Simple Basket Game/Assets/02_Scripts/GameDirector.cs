using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    Text scoreText, timeText;
    public int score;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        timer = 60f;
        scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
        timeText = GameObject.Find("TimeText").GetComponent <Text>();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        timeText.text = "Time : " + timer;

        scoreText.text = "Score : " + score;
    }
}