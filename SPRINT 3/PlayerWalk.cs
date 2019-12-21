namespace GoogleVR.HelloVR
{
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerWalk : MonoBehaviour {


    public TextMesh totalCoins;
    public float playerSpeed;
    public GameObject wall;
    public int count;
    private string selectedProducts="";
    public TextMesh productsText;
    private int totalproducts=0;

    void start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position = transform.position + Camera.main.transform.forward * playerSpeed * Time.deltaTime;
        }
        totalCoins.text = "Productos \n Elegidos";
        if(ProductsList.productsSelected.Count != totalproducts)
        {
            selectedProducts = "";
            for (int i = 0; i < ProductsList.productsSelected.Count; i++)
            {
                selectedProducts+=ProductsList.productsSelected[i].Nombre_Producto+"\n";
                productsText.text = selectedProducts;
            }
            totalproducts = ProductsList.productsSelected.Count;
        }
    }

    /*private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            count++;
            totalCoins.text = count.ToString();
            if (count == 4)
            {
                wall.SetActive(false);
            }
        }
    }*/
}
}
