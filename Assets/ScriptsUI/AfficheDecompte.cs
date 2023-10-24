using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using TMPro;

public class AfficheDecompte : MonoBehaviour
{
    [SerializeField]
    private InfosNiveau infosNiveau;

    [SerializeField]
    private TMP_Text champTexteTemps;

    public void AfficheTemps()
    {
        float temps = infosNiveau.temps;

        if (temps < 0)
        {
            temps = 0;
        }

        TimeSpan ts = TimeSpan.FromSeconds(temps);

        champTexteTemps.text = string.Format("{0:00}:{1:00}:{2:000}", ts.Minutes, ts.Seconds, ts.Milliseconds);
    }
}
