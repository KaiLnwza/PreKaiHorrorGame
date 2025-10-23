using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    int num1 = 1;
    float num2 = 1.3f;
    string playerName = "name";
    bool active = false;

    public float speed;
    public Rigidbody rb;
    public Vector2 inputcontroller;

    void Start()
    {
        Debug.Log(num1);
        Debug.Log(num2);
        Debug.Log(playerName);
        Debug.Log(active);

    }

    // Update is called once per frame
    void Update()
    {
        inputcontroller.x = Input.GetAxis("Horizontal");
        inputcontroller.y = Input.GetAxis("Vertical");

        //if (Input.GetKey(KeyCode.W))
        //{
        //    inputcontroller = Vector2.up;
        //}
        //else
        //{
        //    inputcontroller = Vector2.zero;
        //}
        //rb.velocity = new Vector3(inputcontroller.x * speed, rb.velocity.y, inputcontroller.y * speed);

        //if (Input.GetKey(KeyCode.S))
        //{
        //    inputcontroller = Vector2.down;
        //}
        //else
        //{
        //    inputcontroller = Vector2.zero;
        //}
        //rb.velocity = new Vector3(inputcontroller.x * speed, rb.velocity.y, inputcontroller.y * speed);

        //if (Input.GetKey(KeyCode.A))
        //{
        //    inputcontroller = Vector2.left;
        //}
        //else
        //{
        //    inputcontroller = Vector2.zero;
        //}
        rb.velocity = new Vector3(inputcontroller.x * speed, rb.velocity.y, inputcontroller.y * speed);
    }
}






