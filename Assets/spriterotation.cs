using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spriterotation : MonoBehaviour
{
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(transform.position, player.position);
        if (dist > .2f)
        {
            var playerPos = player.position;
            playerPos.y = transform.position.y;
            transform.LookAt(playerPos);
        }
    }
}
