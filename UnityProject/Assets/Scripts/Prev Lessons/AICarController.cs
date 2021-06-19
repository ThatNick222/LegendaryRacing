using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class AICarController : MonoBehaviour
{
    public WheelCollider front_LeftWheel;
    public WheelCollider front_RightWheel;
    public WheelCollider back_LeftWheel;
    public WheelCollider back_RightWheel;
    public  float turnValue;
    public  float goValue;
    Rigidbody carRigidBody;
    float timerToRespawn;
    private void Start()
    {
        timerToRespawn = 0;
        carRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
         

        float horizontal = turnValue;           //// turnValue сюда 
        float maxAngleSteer = 35;
        float angle = maxAngleSteer * horizontal;
        front_LeftWheel.steerAngle = angle;
        front_RightWheel.steerAngle = angle;

        float vertical = goValue;             ////goValue сюда 
        float maxTorque = 8490;
        float maxSpeed = 13;
        if (GetComponent<Rigidbody>().velocity.magnitude > maxSpeed)
        {
            GetComponent<Rigidbody>().velocity = GetComponent<Rigidbody>().velocity.normalized * maxSpeed;
            maxTorque = 0;
        }
         
        float speed = maxTorque * vertical;
       
        back_LeftWheel.motorTorque = speed;
        back_RightWheel.motorTorque = speed;

        

        // поворот меша колеса вместе с collider
        ApplyTransformToWheel(front_LeftWheel);
        ApplyTransformToWheel(front_RightWheel);
        ApplyTransformToWheel(back_LeftWheel);
        ApplyTransformToWheel(back_RightWheel);

       
    }
    public void ApplyTransformToWheel(WheelCollider steerWheel)
    {
        Quaternion wheelAngle;
        Vector3 wheelPosition;
        steerWheel.GetWorldPose(out wheelPosition, out wheelAngle);
        steerWheel.gameObject.transform.rotation = wheelAngle;
    }


   
}
