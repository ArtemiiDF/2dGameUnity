using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded : MonoBehaviour
{

    [SerializeField] private PlayerMovement Player;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("Jump allowed");
        Player.IsGrounded = true;
    }

    private void OnTriggerExit2D()
    {
        
            Debug.Log("Jump NOT allowed");
            Player.IsGrounded = false;
        
    }
}
