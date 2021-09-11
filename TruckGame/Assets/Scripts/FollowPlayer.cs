using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 cameraOffset;

    // Start is called before the first frame update
    void Start()
    {
        this.cameraOffset = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //Offset the camera behind the player by adding to the player's positions
        this.transform.position = player.transform.position + this.cameraOffset;
    }
}
