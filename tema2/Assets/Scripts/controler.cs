using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controler : MonoBehaviour
{
    private float limX = 12.0f;
    private float limYPos = 6.0f;
    private float limYNeg = -4.0f;
    private float limZ = 7.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveGameObject(Vector3.right, KeyCode.D);
        MoveGameObject(Vector3.left, KeyCode.A);
        MoveGameObject(Vector3.forward, KeyCode.W);
        MoveGameObject(Vector3.back, KeyCode.S);
        MoveGameObject(Vector3.up, KeyCode.Space);
        MoveGameObject(Vector3.down, KeyCode.X);

        //Limites de Pantalla
        if (transform.position.x >= limX)
        {
            transform.position = new Vector3(limX, transform.position.y, transform.position.z);
        }

        if (transform.position.x <= -limX)
        {
            transform.position = new Vector3(-limX, transform.position.y, transform.position.z);
        }

        if (transform.position.y >= limYPos)
        {
            transform.position = new Vector3(transform.position.x, limYPos, transform.position.z);
        }

        if (transform.position.y <= limYNeg)
        {
            transform.position = new Vector3(transform.position.x, limYNeg, transform.position.z);
        }

        if (transform.position.z >= limZ)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, limZ);
        }

        if (transform.position.z <= -limZ)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -limZ);
        }
    }

    public void MoveGameObject(Vector3 direction, KeyCode keyCode)
    {
        if (Input.GetKeyDown(keyCode))
        {
            transform.position += direction;
        }
    }
}

