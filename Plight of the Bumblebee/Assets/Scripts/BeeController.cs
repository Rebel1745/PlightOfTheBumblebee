using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeController : MonoBehaviour
{
    void Start(){
        Drone = GetComponent<Rigidbody>();
    }

    public Rigidbody Drone;

    /*Speed*/
    public float ForwardBackward = 5f;
    /*Speed*/
    public float Tilt = 5f;
    /*Speed*/
    public float FlyLeftRight = 5f;
    /*Speed*/
    public float UpDown = 5f;

    private Vector3 DroneRotation;

    void Update()
    {
        DroneRotation = Drone.transform.localEulerAngles;
        if (DroneRotation.z > 10 && DroneRotation.z <= 180) { Drone.AddRelativeTorque(0, 0, -10); }//if tilt too big(stabilizes drone on z-axis)
        if (DroneRotation.z > 180 && DroneRotation.z <= 350) { Drone.AddRelativeTorque(0, 0, 10); }//if tilt too big(stabilizes drone on z-axis)
        if (DroneRotation.z > 1 && DroneRotation.z <= 10) { Drone.AddRelativeTorque(0, 0, -3); }//if tilt not very big(stabilizes drone on z-axis)
        if (DroneRotation.z > 350 && DroneRotation.z < 359) { Drone.AddRelativeTorque(0, 0, 3); }//if tilt not very big(stabilizes drone on z-axis)
        
        if (Input.GetKey(KeyCode.A)) { Drone.AddRelativeTorque(0, Tilt / -1, 0); }//tilt drone left
        if (Input.GetKey(KeyCode.D)) { Drone.AddRelativeTorque(0, Tilt, 0); }//tilt drone right

        if (DroneRotation.x > 10 && DroneRotation.x <= 180) { Drone.AddRelativeTorque(-10, 0, 0); }//if tilt too big(stabilizes drone on x-axis)
        if (DroneRotation.x > 180 && DroneRotation.x <= 350) { Drone.AddRelativeTorque(10, 0, 0); }//if tilt too big(stabilizes drone on x-axis)
        if (DroneRotation.x > 1 && DroneRotation.x <= 10) { Drone.AddRelativeTorque(-3, 0, 0); }//if tilt not very big(stabilizes drone on x-axis)
        if (DroneRotation.x > 350 && DroneRotation.x < 359) { Drone.AddRelativeTorque(3, 0, 0); }//if tilt not very big(stabilizes drone on x-axis)


        //Drone.AddForce(0, 9, 0);//drone not lose height very fast, if you want not to lose height al all change 9 into 9.80665 
        
        if (Input.GetKey(KeyCode.W)) { Drone.AddRelativeForce(0, 0, ForwardBackward); Drone.AddRelativeTorque(10, 0, 0); }//drone fly forward

        if (Input.GetKey(KeyCode.A)) { Drone.AddRelativeForce(FlyLeftRight / -1, 0, 0); Drone.AddRelativeTorque(0, 0, 10); }//rotate drone left

        if (Input.GetKey(KeyCode.D)) { Drone.AddRelativeForce(FlyLeftRight, 0, 0); Drone.AddRelativeTorque(0, 0, -10); }//rotate drone right

        if (Input.GetKey(KeyCode.S)) { Drone.AddRelativeForce(0, 0, ForwardBackward / -1); Drone.AddRelativeTorque(-10, 0, 0); }// drone fly backward

        if (Input.GetKey(KeyCode.Space)) { Drone.AddRelativeForce(0, UpDown, 0); }//drone fly up

        if (Input.GetKey(KeyCode.LeftShift)) { Drone.AddRelativeForce(0, UpDown / -1, 0); }//drone fly down

        //UpdatePitchYawRoll();
        //UpdateSpeed();
        //UpdateLookDirection();
    }

    /*void UpdatePitchYawRoll()
    {
        currentPitch = Mathf.Clamp(currentPitch += Input.GetAxis("Vertical"), MinPitchRotation, MaxPitchRotation);
        currentRoll = Mathf.Clamp(currentRoll += Input.GetAxis("Horizontal"), MinRollRotation, MaxRollRotation);

        transform.rotation = Quaternion.Euler(currentPitch, 0.0f, -currentRoll);
    }

    void UpdateSpeed()
    {
        currentSpeed = Mathf.Clamp(currentSpeed + Input.GetAxis("Vertical"), MinSpeed, MaxSpeed);
        rb.AddRelativeForce(Vector3.forward * currentSpeed);
    }

    void UpdateLookDirection()
    {
        transform.LookAt(Camera.main.ScreenToWorldPoint(Input.mousePosition));
    }*/
}
