namespace GoogleVR.HelloVR
{
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductsList : MonoBehaviour
{
    public static Product[] products;
    // Start is called before the first frame update
    void Start()
    {
        products = new Product[4];
        products [0] = new Product ("cereal", 50, 1f);
        products [1] = new Product ("menta", 25, 0.5f);
        products [2] = new Product ("galletas", 15, 2f);
        products [3] = new Product ("Jugo", 10, 12f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
}
