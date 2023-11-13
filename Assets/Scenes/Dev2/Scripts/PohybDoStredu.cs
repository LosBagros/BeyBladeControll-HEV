using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PohybDoStredu : MonoBehaviour
{
    public Vector3 cilovaPozice; // Urèení cílové pozice

    public float rychlost = 5f; // Základní rychlost pohybu hráèe
    public float silaFaktor = 2f; // Faktor síly v závislosti na vzdálenosti

    void Update()
    {
        PohybKeCilovePozici();
    }

    void PohybKeCilovePozici()
    {
        Vector3 smer = cilovaPozice - transform.position;
        float vzdalenost = smer.magnitude; // Vzdálenost mezi hráèem a cílovým bodem

        // Normalizace vektoru pro zachování smìru, ale s délkou 1, a použití síly v závislosti na vzdálenosti
        smer.Normalize();
        float sila = Mathf.Clamp01(silaFaktor / vzdalenost); // Omezíme sílu na interval [0, 1]
        transform.Translate(smer * rychlost * sila * Time.deltaTime, Space.World);
    }
}
