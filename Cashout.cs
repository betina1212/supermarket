namespace GoogleVR.HelloVR
{
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;
using System.Linq;
using System.Net;
using UnityEngine.SceneManagement;

  [RequireComponent(typeof(Collider))]
public class Cashout : MonoBehaviour
{
    private int codpedid=1;
    private Vector3 startingPosition;
        private Renderer myRenderer;
     public void Reset()
        {
            int sibIdx = transform.GetSiblingIndex();
            int numSibs = transform.parent.childCount;
            for (int i = 0; i < numSibs; i++)
            {
                GameObject sib = transform.parent.GetChild(i).gameObject;
                sib.transform.localPosition = startingPosition;
                sib.SetActive(i == sibIdx);
            }
        }

        /// <summary>Calls the Recenter event.</summary>
        public void Recenter()
        {
#if !UNITY_EDITOR
            GvrCardboardHelpers.Recenter();
#else
            if (GvrEditorEmulator.Instance != null)
            {
                GvrEditorEmulator.Instance.Recenter();
            }
#endif  // !UNITY_EDITOR
        }

        /// <summary>Teleport this instance randomly when triggered by a pointer click.</summary>
        /// <param name="eventData">The pointer click event which triggered this call.</param>
        public void TeleportRandomly(BaseEventData eventData)
        {
            // Only trigger on left input button, which maps to
            // Daydream controller TouchPadButton and Trigger buttons.
            PointerEventData ped = eventData as PointerEventData;
            if (ped != null)
            {
                if (ped.button != PointerEventData.InputButton.Left)
                {
                    return;
                }
            }
            WebClient Client = new WebClient();
            for (int i = 0; i < ProductsList.productsSelected.Count; i++)
            {
                //Debug.Log("Sending" + ProductsList.productsSelected[i].Nombre_Producto);
                //selectedProducts+=ProductsList.productsSelected[i].Nombre_Producto+"\n";
                //productsText.text = selectedProducts;
                Compra c = new Compra();
                c._Cod_Pedido = "ped"+codpedid.ToString();
                c._Cod_Producto = ProductsList.productsSelected[i].Cod_Producto;
                c._Cantidad = 1;
                c._Cod_cliente = "cli1";
                c._Dirección = "Av. América y Libertador";
                string Json = JsonUtility.ToJson(c);
                //Debug.Log(c._Cod_Pedido);
                codpedid++;
                Debug.Log(Json.ToString());
                Client.Headers[HttpRequestHeader.ContentType] = "application/json";
                //Client.UploadValues("URL", "POST", Json);
            }
        }

        private void Start()
        {
            startingPosition = transform.localPosition;
            myRenderer = GetComponent<Renderer>();
        }
}

[Serializable]
public class Compra{
    public string Cod_Pedido;//ped1 obligatorio
    public string Cod_Producto;//=p1 obligatorio
    public int Cantidad;//=2
    public string Cod_cliente;//=cli1 obligatorio
    public string Dirección;//= Av. América y Libertador

    public Compra(){
        this.Cod_Pedido="";
        this.Cod_Producto="";
        this.Cantidad=0;
        this.Cod_cliente="";
        this.Dirección="";
    }

    public string _Cod_Pedido { get{ return Cod_Pedido;} set{Cod_Pedido = value; } }
	public string _Cod_Producto { get{ return Cod_Producto;} set{Cod_Producto = value; } }
    public int _Cantidad { get{ return Cantidad;} set{Cantidad = value; } }
    public string _Cod_cliente { get{ return Cod_cliente;} set{Cod_cliente = value; } }
    public string _Dirección { get{ return Dirección;} set{Dirección = value; } }
}
/*public class Product
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
    }

    public string _Cod_Producto { get{ return Cod_Producto;} set{Cod_Producto = value; } }
	public string _Nombre_Producto { get{ return Nombre_Producto;} set{Nombre_Producto = value; } }
    public string _Cod_Marca { get{ return Cod_Marca;} set{Cod_Marca = value; } }
    public string _Informacion { get{ return Informacion;} set{Informacion = value; } }
    public float _Precio_Venta { get{ return Precio_Venta;} set{Precio_Venta = value; } }
    public string _Oferta { get{ return Oferta;} set{Oferta = value; } }
    public string _Cod_SubCategoria { get{ return Cod_SubCategoria;} set{Cod_SubCategoria = value; } }
    public string _URLVideo { get{ return URLVideo;} set{URLVideo = value; } }

}*/



}
