namespace GoogleVR.HelloVR
{
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Product : MonoBehaviour
{
    public string nombre;
    public int stock;
    public float precio;

    public Product(string nombre, int stock, float precio) {
        this.nombre = nombre;
        this.stock = stock;
        this.precio = precio;
//     Start is called before the first frame update
    void Start()
    {
    }

  //   Update is called once per frame
    void Update()
    {
        
    }
}
}
}
