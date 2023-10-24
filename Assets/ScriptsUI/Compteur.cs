using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Compteur : MonoBehaviour
{
    [SerializeField]
    private TMP_Text compteurChampTexte;

    private int score;

    void Update()
    {
        ScoreUpdate();
    }

    private void ScoreUpdate()
    {
        compteurChampTexte.text = score.ToString();
    }
}
