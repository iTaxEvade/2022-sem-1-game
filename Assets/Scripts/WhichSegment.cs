using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhichSegment : MonoBehaviour
{

    private float zLimit = -60;
    public GameObject prefab;
    public int quadrant;

    public GameObject quad1;
    public GameObject quad2;
    public GameObject quad3;
    public GameObject quad4;




    private void Start()
    {
        quadrant = Random.Range(1, 5);
        if (quadrant == 1)
        {
            quad1.SetActive(false);
            quad2.SetActive(true);
            quad3.SetActive(true);
            quad4.SetActive(true);
        }
        if (quadrant == 2)
        {
            quad2.SetActive(false);
            quad1.SetActive(true);
            quad3.SetActive(true);
            quad4.SetActive(true);
        }
        if (quadrant == 3)
        {
            quad3.SetActive(false);
            quad1.SetActive(true);
            quad2.SetActive(true);
            quad4.SetActive(true);
        }
        if (quadrant == 4)
        {
            quad4.SetActive(false);
            quad1.SetActive(true);
            quad2.SetActive(true);
            quad3.SetActive(true);
        }

    }


    void Update()
    {
       
        if (transform.position.z < zLimit)
        {

            transform.position = new Vector3(85.33f, -4.37f, 5.26f);
            quadrant = Random.Range(1, 5);
            if (quadrant == 1)
            {
                quad1.SetActive(false);
                quad2.SetActive(true);
                quad3.SetActive(true);
                quad4.SetActive(true);
            }
            if (quadrant == 2)
            {
                quad2.SetActive(false);
                quad1.SetActive(true);
                quad3.SetActive(true);
                quad4.SetActive(true);
            }
            if (quadrant == 3)
            {
                quad3.SetActive(false);
                quad1.SetActive(true);
                quad2.SetActive(true);
                quad4.SetActive(true);
            }
            if (quadrant == 4)
            {
                quad4.SetActive(false);
                quad1.SetActive(true);
                quad2.SetActive(true);
                quad3.SetActive(true);
            }
        
        }
        

      

    }
}
