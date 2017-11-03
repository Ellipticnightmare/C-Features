using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Platformer2D
{
    [RequireComponent(typeof(Controller2D))]
    public class UserInput2D : MonoBehaviour
    {
        private Controller2D controller;

        // Use this for initialization
        void Start()
        {
            controller = GetComponent<Controller2D>();
        }

        // Update is called once per frame
        void Update()
        {
            // Get input horizontal axis
            float inputH = Input.GetAxis("Horizontal");
            // Move via inputH
            controller.Move(inputH);
            // Check if space is pressed
            if (Input.GetKeyDown(KeyCode.Space))
            {
                // Jump
                controller.Jump();
            }
                
        }
    }
}
