using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BeeController : MonoBehaviour
{
    Rigidbody rb;
    public Transform GFXTransform;

    void Awake(){
        rb = GetComponent<Rigidbody>();

        bc = new BeeControls();
    }

    private void OnEnable()
    {
        bc.Enable();
    }

    private void OnDisable()
    {
        bc.Disable();
    }

    public float MinMaxPitch = 30f;
    public float YawPower = 4f;
    public float MinMaxRoll = 30f;
    public float UDSpeed = 5f;
    public float FBSpeed = 5f;
    public float LRSpeed = 5f;

    private float yaw, finalPitch, finalYaw, finalRoll;
    public float LerpSpeed = 2f;

    private BeeControls bc;

    void FixedUpdate()
    {
        HandlePower();
        HandleRotation();
        HandleGFX();
    }

    void HandlePower()
    {
        Vector3 UDForce = transform.up * (( rb.mass * Physics.gravity.magnitude) + (bc.Bee.Power.ReadValue<float>()) * UDSpeed);
        rb.AddForce(UDForce, ForceMode.Force);

        Vector3 FBForce = transform.forward * (bc.Bee.Cyclic.ReadValue<Vector2>().y * FBSpeed);
        rb.AddForce(FBForce, ForceMode.Force);

        Vector3 LRForce = transform.right * (bc.Bee.Cyclic.ReadValue<Vector2>().x * LRSpeed);
        rb.AddForce(LRForce, ForceMode.Force);
    }

    void HandleRotation()
    {
        yaw += bc.Bee.Pedals.ReadValue<float>() * YawPower;
        finalYaw = Mathf.Lerp(finalYaw, yaw, Time.deltaTime * LerpSpeed);

        Quaternion rot = Quaternion.Euler(0f, finalYaw, 0f);
        rb.MoveRotation(rot);
    }

    void HandleGFX()
    {
        float pitch = bc.Bee.Cyclic.ReadValue<Vector2>().y * MinMaxPitch;
        float roll = bc.Bee.Cyclic.ReadValue<Vector2>().x * MinMaxRoll;

        finalPitch = Mathf.Lerp(finalPitch, pitch, Time.deltaTime * LerpSpeed);
        finalRoll = Mathf.Lerp(finalRoll, roll, Time.deltaTime * LerpSpeed);

        Quaternion rot = Quaternion.Euler(finalPitch, finalYaw, -finalRoll);
        GFXTransform.rotation = rot;
    }
}
