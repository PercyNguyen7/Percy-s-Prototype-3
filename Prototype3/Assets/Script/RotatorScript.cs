using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RotatorScript : MonoBehaviour
{
    public float rotationSpeedZ = 0.1f;
    public float rotationSpeedY = 0.1f;
    public float rotationSpeedX = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       this.GetComponent<Transform>().Rotate(rotationSpeedX, rotationSpeedY, rotationSpeedZ);

       /* 
        if (Input.GetKey(KeyCode.R)) {
        this.GetComponent<Transform>().Rotate(0, rotationSpeed, 0);
        }
        if (Input.GetKey(KeyCode.T))
        {
            this.GetComponent<Transform>().Rotate(0, -rotationSpeed, 0);
        }
       */
    }

 
    public void Rotate1(InputAction.CallbackContext context)
    {
        Debug.Log("input detected");
        this.GetComponent<Transform>().Rotate(0, rotationSpeedY, 0);

    }
    public void Rotate2(InputAction.CallbackContext context)
    {
        this.GetComponent<Transform>().Rotate(0, -rotationSpeedY, 0);
    }

}
