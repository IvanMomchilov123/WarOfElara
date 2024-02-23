using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.VersionControl;
using UnityEngine;

public class RegisterView : MonoBehaviour
{
    public TextMeshProUGUI messageText;
    public TextMeshProUGUI messageText2;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            FadeOutRegisterScreen();
        }
    }

    public void DisplayMessage(string message)
    {
        messageText.text = message;
        messageText2.text = "";
    }

    public void DisplayMessages(string message1, string message2)
    {
        messageText.text = message1;
        messageText2.text = message2;
    }

    private void ClearMessages()
    {
        messageText.text = "";
        messageText2.text = "";
    }

    public void FadeOutRegisterScreen()
    {
        this.GetComponentInChildren<Animator>().SetTrigger("fadeOut");
        ClearMessages();
    }
}
