using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomRange : MonoBehaviour
{

    int n1;
    int n2;
    public Text Question;
    // Start is called before the first frame update
    void Start()
    {
        n1 = Random.Range(0, 99);
        n2 = Random.Range(0, 99);

        Text = (n1 * n2);
    }


}
