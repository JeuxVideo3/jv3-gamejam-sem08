using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objetDansChaudron : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Objet-Chaudron"))
        {
            // Action quand un objet avec la layer "Objet-Chaudron" rentre dans le chaudron
        }
    }

}