using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaroController : MonoBehaviour
{
    public WheelCollider Forward_RightWheel;
    public WheelCollider Forward_LeftWheel;
    public WheelCollider Rear_LeftWheel;
    public WheelCollider Rear_RightWheel;

public float maxSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        float horizontal = Input.GetAxis("Horizontal");
        float maxAngleSteer = 30;
        float angle = maxAngleSteer * horizontal;
        Forward_LeftWheel.steerAngle = angle;
        Forward_RightWheel.steerAngle = angle;
        Quaternion wheelAngle;
        Vector3 wheelPosition;
        Forward_LeftWheel.GetWorldPose(out wheelPosition, out wheelAngle);
        Forward_RightWheel.GetWorldPose(out wheelPosition, out wheelAngle);

        float vertical = Input.GetAxis("Vertical");
        float maxTorque = 4750;
        float speed = maxTorque * vertical;
        Rear_LeftWheel.motorTorque = speed;
        Rear_RightWheel.motorTorque = speed;
        Quaternion motorTorque;
        Rear_LeftWheel.GetWorldPose(out wheelPosition, out motorTorque);
        Rear_RightWheel.GetWorldPose(out wheelPosition, out motorTorque);
        Rear_LeftWheel.gameObject.transform.rotation = motorTorque;
        Rear_RightWheel.gameObject.transform.rotation = motorTorque;

         float jump = Input.GetAxis("Jump");
        float maxbrakeTorque = 4750;
        float brake = maxbrakeTorque * jump;
        Rear_RightWheel.brakeTorque = brake;
        Rear_LeftWheel.brakeTorque = brake;
        Forward_LeftWheel.brakeTorque = brake;
        Forward_RightWheel.brakeTorque = brake;

    }
}
