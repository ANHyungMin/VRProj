using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableTest : MonoBehaviour
{
    public void HoverEnter()
    {
        Debug.Log("HoverEnter");
    }
    public void HoverExite()
    {
        Debug.Log("HoverExite");
    }
    public void SelectEnter()
    {
        Debug.Log("SelectEnter");
    }
    public void SelectExit()
    {
        Debug.Log("SelectExit");
    }

    public void Activated()
    {
        Debug.Log("Activated");
    }

    public void Deactivated()
    {
        Debug.Log("Deactivated");
    }
}

