using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keypad : MonoBehaviour
{
    var number1 = Random.Range(1, 12);
    var number2 = Random.Range(1, 12);
    public int inputCurrent;
    public Button Submit;
    public Button Key1;
    public Button Key2;
    public Button Key3;
    public Button Key4;
    public Button Key5;
    public Button Key6;
    public Button Key7;
    public Button Key8;
    public Button Key9;
    public Button Key0;
    public Text givenAnswer;

    public void Calculate()
    {
        if(inputCurrent == (number1 * number2))
        {
            return
        }
    }

}
