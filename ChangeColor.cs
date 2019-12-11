using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public void Red()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }
    public void Green()
    {
        GetComponent<Renderer>().material.color = Color.green;
    }
    public void Black()
    {
        GetComponent<Renderer>().material.color = Color.black;
    }
}
