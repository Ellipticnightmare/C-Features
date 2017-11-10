using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnOnContact : MonoBehaviour
{
    public List<string> triggerTags = new List<string>() {
        "Manny",
        "Death"
    };

    private Vector3 spawnPos;
    // Use this for initialization
    void Start()
    {
        spawnPos = transform.position;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (triggerTags.Contains(other.tag))
        {
            transform.position = spawnPos;
        }
    }
}
