using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{

    public float XRotation = 0;
    public float YRotation = 0;
    public float ZRotation = 3;
    public float DegreesPerSecond = 180;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 axis = new Vector3(XRotation, YRotation, ZRotation);
        transform.RotateAround(Vector3.zero, axis, DegreesPerSecond * Time.deltaTime);
        Debug.DrawRay(Vector3.zero, axis * 10, Color.yellow, 10f);
    }
}
