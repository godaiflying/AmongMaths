using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LastDitch : MonoBehaviour
{

    int n1;
    int n2;

    public Text cardCode;

    public Text inputCode;

    public int codeLength = 3;

    public float codeResetTimeInSeconds;


    private bool isResetting = false;

    private void OnEnable()
    {
        n1 = Random.Range(0, 12);
        n2 = Random.Range(0, 12);

        string code = string.Empty;

        for (int i = 0; i < codeLength; i++)
        {
            code += Random.Range(1, 10);
        }

        cardCode.text = code;
        inputCode.text = string.Empty;
    }

    public void ButtonClick(int number)
    {
        if (isResetting) { return; }

        inputCode.text += number;

        if (inputCode.text == cardCode.text)
        {
            inputCode.text = "Correct.";
            StartCoroutine(ResetCode());
        }
        else if (inputCode.text.Length >= codeLength)
        {
            inputCode.text = "Fail.";
            StartCoroutine(ResetCode());

        }
    }
    private IEnumerator ResetCode()
    {
        isResetting = true;

        yield return new WaitForSeconds(codeResetTimeInSeconds);

        isResetting = false;
    }
}
