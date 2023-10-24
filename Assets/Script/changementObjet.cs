using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changementObjet : MonoBehaviour
{

    public Material matObjet; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Chaudron"))
        {
            Renderer rend = GetComponent<Renderer>(); 
            if (rend != null)
            {
                rend.material = matObjet; // Change le matériau pour matObjet
            }
            //Augmenter compteur ici
        }
    }

}
