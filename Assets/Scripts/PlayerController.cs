using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private readonly float speed = 10.0f;
    private readonly float borderLimit = 25;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        MovePlayer();
        ConstrainPlayerPosition();
    }

    //Move the player based on arrow key input
    void MovePlayer()
    {
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(verticalInput * speed * Time.deltaTime * Vector3.forward);
        transform.Translate(horizontalInput * speed * Time.deltaTime * Vector3.right);
    }

    //prevent player from going outside the ground plane
    void ConstrainPlayerPosition()
    {

        if (transform.position.x > borderLimit)
            transform.position = new Vector3(borderLimit, transform.position.y, transform.position.z);

        if (transform.position.x < -borderLimit)
            transform.position = new Vector3(-borderLimit, transform.position.y, transform.position.z);

        if (transform.position.z < -borderLimit)
            transform.position = new Vector3(transform.position.x, transform.position.y, -borderLimit);

        if (transform.position.z > borderLimit)
            transform.position = new Vector3(transform.position.x, transform.position.y, borderLimit);
    }
}
