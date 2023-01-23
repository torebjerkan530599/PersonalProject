using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new(-19, 32, -12);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate() //Lateupdate happens on the current object (camera) after the vehicle has moved. Meaning after the Update method of the vehicle script
    {
        transform.position = player.transform.position + offset;
    }
}
