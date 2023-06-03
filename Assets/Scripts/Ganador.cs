using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class Ganador : MonoBehaviour
{

    public TMP_Text text11;
    public TMP_Text text22;

    public GameObject jug1tex;
    public GameObject jug2tex;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(int.Parse(text11.text) == 10) {
            jug1tex.SetActive(true);
        }
        if (int.Parse(text22.text) == 10)
        {
            jug2tex.SetActive(true);
        }
        if (int.Parse(text11.text) == 12)
        {
            SceneManager.LoadScene("Ganador1");
        }
        if (int.Parse(text22.text) == 12)
        {
            SceneManager.LoadScene("Ganador2");
        }
    }
}
