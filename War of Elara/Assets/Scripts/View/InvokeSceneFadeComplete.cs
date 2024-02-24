using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeSceneFadeComplete : MonoBehaviour
{
    public void InvokeFadeComplete()
    {
        GameManager.instance.SceneFadeComplete();
    }
}
