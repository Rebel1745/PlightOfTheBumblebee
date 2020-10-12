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
    public float LandingSpeed = 0.3f;

    private float yaw, finalPitch, finalYaw, finalRoll;
    public float LerpSpeed = 2f;

    private BeeControls bc;

    public Transform LandingPoint;
    public bool CanLand = false;
    public Transform LandTarget = null;
    bool isLanding = false;

    public void UpdateLandingTarget(bool canLand, Transform landTarget)
    {
        CanLand = canLand;
        LandTarget = landTarget;
        isLanding = false;
    }

    void FixedUpdate()
    {
        if (!isLanding)
        {
            HandlePower();
            HandleRotation();
            HandleGFX();
            CheckLanding();
        }
        
    }

    IEnumerator Land()
    {
        isLanding = true;
        // snaps the bee to the landing poing
        //transform.position += LandTarget.position - LandingPoint.position;

        Vector3 targetPosition = transform.position + LandTarget.position - LandingPoint.position;

        // smoothly moves the bee to the landing point
        transform.position = Vector3.Lerp(transform.position, targetPosition, 10);

        if (Vector3.Distance(transform.position, targetPosition) < 0.001f)
        {
            // Landed!
            transform.position = targetPosition;
            isLanding = false;
        }

        yield return null;
    }

    void CheckLanding()
    {
        if (CanLand)
        {
            if (bc.Bee.Land.ReadValue<float>() == 1f)
            {
                StartCoroutine(Land());
            }
        }
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
