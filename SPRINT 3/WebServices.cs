using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;
using System.Net;
using UnityEngine.SceneManagement;

public class WebServices : MonoBehaviour
{
    public Text texto;
    public Text user;
    public Text pass;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void VerificarUsuario()
	{
		userModel a;
		try{
            Debug.Log(user.text);
		var json = new WebClient().DownloadString(string.Format("http://192.168.42.232/Gestion/api/Usuarios/{0}", user.text));
		a = JsonUtility.FromJson<userModel>(json);//JsonConvert.DeserializeObject<bool> (json);
			if(a._Usuario == null){
                Debug.Log("datos incorrectos");
                texto.text = "datos incorrectos";
                //SceneManager.LoadScene("lvl_01");
                //SceneCtrl.ChangeScene("lvl_01");
            }
            else{
                SceneManager.LoadScene("lvl_01");
                //SceneCtrl.ChangeScene("lvl_01");
            }
		}catch(Exception){
            Debug.Log("fallo en la conexion");
			texto.text = "fallo en la conexion";
            //SceneManager.LoadScene("lvl_01");
		}
	}
}

public class userModel{
    private string Usuario;
    private string Password;

    public userModel(){
        Usuario = "";
        Password = "";
    }

    public string _Usuario { get{ return Usuario;} set{Usuario = value; } }
	public string _Password { get{ return Password;} set{Password = value; } }
}
