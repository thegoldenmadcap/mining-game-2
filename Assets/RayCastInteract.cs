using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RayCastInteract : MonoBehaviour
{
    public Camera FPScam;
    private float distance = 1f;
    public GameObject player;
    [Serialize]
    public LayerMask mask;
    private playerUI playerUI;

    private void Start()
    {
        playerUI = player.GetComponent<playerUI>();
    }
    void Update()
    {
        playerUI.UpdateText(string.Empty);
        Vector3 rayorigin = FPScam.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hit;
        if (Physics.Raycast(rayorigin, FPScam.transform.forward, out hit, distance, mask))
        {
            if (hit.collider.GetComponent<interactable>() != null) 
            {
                playerUI = player.GetComponent<playerUI>();
                interactable inter = hit.collider.GetComponent<interactable>();
                playerUI.UpdateText(inter.promptMessage);
                if (Input.GetKeyDown(KeyCode.E)) 
                {
                    
                    inter.baseinteract();
                    
                }
            }

        }


    }

}
