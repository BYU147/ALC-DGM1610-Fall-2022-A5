using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AnimationController : MonoBehaviour
{
    
    public Animator animSpeed;
    public Animation anim;
    
    // Start is called before the first frame update
    void Start()
    {
        animSpeed = GetComponent<Animator>();
        anim = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
            PlayAnim();
        
        if(Input.GetKeyDown(KeyCode.E))
            StopAnim();
    }
    
    void PlayAnim()
    {
        animSpeed.speed = 1f;
        Debug.Log("Animation is Playing");
    }
    
    void StopAnim()
    {
        animSpeed.speed = 0f;
        Debug.Log("Animation is paused");
    }
    
    
    public void PushPlay()
    {
        anim.Play();
    }
    
    public void PushStop()
    {
        anim.Stop();
    }
}
