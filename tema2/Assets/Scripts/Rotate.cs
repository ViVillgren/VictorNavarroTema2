using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.rotation *= Quaternion.Euler(x: 0, y: 10, z: 0);
        }

        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.rotation *= Quaternion.Euler(x: 0, y: -10, z: 0);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.rotation *= Quaternion.Euler(x: 10, y: 0, z: 0);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.rotation *= Quaternion.Euler(x: -10, y: 0, z: 0);
        }
        */
        RotateGameObject(KeyCode.RightArrow, rotation: new Vector3(x: 0, y: 10, z: 0));
        RotateGameObject(KeyCode.LeftArrow, rotation: new Vector3(x: 0, y: -10, z: 0));
        RotateGameObject(KeyCode.UpArrow, rotation: new Vector3(x: 10, y: 0, z: 0));
        RotateGameObject(KeyCode.DownArrow, rotation: new Vector3(x: -10, y: 0, z: 0));
    }

    public void RotateGameObject(KeyCode kCode, Vector3 rotation)
    {
        if(Input.GetKeyDown(kCode))
        {
            transform.rotation *= Quaternion.Euler(rotation);
        }
    }
}
