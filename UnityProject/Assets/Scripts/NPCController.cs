using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController : MonoBehaviour
{
    public float goValue, turnValue;

    public WheelCollider Forward_LeftWheel;
    public WheelCollider Forward_RightWheel;
    public WheelCollider Rear_LeftWheel;
    public WheelCollider Rear_RightWheel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       float horizontal = turnValue;
       float MaxAngleSteer = 55; 
       float angle = MaxAngleSteer * horizontal;
       Forward_LeftWheel.steerAngle = angle;
       Forward_RightWheel.steerAngle = angle;
       Quaternion wheelAngle;
       Vector3 wheelPosition;
       Forward_LeftWheel.GetWorldPose (out wheelPosition, out wheelAngle);
       Forward_RightWheel.GetWorldPose (out wheelPosition, out wheelAngle);
       Forward_LeftWheel.gameObject.transform.rotation = wheelAngle;
       Forward_RightWheel.gameObject.transform.rotation = wheelAngle;

       float vertical = goValue;
       float maxTorque = 0;
       if(GetComponent<Rigidbody>().velocity.magnitude < 15)
       {
           maxTorque = 3200;
       }
       float speed = maxTorque * vertical;
       Rear_LeftWheel.motorTorque = speed;
       Rear_RightWheel.motorTorque = speed;
       Quaternion motorTorque;
       Rear_LeftWheel.GetWorldPose (out wheelPosition, out motorTorque);
       Rear_RightWheel.GetWorldPose (out wheelPosition, out motorTorque);
       Rear_LeftWheel.gameObject.transform.rotation = motorTorque;
       Rear_RightWheel.gameObject.transform.rotation = motorTorque;
    }
}
