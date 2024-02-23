using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Authentication;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;
using Unity.Services.Core;
using Unity.Services.Authentication;
using UnityEditor.UI;
using UnityEngine.UI;
using TMPro;

public class LoginAndRegisterController : MonoBehaviour
{
    public TMP_InputField loginNameInput;
    public TMP_InputField loginPasswordInput;
    public TMP_InputField registerNameInput;
    public TMP_InputField registerPasswordInput;

    private string username;
    private string password;

    public string Username 
    { 
        get { return username; }
        set 
        {
            if (value.Length < 3 || value.Length > 20)
                this.username = "";

            this.username = value;
        }
    }

    public string Password
    {
        get { return password; }
        set
        {
            if (value.Length < 8 || value.Length > 30)
                this.password = "";

            this.password = value;
        }
    }

    private async void Start()
    {
        try
        {
            await UnityServices.InitializeAsync();
        }
        catch (Exception ex)
        {
            Debug.LogException(ex);
        }
    }


    private void SetValues(bool isRegistering)
    {
        if (isRegistering)
        {
            this.Username = registerNameInput.text;
            this.Password = registerPasswordInput.text;
        }
        else
        {
            this.Username = loginNameInput.text;
            this.Password = loginPasswordInput.text;
        }
    }

    public async void Register()
    {
        SetValues(true);
        await SignUpWithUsernamePassword(this.Username, this.Password);
    }

    public async void Login()
    {
        SetValues(false);
        await SignInWithUsernamePasswordAsync(this.Username, this.Password);
    }

    private async Task SignUpWithUsernamePassword(string username, string password)
    {
        try
        {
            await AuthenticationService.Instance.SignUpWithUsernamePasswordAsync(username, password);
            Debug.Log("SignUp is successful.");
        }
        catch (Unity.Services.Authentication.AuthenticationException ex)
        {
            // Compare error code to AuthenticationErrorCodes
            // Notify the player with the proper error message
            Debug.LogException(ex);
        }
        catch (RequestFailedException ex)
        {
            // Compare error code to CommonErrorCodes
            // Notify the player with the proper error message
            Debug.LogException(ex);
        }
    }

    private async Task SignInWithUsernamePasswordAsync(string username, string password)
    {
        try
        {
            await AuthenticationService.Instance.SignInWithUsernamePasswordAsync(username, password);
            Debug.Log("SignIn is successful.");
        }
        catch (Unity.Services.Authentication.AuthenticationException ex)
        {
            // Compare error code to AuthenticationErrorCodes
            // Notify the player with the proper error message
            Debug.LogException(ex);
        }
        catch (RequestFailedException ex)
        {
            // Compare error code to CommonErrorCodes
            // Notify the player with the proper error message
            Debug.LogException(ex);
        }
    }

}
