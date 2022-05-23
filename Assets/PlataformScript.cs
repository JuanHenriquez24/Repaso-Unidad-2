using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformScript : MonoBehaviour {

    public float speed;
    public float limitRightX;
    public float limitLeftX;
    public bool toRight;
    public GameObject cilindro;
    public GameObject esfera;

    void Start()
    {
        toRight = true;
    }

    void Update()
    {
       
        if (toRight == true)
        {
            transform.position += new Vector3(speed, 0, 0);
        }
        else
        {
            transform.position -= new Vector3(speed, 0, 0);
        }

        if (transform.position.x > limitRightX)
        {
            toRight = false;
            Instantiate(esfera);
        }
        else if(transform.position.x < limitLeftX)
        {
            toRight = true;
            Instantiate(cilindro);
        }
    }
}
