namespace GoogleVR.HelloVR
{
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductsList : MonoBehaviour
{
    public static Product[] products;
    public static List<Product> productsSelected;
    // Start is called before the first frame update
    void Start()
    {
        products = new Product[4];
        products [0] = new Product ("P1", "CocaCola", "M1", "3L", 9f, "2x1", "SubCat1", "https://google.com");

        productsSelected = new List<Product>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
}
