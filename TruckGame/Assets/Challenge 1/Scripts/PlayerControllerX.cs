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
    private Rigidbody body;

    // Start is called before the first frame update
    void Start()
    {
        this.body = this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * Time.fixedDeltaTime * rotationSpeed * verticalInput);

        body.AddRelativeForce(new Vector3(this.transform.rotation.x , verticalInput * speed * Time.fixedDeltaTime, horizontalInput * speed * Time.fixedDeltaTime));

        if(horizontalInput == 0)
        {
            body.velocity = new Vector3(0, 0, 0);
        }
        
        /* move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Time.deltaTime * speed * horizontalInput);*/  

        //Debug.Log("X:" + this.transform.rotation.x.ToString() + "Y:" + this.transform.rotation.y.ToString() + "Z:" + this.transform.rotation.z.ToString());
       
          
        //rotate constantly the plane propeller
        this.planePropeller.transform.RotateAround(this.planePropeller.transform.position, Vector3.forward, propellerRotation * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("obstacle"))
        {
            Debug.Log("hit the obstacle");
        }
    }
}
