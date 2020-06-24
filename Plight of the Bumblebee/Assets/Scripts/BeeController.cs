using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeController : MonoBehaviour
{
    void Start(){
        rb = GetComponent<Rigidbody>();
    }

    Rigidbody rb;

    void Update()
    {
        //UpdatePitchYawRoll();
        UpdateDirectionMovement();
        UpdateLookDirection();
        UpdateCamera();
    }

    public float MinRollRotation = -10f;
    public float MaxRollRotation = 10f;
    float currentRoll = 0f;
    public float MinPitchRotation = -20f;
    public float MaxPitchRotation = 20f;
    float currentPitch = 0f;

    public float MinSpeed = -1f;
    public float MaxSpeed = 1f;
    public float LRSpeed = 1f;
    public float UDSpeed = 1f;
    float currentSpeed = 0f;

    void UpdatePitchYawRoll()
    {
        currentPitch = Mathf.Clamp(currentPitch += Input.GetAxis("Vertical"), MinPitchRotation, MaxPitchRotation);
        currentRoll = Mathf.Clamp(currentRoll += Input.GetAxis("Horizontal"), MinRollRotation, MaxRollRotation);

        transform.rotation = Quaternion.Euler(currentPitch, 0.0f, -currentRoll);
    }

    void UpdateDirectionMovement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            currentSpeed = MaxSpeed;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            currentSpeed = MinSpeed;
        }
        else
        {
            currentSpeed = 0f;
        }

        transform.Translate(Vector3.forward * currentSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * LRSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * LRSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.up * UDSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.C))
        {
            transform.Translate(Vector3.down * UDSpeed * Time.deltaTime);
        }        
    }

    void UpdateLookDirection()
    {
        if (Input.GetAxis("Mouse X") != 0f)
        {
            transform.Rotate(0f, Input.GetAxis("Mouse X"), 0f);
        }
        if (Input.GetAxis("Mouse Y") != 0f)
        {
            transform.Rotate(Input.GetAxis("Mouse Y"), 0f, 0f);
        }
    }

    void UpdateCamera()
    {
        Vector3 moveCamTo = transform.position - transform.forward * 10f + Vector3.up * 5f;
        float bias = 0.96f;
        Camera.main.transform.position = Camera.main.transform.position * bias + moveCamTo * (1f - bias);
        Camera.main.transform.LookAt(transform.position + transform.forward * 30f);
    }
}
