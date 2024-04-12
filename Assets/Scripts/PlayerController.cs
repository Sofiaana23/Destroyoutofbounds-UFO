using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float horizontalInput;
    public float speed;
    public float xRange;
    public Transform blaster;
    public GameObject lazerBolt;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Set horizontalinput to receive values from keyboard
        horizontalInput = Input.GetAxis("Horizontal");

        // Moves player left and right
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        //Left side wall
        if (transform.position.x < -xRange) 
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        // Right side wall
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        // If space bar is pressed fire lazerbolt
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            // Create laserbolt at the blastertransform position maintaining the objects rotation
            Instantiate(lazerBolt, blaster.transform.position, lazerBolt.transform.rotation);
        }

       
    }
    
    private void OnTriggerEnter(Collider other) 
    {
        Destroy(other.gameObject);
    }
}

