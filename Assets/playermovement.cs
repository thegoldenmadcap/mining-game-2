using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Rigidbody rb;
    public float p_Speed = 1000f;
    public float p_Jump = 1f;
    public float m_Sensitivity;
    public bool grounded;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        p_Speed = 4f;
        m_Sensitivity = 2.0f;
        p_Jump  = 4f;
        grounded = false;
    }

    void Update()
    {
        transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X")*m_Sensitivity,0 ));

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * p_Speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S)) 
        {
            transform.position += -transform.forward * p_Speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D)) 
        {
            transform.position += transform.right * p_Speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A)) 
        {
            transform.position += -transform.right * p_Speed * Time.deltaTime;        
        }
        if (Input.GetKey(KeyCode.Space)&& grounded == true) 
        {
            rb.velocity = new Vector3(0, p_Jump, 0);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        grounded = !grounded;
    }
    private void OnCollisionExit(Collision collision) 
    {
        grounded = !grounded;  
    }
}
