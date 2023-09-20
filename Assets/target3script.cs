using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target3script : MonoBehaviour
{

    public float randomScale;

    public GameObject target3;

    public float leftRight;

    private bool left = false;

    private bool right = false;

    private float xPos;

    private float yPos = -3.17f;

    public float moveSpeed;

    public float moveDirection;

    // Start is called before the first frame update
    void Start()
    {

        leftRight = Random.Range(0, 2);

        if (leftRight == 1)
        {
            right = true;
            // Debug.Log("right");
            xPos = 14;
        }
        else if (leftRight == 0)
        {
            left = true;
            // Debug.Log("left");
            xPos = -12;
        }

        moveSpeed = UnityEngine.Random.Range(5, 11);
        randomScale = UnityEngine.Random.Range(0.3f, 0.8f);
        transform.localScale = new Vector3(randomScale, randomScale, 1);
        transform.position = new Vector3(xPos, yPos, 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (right)
        {
            moveDirection = 1f;
        }
        else
        {
            moveDirection = -1f;
        }
       
        Vector3 newPosition = transform.position + Vector3.right * moveDirection * moveSpeed * Time.deltaTime;

        // Move the sprite
        transform.position = newPosition;

        // Check if the sprite has reached the screen boundaries
        if (transform.position.x >= 10f)
        {
            right = false;
        }
        else if (transform.position.x <= -10f)
        {
            right = true;
        }

        if (Input.GetMouseButtonDown(0) && gameObject == target3) {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.collider != null && hit.collider.gameObject == gameObject)
            {
                // Debug.Log("target 3 (bottom)");

                TargetListener targetListener = FindObjectOfType<TargetListener>();
                targetListener.AddPoint();

				Instantiate(target3);
				Destroy(target3);

            }
        }
    }
}
