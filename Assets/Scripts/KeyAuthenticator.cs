using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class KeyAuthenticator : MonoBehaviour
{
    public TMP_InputField Field;
    public TMP_Text ErrorMSG;
    private string Key = "key";

    public void Authenticate()
    {
        if (Field.text == Key)
        {
            Debug.Log("Key Passed check");
            ErrorMSG.text = "";
            SceneManager.LoadScene("test1");

        }
        else
        {
            ErrorMSG.text = "*Wrong Key";
        }
    }
}