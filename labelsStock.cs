﻿namespace GoogleVR.HelloVR
{
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class labelsStock : MonoBehaviour
{
    public Text nameLabel;
    public int item;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //GameObject player = GameObject.FindGameObjectWithTag("icosa");
        //stock = player.GetComponent<ObjectController>().stock;
        Vector3 namePos = Camera.main.WorldToScreenPoint(this.transform.position);
        nameLabel.transform.position = namePos;
        nameLabel.text= ProductsList.products[item].Nombre_Producto + " " + ProductsList.products[item].Informacion + " " + ProductsList.products[item].Precio_Venta.ToString() + "Bs.";
    }
}
}
