using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    public class Shooting : MonoBehaviour
    {
        public GameObject BulletPrefab;
        public float BulletSpeed = 20f;
        public float shootRate = 0.2f;

        private float shootTimer = 0f;
        void Shoot()
        {
            GameObject clone = Instantiate(BulletPrefab);
            clone.transform.position = transform.position;
            clone.transform.rotation = transform.rotation;
            Rigidbody2D rigid = clone.GetComponent<Rigidbody2D>();
            rigid.AddForce(transform.up * BulletSpeed, ForceMode2D.Impulse);
        }
        void Update()
        {
            shootTimer += Time.deltaTime;
            if (shootTimer >= shootRate)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    Shoot();
                    shootTimer = 0f;
                }
            }
        }
    }
}