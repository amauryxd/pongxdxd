using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainCambioEscena : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Jugar()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void Salir()
    {
        Application.Quit();
    }
    public void VolverJ()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void inicio()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
