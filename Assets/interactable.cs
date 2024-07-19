using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactable : MonoBehaviour
{
    public string promptMessage;

    public void baseinteract() 
    {
        
        interact();
    }

    protected virtual void interact()
    {
        
    }
}
