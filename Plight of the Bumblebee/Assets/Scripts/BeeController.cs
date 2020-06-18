using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeController : MonoBehaviour
{
    Rigidbody rb;

    void Start(){
        rb = GetComponent<Rigidbody>();
    }

    public float MinRollRotation = -10f;
    public float MaxRollRotation = 10f;
    float currentRoll = 0f;
    public float MinPitchRotation = -20f;
    public float MaxPitchRotation = 20f;
    float currentPitch = 0f;

    public float MinSpeed = -2f;
    public float MaxSpeed = 10f;
    float currentSpeed = 0f;

    void Update()
    {
        UpdatePitchYawRoll();
        UpdateSpeed();
    }

    void UpdatePitchYawRoll()
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
}
