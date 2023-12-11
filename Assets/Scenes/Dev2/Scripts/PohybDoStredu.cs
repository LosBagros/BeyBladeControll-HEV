using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PohybDoStredu : MonoBehaviour
{
    [SerializeField]
    private Vector3 cilovaPozice; // Urèení cílové pozice
    
    [SerializeField]
    private float rychlost = 3f; // Základní rychlost pohybu hráèe
    
    [SerializeField]
    private float silaFaktor = 1f; // Faktor síly v závislosti na vzdálenosti

    void Update()
    {
        PohybKeCilovePozici();
    }

    void PohybKeCilovePozici()
    {
        Vector3 smer = cilovaPozice - transform.position;
        float vzdalenost = smer.magnitude; // Vzdálenost mezi hráèem a cílovým bodem
        if (vzdalenost > 1)
        {
            // Normalizace vektoru pro zachování smìru, ale s délkou 1, a použití síly v závislosti na vzdálenosti
            smer.Normalize();
            float sila = Mathf.Clamp01(silaFaktor / vzdalenost / 2); // Omezíme sílu na interval [0, 1]
            transform.Translate(smer * rychlost * sila * Time.deltaTime, Space.World);

        }
       
       
    }
}
