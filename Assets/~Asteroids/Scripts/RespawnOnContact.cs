using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnOnContact : MonoBehaviour
{
    private Vector3 spawnPos;
    // Use this for initialization
    void Start()
    {
        spawnPos = transform.position;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        transform.position = spawnPos;
    }
}
