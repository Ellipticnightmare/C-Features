using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Arrays
{
    public class PlayerMovement : MonoBehaviour
    {
        public float force = 5f;

        private Rigidbody rigid;

        // Use this for initialization
        void Start()
        {
            rigid = GetComponent<Rigidbody>();
        }

        // Update is called once per frame
        void Update()
        {
            float inputH = Input.GetAxis("Horizontal");

            float inputV = Input.GetAxis("Vertical");

            Vector3 inputDir = new Vector3(inputH, 0, inputV);
            rigid.AddForce(inputDir * force);
        }
    }
}