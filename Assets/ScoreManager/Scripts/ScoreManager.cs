using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public float score = 0f;
    public Text textElement;

    private static ScoreManager instance;

    // Use this for initialization
    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        textElement.text = score.ToString();
    }

    public static void AddScore(float scoreToAdd)
    {
        instance.score += scoreToAdd;
    }
}
