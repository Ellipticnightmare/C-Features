using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Arrays
{
    public class Powerup_Speed : MonoBehaviour
    {

        public float modifier = 2f;

        // Collision Detection
        void OnTriggerEnter(Collider col)
        {
            // Detect Collision with player
            PlayerMovement p = col.GetComponent<PlayerMovement>();
            if(p != null)
            {
                // Add modifier to force
                p.force *= modifier;
                // Destroy powerup
                Destroy(gameObject);
            }
        }
    }
}