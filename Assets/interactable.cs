using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class interactable : MonoBehaviour
{

    public SpriteRenderer border;

    private void Start()
    {
        border = gameObject.GetComponent<SpriteRenderer>();

        border.enabled = false;
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        print("anuthing");
        border.enabled = true;
        
        
    }
}
