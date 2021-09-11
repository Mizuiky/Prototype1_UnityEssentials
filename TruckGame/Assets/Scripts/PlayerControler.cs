using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    [SerializeField]
    private float playerSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Moves the vehicle forward
        if(Input.GetKey(KeyCode.W))
        {
            this.transform.position += Vector3.forward * Time.deltaTime * playerSpeed;
        }
        else if(Input.GetKey(KeyCode.S))
        {
            this.transform.position -= Vector3.forward * Time.deltaTime * playerSpeed;
        }
        
    }
}
