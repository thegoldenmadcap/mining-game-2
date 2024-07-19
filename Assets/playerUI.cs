using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class playerUI : MonoBehaviour
{

    public TextMeshProUGUI promptText;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    public void UpdateText(string promptMessage)
    {
        promptText.text = promptMessage;
    }
}
