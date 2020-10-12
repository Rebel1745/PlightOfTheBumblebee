using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandingZone : MonoBehaviour
{

    SphereCollider sc;

    // Start is called before the first frame update
    void Awake()
    {
        sc = GetComponent<SphereCollider>();
        LandingHelperRadius = sc.radius;
    }

    public float LandingHelperRadius = 0.5f;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            other.GetComponentInParent<BeeController>().UpdateLandingTarget(true, this.transform);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponentInParent<BeeController>().UpdateLandingTarget(false, null);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(1, 1, 0, 0.75F);
        Gizmos.DrawSphere(transform.position, LandingHelperRadius);
    }
}
