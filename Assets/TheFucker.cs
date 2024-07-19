using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheFucker : interactable
{
    public GameObject slimey;
    protected override void interact()
    {
        Debug.Log("hi");
        Destroy(gameObject);
    }




}
