using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class interactable : MonoBehaviour
{

    //public GameObject currentInteract = null;
    public TextMeshPro interactText;
    bool collided = false;


    void OnCollisionEnter2D(Collision2D collision)
    {
        
        interactText.gameObject.SetActive(true);
        collided = true;
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && collided == true)
        {
            print("fat");
            SceneManager.LoadScene(1);
        }

    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        interactText.gameObject.SetActive(false);
        collided = false;
    }
}
