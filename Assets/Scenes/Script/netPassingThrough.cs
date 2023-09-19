using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class netPassingTrough : MonoBehaviour
{
    public bool win = false; // Cette variable indique si le joueur a gagné ou non.

    private bool hitTop = false; // Cette variable indique si la balle a touché Collider_top.
    private bool hitBottom = false; // Cette variable indique si la balle a touché Collider_bottom.

    // Cette fonction est appelée lorsque la balle entre en collision avec un autre objet.
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
                Debug.Log("Perdu");
                hitBottom = false;
                hitTop = false;
            }
        }
        else if (other.CompareTag("Collider_bottom"))
        {
            hitBottom = true;
            if(hitTop){
                win = true;
                Debug.Log("Win !");
                hitBottom = false;
                hitTop = false;
           } // Si la balle touche d'abord Collider_bottom, définissez hitBottom sur true.
            
        }
    }
}
