using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RegisterView : MonoBehaviour
{
    public TextMeshProUGUI messageText;
    public TextMeshProUGUI messageText2;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            if (GetComponentInChildren<Image>().color.a == 1)
                FadeOutRegisterScreen();
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
