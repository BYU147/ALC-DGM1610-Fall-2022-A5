using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{

    public int scoreToGive = 100; // Score give for popped balloon.
    
    public int clickToPop = 3; //How many clicks before balloon pops.
    
    public float scaleToIncrease = 0.10f; // Scale increase each time the balloon is clicked.
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    void OnMouseDown()
    {
        // Reduce clicks by one
        clickToPop -= 1;
        
        // Increase balloon volume
        transform.localScale += Vector3.one * scaleToIncrease;
        
        if(clickToPop == 0)
       {
        
            Destroy(gameObject);
        }
    }

    
}
