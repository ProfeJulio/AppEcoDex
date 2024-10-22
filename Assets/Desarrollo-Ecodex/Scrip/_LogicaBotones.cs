using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _LogicaBotones : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void _PantallaInicio(){
        SceneManager.LoadScene("PantallaInicio");
    }

    public void _PantallaTitulo(){
        SceneManager.LoadScene("PantallaTitulo");
    }

    public void _MenuPrincipal(){
        SceneManager.LoadScene("MenuPrincipal");
    }

    public void _Mochila(){
        SceneManager.LoadScene("Mochila");
    }

    public void _SobreEcoDex(){
        SceneManager.LoadScene("SobreEcoDex");
    }

    public void _Biblioteca(){
        SceneManager.LoadScene("Biblioteca");
    }

    public void _Agradecimientos(){
        SceneManager.LoadScene("Agradecimientos");
    }

    public void _Opciones(){
        SceneManager.LoadScene("Opciones");
    }

    public void _Salir(){
        SceneManager.LoadScene("Salir");
    }

    public void _ComienzaTuAventura(){
        SceneManager.LoadScene("ComienzaTuAventura");
    }

    public void _ModoFull(){
        SceneManager.LoadScene("ModoFull");
    }
}
