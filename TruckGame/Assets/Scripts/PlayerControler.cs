using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    [SerializeField]
    public float playerSpeed;
    [SerializeField]
    public float turnSpeed;

    private float horizontalInput;
    private float fowardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        fowardInput = Input.GetAxis("Vertical");

        //Moves the vehicle forward
        this.transform.Translate(Vector3.forward * Time.deltaTime * playerSpeed * fowardInput);

        //Do the rotation of the vehicle
        this.transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
