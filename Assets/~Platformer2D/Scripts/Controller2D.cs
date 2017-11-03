using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Platformer2D
{
    public class Controller2D : MonoBehaviour
    {
        public float accelerate = 20f;
        public float jumpHeight = 10f;

        private Rigidbody rigid;

        // Use this for initialization
        void Start()
        {
            rigid = GetComponent<Rigidbody>();
        }

        // 'inputH' value is. (-1 = A, 0 = Nothing, 1 = D)
        public void Move(float inputH)
        {

        }

        public void Jump()
        {
            rigid.AddForce(transform.up * jumpHeight, ForceMode.Impulse);
        }
    }

}
