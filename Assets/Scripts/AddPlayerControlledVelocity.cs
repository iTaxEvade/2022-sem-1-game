using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPlayerControlledVelocity : MonoBehaviour
{

    [SerializeField]
    Vector3 v3force;
    [SerializeField]
    KeyCode keyPositive;
    [SerializeField]
    KeyCode keyNegative;
    [SerializeField]
    KeyCode keyUp;
    Rigidbody rb;
    public float jumpForce = 2.0f;
    private Vector3 jump;
    public bool isOnGround;
    public static float difficulty = 10.0f;

    public DifficultyButton DBscript;
    public DifficultyButton DB2;
    public DifficultyButton DB3;
    public void Start()
    {
        DBscript = GameObject.Find("EasyB").GetComponent<DifficultyButton>();
        DB2 = GameObject.Find("MediumB").GetComponent<DifficultyButton>();
        DB3 = GameObject.Find("HardB").GetComponent<DifficultyButton>();
        
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
    }
    private void OnCollisionEnter(Collision collision)
    {
        isOnGround = true;
    }



    // Start is called before the first frame update

    // Update is called once per frame
    void FixedUpdate()
    {
        if(!DBscript.isGameOver || !DB2.isGameOver || !DB3.isGameOver){
            if (Input.GetKey(keyUp) && isOnGround)
        {
            rb.AddForce( jump * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }
       
        if (Input.GetKey(keyPositive))
            GetComponent<Rigidbody>().velocity += v3force;
        if (Input.GetKey(keyNegative))
            GetComponent<Rigidbody>().velocity -= v3force;
    }
        }
        
}

