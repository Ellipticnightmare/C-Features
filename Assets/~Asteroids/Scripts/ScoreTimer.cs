using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTimer : MonoBehaviour
{
    public float scoreInterval = 1f;
    public float scoreToAdd = 1f;

    private float scoreTimer = 0f;

    // Update is called once per frame
    void Update()
    {
        scoreTimer += Time.deltaTime;
        if(scoreTimer > scoreInterval)
        {
            ScoreManager.AddScore(scoreToAdd);
            scoreTimer = 0f;
        }
    }
}
