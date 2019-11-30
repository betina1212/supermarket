using UnityEngine;
using MySql.Data.MySqlClient;

public class AdminMYSQL : MonoBehaviour
{

    public string servidorBaseDatos;
    public string nombreBaseDatos;
    public string usuarioBaseDatos;
    public string contraseñaBaseDatos;


    private string datosConexion;
    private MySqlConnection conexion;

    void Start()
    {

        datosConexion = "Server=" + servidorBaseDatos
                      + ";DataBase=" + nombreBaseDatos
                      + ";Uid=" + usuarioBaseDatos
                      + ";Pwd=" + contraseñaBaseDatos
                      + ";";

        ConectarConServidorBaseDatos();

    }

    private void ConectarConServidorBaseDatos()
    {
        conexion = new MySqlConnection(datosConexion);

        try
        {
            conexion.Open();
            Debug.Log("Conexion con BD correcta!");
        }

        catch(MySqlException error)
        {
            Debug.LogError("Imposible conectar con Base de Datos" + error);
        }
    }

}
