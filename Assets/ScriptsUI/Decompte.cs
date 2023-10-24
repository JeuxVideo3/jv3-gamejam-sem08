using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Decompte : MonoBehaviour
{
    [SerializeField]
    private InfosNiveau infosNiveau;

    private bool decompteActif = false;

    public UnityEvent changementTemps;
    public UnityEvent finTemps;
    
    void Start()
    {
        DemarrerDecompte();
    }

    void Update()
    {
        DecompteDescendant();
    }

    private void DecompteDescendant()
    {
        if (decompteActif)
        {
            if (infosNiveau.temps > 0)
            {
                infosNiveau.temps -= Time.deltaTime;
                changementTemps.Invoke();
            }
            else
            {
                infosNiveau.temps = 0;
                decompteActif = false;
                finTemps.Invoke();
            }
        }
    }

    public void DemarrerDecompte()
    {
        infosNiveau.temps = infosNiveau.tempsInitial;
        decompteActif = true;
    }
}
