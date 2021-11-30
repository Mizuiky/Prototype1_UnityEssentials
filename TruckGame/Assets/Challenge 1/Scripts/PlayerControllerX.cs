using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float propellerRotation;

    private float horizontalInput;
    private float verticalInput;

    [SerializeField]
    private GameObject planePropeller;

    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");      

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Time.deltaTime * speed * horizontalInput);


        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * Time.deltaTime * rotationSpeed * verticalInput);
       
          
        //rotate constantly the plane propeller
        this.planePropeller.transform.RotateAround(this.planePropeller.transform.position, Vector3.forward, propellerRotation * Time.deltaTime);
    }
}
