namespace GoogleVR.HelloVR
{
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Product : MonoBehaviour
{
    public string Cod_Producto;
    public string Nombre_Producto;
    public string Cod_Marca;
    public string Informacion;
    public float Precio_Venta;
    public string Oferta;
    public string Cod_SubCategoria;
    public string URLVideo;

    public Product(string Cod_Producto, string Nombre_Producto, string Cod_Marca, string Informacion, float Precio_Venta, string Oferta, string Cod_SubCategoria, string URLVideo) {
        this.Cod_Producto = Cod_Producto;
        this.Nombre_Producto = Nombre_Producto;
        this.Cod_Marca = Cod_Marca;
        this.Informacion = Informacion;
        this.Precio_Venta = Precio_Venta;
        this.Oferta = Oferta;
        this.Cod_SubCategoria = Cod_SubCategoria;
        this.URLVideo = URLVideo;

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
