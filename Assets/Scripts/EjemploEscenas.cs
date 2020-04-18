using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EjemploEscenas : MonoBehaviour
{


    void Start()
    {

    }

    void Update()
    {

    }

    public void onClick1()
    {
        SceneManager.LoadScene("EscenasClase 1");
    }
    public void onClick2()
    {
        SceneManager.LoadScene("EscenasClase 2");
    }
    public void onClick3()
    {
        SceneManager.LoadScene("EscenasClase 3");
    }
}
