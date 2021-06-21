using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class KeypadTask : MonoBehaviour
{

    int n1;
    int n2;

    public float delayTime = 3f;


    public Text cardCode ;

    public Text inputCode;

    public int codeLength;

    private string ans;


    private bool isResetting = false;

    private void OnEnable()
    {
        n1 = Random.Range(3, 9);
        n2 = Random.Range(4, 9);

        ans = (n1 * n2).ToString();
        cardCode.text = (n1 + " x " + n2);
        inputCode.text = string.Empty;
    }

    public void ButtonClick(int number)
    {
        if (isResetting) { return; }

        inputCode.text += number;

        if (inputCode.text == ans)
        {
            inputCode.text = inputCode.text + " is Correct.";
            Invoke("DelayedActionCorrect", delayTime);
        }
        else if (inputCode.text.Length >= codeLength)
        {
            inputCode.text = inputCode.text + " is Fail.";
            Invoke("DelayedActionFail", delayTime);

        }
    }

    void DelayedActionCorrect()
    {
        SceneManager.LoadScene(sceneBuildIndex: 0);
    }
    void DelayedActionFail()
    {
        SceneManager.LoadScene(sceneBuildIndex: 2);
    }

}
