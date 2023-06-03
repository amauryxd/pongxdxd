using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroyThis : MonoBehaviour
{
    static DontDestroyThis instance = null;

    private void Awake()
    {
        if(instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
        GameObject.DontDestroyOnLoad(gameObject);
    }

}
