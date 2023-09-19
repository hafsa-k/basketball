using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
     private void Start(){
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    public void AnimationDoorOpen()
    {
        animator.SetBool("OpenDoor", true);
    }
    
}
