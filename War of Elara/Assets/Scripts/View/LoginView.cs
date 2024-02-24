using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LoginView : MonoBehaviour
{
    public TextMeshProUGUI messageText;
    public Button registerButton;

    private void Start()
    {
        registerButton.onClick.AddListener(() => ClearMessage());
    }

    public void DisplayMessage(string message)
    {
        messageText.text = message;
    }

    private void ClearMessage()
    {
        messageText.text = "";
    }
}
