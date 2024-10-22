using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicaBotones : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PantallaInicio(){
        SceneManager.LoadScene("PantallaInicio");
    }

    public void PantallaTitulo(){
        SceneManager.LoadScene("PantallaTitulo");
    }

    public void MenuPrincipal(){
        SceneManager.LoadScene("MenuPrincipal");
    }


}
