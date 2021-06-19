using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public WheelCollider front_LeftWheel;
    public WheelCollider front_RightWheel;
    public WheelCollider back_LeftWheel;
    public WheelCollider back_RightWheel;
    public float maxSpeed;

    // Start is called before the first frame update
    void Start()
    {
        maxSpeed = 17;
    }

    // Update is called once per frame
    void Update()
    {
        float brakes = 0;
        if (Input.GetKey(KeyCode.Space))
        {
            brakes = 3000;
        }
        front_LeftWheel.brakeTorque = brakes;
        front_RightWheel.brakeTorque = brakes;
        back_LeftWheel.brakeTorque = brakes;
        back_RightWheel.brakeTorque = brakes;

        float horizontal = Input.GetAxis("Horizontal");
        float maxAngleSteer = 42;
        float angle = maxAngleSteer * horizontal;
        front_LeftWheel.steerAngle = angle;
        front_RightWheel.steerAngle = angle;
        float vertical = Input.GetAxis("Vertical");
        float maxTorque = 7890;
        if (GetComponent<Rigidbody>().velocity.magnitude > maxSpeed)
        {
            GetComponent<Rigidbody>().velocity = GetComponent<Rigidbody>().velocity.normalized * maxSpeed;
            maxTorque = 0;
        }
        float speed = maxTorque * vertical;
        back_LeftWheel.motorTorque = speed;
        back_RightWheel.motorTorque = speed;
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
