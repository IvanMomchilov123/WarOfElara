using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using TMPro;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.UI;

public class LoginAndRegisterModel_SetValues_Tests
{
    [UnityTest]
    public IEnumerator LoginAndRegisterModel_SetValues_IsRegisteringWithCorrectValues_SetsPropertiesAndReturnsTrue()
    { 
        // Arrange
        var gameObject = new GameObject();
        var loginAndRegisterModel = gameObject.AddComponent<LoginAndRegisterModel>();


        var registerNameInputObject = new GameObject();
        var registerNameInput = registerNameInputObject.AddComponent<TMP_InputField>();
        //
        var registerPasswordInputObject = new GameObject();
        var registerPasswordInput = registerPasswordInputObject.AddComponent<TMP_InputField>();
        //
        var registerViewObject = new GameObject();
        var registerView = registerViewObject.AddComponent<RegisterView>();
        var messageText1 = new GameObject().AddComponent<TextMeshProUGUI>();
        var messageText2 = new GameObject().AddComponent<TextMeshProUGUI>();


        loginAndRegisterModel.registerNameInput = registerNameInput;
        loginAndRegisterModel.registerPasswordInput = registerPasswordInput;
        loginAndRegisterModel.registerView = registerView;
        registerView.messageText = messageText1;
        registerView.messageText2 = messageText2;


        loginAndRegisterModel.registerNameInput.text = "Test name input.";
        loginAndRegisterModel.registerPasswordInput.text = "Test password input.";

        // Act
        bool returnValue = loginAndRegisterModel.SetValues(true);

        // Assert
        Assert.AreEqual("Test name input.", loginAndRegisterModel.Username);
        Assert.AreEqual("Test password input.", loginAndRegisterModel.Password);
        Assert.IsTrue(returnValue);


        yield return null;
    }

    [UnityTest]
    public IEnumerator LoginAndRegisterModel_SetValues_IsNotRegisteringWithCorrectValues_SetsPropertiesAndReturnsTrue()
    {
        // Arrange
        var gameObject = new GameObject();
        var loginAndRegisterModel = gameObject.AddComponent<LoginAndRegisterModel>();


        var loginNameInputObject = new GameObject();
        var loginNameInput = loginNameInputObject.AddComponent<TMP_InputField>();
        //
        var loginPasswordInputObject = new GameObject();
        var loginPasswordInput = loginPasswordInputObject.AddComponent<TMP_InputField>();
        //
        var loginViewObject = new GameObject();
        var loginView = loginViewObject.AddComponent<LoginView>();
        var messageText1 = new GameObject().AddComponent<TextMeshProUGUI>();
        var registerButton = new GameObject().AddComponent<Button>();


        loginAndRegisterModel.loginNameInput = loginNameInput;
        loginAndRegisterModel.loginPasswordInput = loginPasswordInput;
        loginAndRegisterModel.loginView = loginView;
        loginView.registerButton = registerButton;
        loginView.messageText = messageText1;


        loginAndRegisterModel.loginNameInput.text = "Test name input.";
        loginAndRegisterModel.loginPasswordInput.text = "Test password input.";

        // Act
        bool returnValue = loginAndRegisterModel.SetValues(false);

        // Assert
        Assert.AreEqual("Test name input.", loginAndRegisterModel.Username);
        Assert.AreEqual("Test password input.", loginAndRegisterModel.Password);
        Assert.IsTrue(returnValue);


        yield return null;
    }

    [UnityTest]
    public IEnumerator LoginAndRegisterModel_SetValues_IsRegisteringWithIncorrectUsernameValue_SetsPropertiesAndDisplaysMessageAndReturnsFalse()
    {
        // Arrange
        var gameObject = new GameObject();
        var loginAndRegisterModel = gameObject.AddComponent<LoginAndRegisterModel>();


        var registerNameInputObject = new GameObject();
        var registerNameInput = registerNameInputObject.AddComponent<TMP_InputField>();
        //
        var registerPasswordInputObject = new GameObject();
        var registerPasswordInput = registerPasswordInputObject.AddComponent<TMP_InputField>();
        //
        var registerViewObject = new GameObject();
        var registerView = registerViewObject.AddComponent<RegisterView>();
        var messageText1 = new GameObject().AddComponent<TextMeshProUGUI>();
        var messageText2 = new GameObject().AddComponent<TextMeshProUGUI>();


        loginAndRegisterModel.registerNameInput = registerNameInput;
        loginAndRegisterModel.registerPasswordInput = registerPasswordInput;
        loginAndRegisterModel.registerView = registerView;
        registerView.messageText = messageText1;
        registerView.messageText2 = messageText2;


        loginAndRegisterModel.registerNameInput.text = "ba";
        loginAndRegisterModel.registerPasswordInput.text = "Test password input.";

        // Act
        bool returnValue = loginAndRegisterModel.SetValues(true);

        // Assert
        Assert.AreEqual(null, loginAndRegisterModel.Username);
        Assert.AreEqual("Test password input.", loginAndRegisterModel.Password);
        Assert.AreEqual("Username must be between 3 and 20 characters.", messageText1.text);
        Assert.IsFalse(returnValue);


        yield return null;
    }

    [UnityTest]
    public IEnumerator LoginAndRegisterModel_SetValues_IsRegisteringWithIncorrectPasswordValue_SetsPropertiesAndDisplaysMessageAndReturnsFalse()
    {
        // Arrange
        var gameObject = new GameObject();
        var loginAndRegisterModel = gameObject.AddComponent<LoginAndRegisterModel>();


        var registerNameInputObject = new GameObject();
        var registerNameInput = registerNameInputObject.AddComponent<TMP_InputField>();
        //
        var registerPasswordInputObject = new GameObject();
        var registerPasswordInput = registerPasswordInputObject.AddComponent<TMP_InputField>();
        //
        var registerViewObject = new GameObject();
        var registerView = registerViewObject.AddComponent<RegisterView>();
        var messageText1 = new GameObject().AddComponent<TextMeshProUGUI>();
        var messageText2 = new GameObject().AddComponent<TextMeshProUGUI>();


        loginAndRegisterModel.registerNameInput = registerNameInput;
        loginAndRegisterModel.registerPasswordInput = registerPasswordInput;
        loginAndRegisterModel.registerView = registerView;
        registerView.messageText = messageText1;
        registerView.messageText2 = messageText2;


        loginAndRegisterModel.registerNameInput.text = "Test username input";
        loginAndRegisterModel.registerPasswordInput.text = "3";

        // Act
        bool returnValue = loginAndRegisterModel.SetValues(true);

        // Assert
        Assert.AreEqual("Test username input", loginAndRegisterModel.Username);
        Assert.AreEqual(null, loginAndRegisterModel.Password);
        Assert.AreEqual("Password must be between 8 and 30 characteers.", messageText1.text);
        Assert.IsFalse(returnValue);


        yield return null;
    }

    [UnityTest]
    public IEnumerator LoginAndRegisterModel_SetValues_IsRegisteringWithIncorrectValues_SetsPropertiesAndDisplaysMessageAndReturnsFalse()
    {
        // Arrange
        var gameObject = new GameObject();
        var loginAndRegisterModel = gameObject.AddComponent<LoginAndRegisterModel>();


        var registerNameInputObject = new GameObject();
        var registerNameInput = registerNameInputObject.AddComponent<TMP_InputField>();
        //
        var registerPasswordInputObject = new GameObject();
        var registerPasswordInput = registerPasswordInputObject.AddComponent<TMP_InputField>();
        //
        var registerViewObject = new GameObject();
        var registerView = registerViewObject.AddComponent<RegisterView>();
        var messageText1 = new GameObject().AddComponent<TextMeshProUGUI>();
        var messageText2 = new GameObject().AddComponent<TextMeshProUGUI>();


        loginAndRegisterModel.registerNameInput = registerNameInput;
        loginAndRegisterModel.registerPasswordInput = registerPasswordInput;
        loginAndRegisterModel.registerView = registerView;
        registerView.messageText = messageText1;
        registerView.messageText2 = messageText2;


        loginAndRegisterModel.registerNameInput.text = "ba";
        loginAndRegisterModel.registerPasswordInput.text = "3";

        // Act
        bool returnValue = loginAndRegisterModel.SetValues(true);

        // Assert
        Assert.AreEqual(null, loginAndRegisterModel.Username);
        Assert.AreEqual(null, loginAndRegisterModel.Password);
        Assert.AreEqual("Username must be between 3 and 20 characters.", messageText1.text);
        Assert.IsFalse(returnValue);


        yield return null;
    }

    [UnityTest]
    public IEnumerator LoginAndRegisterModel_SetValues_IsNotRegisteringWithInCorrectValues_SetsPropertiesAndReturnsTrue()
    {
        // Arrange
        var gameObject = new GameObject();
        var loginAndRegisterModel = gameObject.AddComponent<LoginAndRegisterModel>();


        var loginNameInputObject = new GameObject();
        var loginNameInput = loginNameInputObject.AddComponent<TMP_InputField>();
        //
        var loginPasswordInputObject = new GameObject();
        var loginPasswordInput = loginPasswordInputObject.AddComponent<TMP_InputField>();
        //
        var loginViewObject = new GameObject();
        var loginView = loginViewObject.AddComponent<LoginView>();
        var messageText1 = new GameObject().AddComponent<TextMeshProUGUI>();
        var registerButton = new GameObject().AddComponent<Button>();


        loginAndRegisterModel.loginNameInput = loginNameInput;
        loginAndRegisterModel.loginPasswordInput = loginPasswordInput;
        loginAndRegisterModel.loginView = loginView;
        loginView.registerButton = registerButton;
        loginView.messageText = messageText1;


        loginAndRegisterModel.loginNameInput.text = "ba";
        loginAndRegisterModel.loginPasswordInput.text = "3";

        // Act
        bool returnValue = loginAndRegisterModel.SetValues(false);

        // Assert
        Assert.AreEqual(null, loginAndRegisterModel.Username);
        Assert.AreEqual(null, loginAndRegisterModel.Password);
        Assert.IsTrue(returnValue);


        yield return null;
    }
}
