using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenButtonScript : MonoBehaviour
{

    public float moveSpeed = 8f; 
    private bool movingRight = true;

    public Vector3 initialScale = new Vector3(1, 1, 1);

    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = initialScale;
    }

    // Update is called once per frame
    void Update()
    {
        float moveDirection = movingRight ? 1f : -1f;
        Vector3 newPosition = transform.position + Vector3.right * moveDirection * moveSpeed * Time.deltaTime;

        // Move the sprite
        transform.position = newPosition;

        // Check if the sprite has reached the screen boundaries
        if (transform.position.x >= 10f)
        {
            movingRight = false;
        }
        else if (transform.position.x <= -10f)
        {
            movingRight = true;
        }

        // Check for mouse click
        if (Input.GetMouseButtonDown(0))
        {
            // When left mouse button is clicked, make the sprite disappear
            gameObject.SetActive(false);
        }
    }



   
}
