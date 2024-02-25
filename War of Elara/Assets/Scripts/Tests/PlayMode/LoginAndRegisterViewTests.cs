using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using TMPro;
using UnityEngine.UI;

public class LoginAndRegisterViewTests
{
    [UnityTest]
    public IEnumerator LoginViewDisplaysMessage()
    {
        // Arrange
        var loginViewObject = new GameObject();
        var loginView = loginViewObject.AddComponent<LoginView>();

        var registerButtonObject = new GameObject();
        var registerButton = registerButtonObject.AddComponent<Button>();
        var messageTextObject = new GameObject();
        var messageText = messageTextObject.AddComponent<TextMeshProUGUI>();

        loginView.registerButton = registerButton;
        loginView.messageText = messageText;

        string testMessage = "Text message";


        // Act
        loginView.DisplayMessage(testMessage);


        // Assert
        Assert.AreEqual(testMessage, loginView.messageText.text);


        yield return null;
    }

    [UnityTest]
    public IEnumerator LoginViewClearsMessage()
    {
        var loginViewObject = new GameObject();
        var loginView = loginViewObject.AddComponent<LoginView>();

        var registerButtonObject = new GameObject();
        var registerButton = registerButtonObject.AddComponent<Button>();
        var messageTextObject = new GameObject();
        var messageText = messageTextObject.AddComponent<TextMeshProUGUI>();

        loginView.registerButton = registerButton;
        loginView.messageText = messageText;

        string testMessage = "Text message";


        // Act
        loginView.DisplayMessage(testMessage);
        loginView.ClearMessage();


        // Assert
        Assert.AreEqual("", loginView.messageText.text);


        yield return null;
    }

    [UnityTest]
    public IEnumerator LoginViewClearsMessageOnRegisterButtonClick()
    {
        // Arrange
        var loginViewObject = new GameObject();
        var loginView = loginViewObject.AddComponent<LoginView>();

        var registerButtonObject = new GameObject();
        var registerButton = registerButtonObject.AddComponent<Button>();
        registerButton.onClick.AddListener(() => loginView.ClearMessage());
        var messageTextObject = new GameObject();
        var messageText = messageTextObject.AddComponent<TextMeshProUGUI>();

        loginView.registerButton = registerButton;
        loginView.messageText = messageText;

        string testMessage = "Text message";


        // Act
        loginView.DisplayMessage(testMessage);
        loginView.registerButton.onClick.Invoke();


        // Assert
        Assert.AreEqual("", loginView.messageText.text);


        yield return null;
    }

    [UnityTest]
    public IEnumerator RegisterViewDisplaysOneMessageAfterDisplayingTwo()
    {
        // Arrange
        var registerViewObject = new GameObject();
        var registerView = registerViewObject.AddComponent<RegisterView>();

        var messageText = new GameObject().AddComponent<TextMeshProUGUI>();
        var messageText2 = new GameObject().AddComponent<TextMeshProUGUI>();

        registerView.messageText = messageText;
        registerView.messageText2 = messageText2;


        // Act
        registerView.DisplayMessages("test message 2", "test message 3");
        registerView.DisplayMessage("test message 1");


        // Assert
        Assert.AreEqual("test message 1", registerView.messageText.text);
        Assert.AreEqual("", registerView.messageText2.text);


        yield return null;
    }

    [UnityTest]
    public IEnumerator RegisterViewDisplaysTwoMessagesAfterDisplayingOne()
    {
        // Arrange
        var registerViewObject = new GameObject();
        var registerView = registerViewObject.AddComponent<RegisterView>();

        var messageText = new GameObject().AddComponent<TextMeshProUGUI>();
        var messageText2 = new GameObject().AddComponent<TextMeshProUGUI>();

        registerView.messageText = messageText;
        registerView.messageText2 = messageText2;


        // Act
        registerView.DisplayMessage("test message 1");
        registerView.DisplayMessages("test message 2", "test message 3");


        // Assert
        Assert.AreEqual("test message 2", registerView.messageText.text);
        Assert.AreEqual("test message 3", registerView.messageText2.text);


        yield return null;
    }

    [UnityTest]
    public IEnumerator RegisterViewClearsMessages()
    {
        // Arrange
        var registerViewObject = new GameObject();
        var registerView = registerViewObject.AddComponent<RegisterView>();

        var messageText = new GameObject().AddComponent<TextMeshProUGUI>();
        var messageText2 = new GameObject().AddComponent<TextMeshProUGUI>();

        registerView.messageText = messageText;
        registerView.messageText2 = messageText2;


        // Act
        registerView.DisplayMessages("test message 2", "test message 3");
        registerView.ClearMessages();


        // Assert
        Assert.AreEqual("", registerView.messageText.text);
        Assert.AreEqual("", registerView.messageText2.text);


        yield return null;
    }
}
