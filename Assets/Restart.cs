using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public void Start()
    {
        print(SceneManager.GetActiveScene().name);
    }
    public void Onclick()
    {
        SceneManager.LoadScene(0);
    }

}
