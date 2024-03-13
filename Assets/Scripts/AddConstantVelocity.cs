using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddConstantVelocity : MonoBehaviour
{

    [SerializeField]
    Vector3 v3force;
    // Start is called before the first frame update

    // Update is called once per frame
    void FixedUpdate()
    {
        GetComponent<Rigidbody>().velocity += v3force;
    }
}
