using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveControl : MonoBehaviour
{
    public float speed;
    public float ySpeed;
    public float lSpeed;
    private Rigidbody rb; 
    float ry;
    float x;
    float z;
    float yNeg;
    float yPos;
    void Start() {
        rb = gameObject.GetComponent<Rigidbody>();
    }
    void Update () {
        x = Input.GetAxis("Horizontal") * speed;
        z = Input.GetAxis("Vertical") * speed;
        yNeg = Input.GetAxis("LTrigger") * ySpeed;
        yPos = Input.GetAxis("RTrigger") * ySpeed;
        //ry = Input.GetAxis("LeftRight") * lSpeed;
        //Debug.Log(ry.ToString());
        //Vector3 look = new Vector3(0.0f, ry, 0.0f);
        //rb.AddTorque(look, ForceMode.VelocityChange);
        Vector3 move = new Vector3(x, yPos - yNeg, z);
        rb.AddForce(move, ForceMode.VelocityChange);
        x = 0;
        z = 0;
        ry = 0;
        yNeg = 0;
        yPos = 0;
        // rb.AddTorque(-look, ForceMode.VelocityChange);
    }
}