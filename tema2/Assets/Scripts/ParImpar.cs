using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.UI;

public class ParImpar : MonoBehaviour
{
    public int par = 2;

    // Start is called before the first frame update
    void Start()
    {
        if (par % 2 == 0)
        {
            Debug.Log(message: $"El numero {par} es par");
        }
        else
        {
            Debug.Log(message: $"El numero {par} no es par");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            par = int.Parse(GetComponent<InputField>().text);
            SerPar(par);
        }
    }

    public void SerPar(int par)
    {
        if (par % 2 == 0)
        {
            Debug.Log(message: $"El numero {par} es par");
        }
        else
        {
            Debug.Log(message: $"El numero {par} no es par");
        }
    }
}
