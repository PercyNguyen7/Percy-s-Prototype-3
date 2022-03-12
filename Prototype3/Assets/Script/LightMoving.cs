using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightMoving : MonoBehaviour
{
    [SerializeField] float distanceToCoverX;
    [SerializeField] float distanceToCoverY;
    [SerializeField] float distanceToCoverZ;
    [SerializeField] float speed;

    private Vector3 startingPosition;
    // Start is called before the first frame update
    void Start()
    {
        startingPosition = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 v = startingPosition;
       
        v.x += distanceToCoverX * Mathf.Sin(Time.time * speed);
        v.y += distanceToCoverY * Mathf.Sin(Time.time * speed);
        v.z += distanceToCoverZ * Mathf.Sin(Time.time * speed);
        transform.position = v;
    }
}
