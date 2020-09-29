using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarDrive : MonoBehaviour
{

    public float speed;

    public float turnSpeed;

    public float gravityMultiplier;

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
        Turn();
        Fall();       
    }

    //前後の移動
    void Move(){
        if(Input.GetKey(KeyCode.W)){
            Debug.Log("WWWWWWWWWWWWWWW");
            rb.AddRelativeForce(new Vector3(Vector3.forward.x,0,Vector3.forward.z)*speed*10);
        }
        else if(Input.GetKey(KeyCode.S)){
            rb.AddRelativeForce(new Vector3(Vector3.forward.x,0,Vector3.forward.z)*-speed*10);
        }
        Vector3 localVelocity= transform.InverseTransformDirection(rb.velocity);
        localVelocity.x=0;
        rb.velocity=transform.TransformDirection(localVelocity);
    }

    //y軸中心の回転
    void Turn(){
        if(Input.GetKey(KeyCode.D)){
            rb.AddTorque(Vector3.up*turnSpeed);
        }
        else if(Input.GetKey(KeyCode.A)){
            rb.AddTorque(-Vector3.up*turnSpeed);
        }
    }

    //重力をかける
    void Fall(){
        rb.AddForce(Vector3.down * gravityMultiplier*10);
    }
}
