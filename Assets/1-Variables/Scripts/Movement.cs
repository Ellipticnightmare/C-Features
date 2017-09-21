using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement: MonoBehaviour
{
    public float movementSpeed = 3.1f;
    public float rotationSpeed = 1f;
   
	// Update is called once per frame
	void Update ()
    {
        // Check IF user presses W or up
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            // Move up
            transform.Translate(new Vector3(0, movementSpeed, 0) * Time.deltaTime);
        }
        // Check IF user presses S or down
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            // Move down
            transform.Translate(new Vector3(0, -movementSpeed, 0) * Time.deltaTime);
        }
        // Check IF user presses A or left
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            // Move left
            transform.Translate(new Vector3(-movementSpeed, 0, 0) * Time.deltaTime);
        }
        // Check IF user presses D or right
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            // Move right
            transform.Translate(new Vector3(movementSpeed, 0, 0) * Time.deltaTime);
        }

    }
}
