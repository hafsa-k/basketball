using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class netPassingTrough : MonoBehaviour
{
   
    public bool win = false; // Cette variable indique si le joueur a gagné ou non.

    private bool hitTop = false; // Cette variable indique si la balle a touché Collider_top.
    private bool hitBottom = false; // Cette variable indique si la balle a touché Collider_bottom.
    public OpenDoor openDoorScript;
    



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collider_top"))
        {
            // Si la balle touche d'abord Collider_top, définissez hitTop sur true.
            hitTop = true;

            // Si la balle a déjà touché Collider_bottom, le joueur gagne.
            if (hitBottom)
            {
                win = false;
                hitBottom = false;
                hitTop = false;
                Debug.Log("LOSER");
                
            }
        }
        else if (other.CompareTag("Collider_bottom"))
        {
            hitBottom = true;
            if(hitTop){
                win = true;
                hitBottom = false;
                hitTop = false;
                Debug.Log("WINNER");
                OpenDoor();
                
           } 
            
        }
    }
     private void OpenDoor()
    {
            if (win)
            {
                Debug.Log("sesame ouvre-toi");

                //INVOKE = ADD DELAY ANIMATION BUT DONT ACCEPT POINT
               Invoke("DoAnimation", 2f);
            }
            else
            {
                Debug.Log("desolé yasmine, ya pas de moula");
            }
        }

    void DoAnimation() {
        openDoorScript.AnimationDoorOpen();
    }


}
