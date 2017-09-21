using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Functions
{


    public class Rigid2DMovement : MonoBehaviour
    {
        public float dashSpeed = 50f;
        public float rotationSpeed = 5f;
        public float acceleration = 20f;
        public float deceleration = 0.1f;

        private Rigidbody2D rigid2D;

        // Use this for initialization
        void Start()
        {
            // Get rigidbody component
            rigid2D = GetComponent<Rigidbody2D>();
        }

        //Above Update

        // Update is called once per frame
        void Update()
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                Dash();
            }
            // Calling a function
            Accelerate();
            Decelerate();
            Rotate();
        }

        // Under Update
        void Accelerate()
        {
            // Get input from vertical axis
            float inputV = Input.GetAxis("Vertical");
            // Add force to the right direction of the player
            rigid2D.AddForce(transform.up * inputV * acceleration);
        }

        void Decelerate()
        {
            // velocity += -velocity * deceleration
            rigid2D.velocity += -rigid2D.velocity * deceleration;
        }
        void Dash()
        {
            rigid2D.AddForce(transform.up * dashSpeed, ForceMode2D.Impulse);
        }

        void Rotate()
        {
            // Get horizontal input
            float inputH = Input.GetAxis("Horizontal");
            // Perform rotaion with input
            transform.Rotate(Vector3.forward, rotationSpeed * -inputH);
        }
    }

}