using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public int speed;
    public float rotSpeed;
    public float hInput;
    public float vInput;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      hInput = Input.GetAxis("Horizontal"); // left and right movment
      vInput = Input.GetAxis("Vertical"); // forward and backward movment
      
    
      transform.Rotate(Vector3.up, rotSpeed * hInput * Time.deltaTime); // move character left and right rotation
      
      transform.Translate(Vector3.forward * speed * vInput * Time.deltaTime); // move character forward and back
    }
}
