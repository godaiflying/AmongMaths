using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeypadTask : MonoBehaviour
{

    int n1;
    int n2;

    public Text cardCode ;

    public Text inputCode;

    public int codeLength;

    public string ans;

    public float codeResetTimeInSeconds;


    private bool isResetting = false;

    private void OnEnable()
    {
        n1 = Random.Range(1, 9);
        n2 = Random.Range(1, 9);

        ans = (n1 * n2).ToString();
        cardCode.text = (n1 + " x " + n2);
        inputCode.text = string.Empty;
    }

    public void ButtonClick(int number)
    {
        if (isResetting) { return; }

        inputCode.text += number;

        if (inputCode.text == ans.TrimStart(new char[] { '0' }))
        {
            inputCode.text = inputCode.text + " is Correct.";
            StartCoroutine(ResetCode());
        }
        else if (inputCode.text.Length >= codeLength)
        {
            inputCode.text = inputCode.text + " is Fail.";
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
