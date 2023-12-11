using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PohybDoStredu : MonoBehaviour
{
    [SerializeField]
    private Vector3 cilovaPozice; // Ur�en� c�lov� pozice
    
    [SerializeField]
    private float rychlost = 3f; // Z�kladn� rychlost pohybu hr��e
    
    [SerializeField]
    private float silaFaktor = 1f; // Faktor s�ly v z�vislosti na vzd�lenosti

    void Update()
    {
        PohybKeCilovePozici();
    }

    void PohybKeCilovePozici()
    {
        Vector3 smer = cilovaPozice - transform.position;
        float vzdalenost = smer.magnitude; // Vzd�lenost mezi hr��em a c�lov�m bodem
        if (vzdalenost > 1)
        {
            // Normalizace vektoru pro zachov�n� sm�ru, ale s d�lkou 1, a pou�it� s�ly v z�vislosti na vzd�lenosti
            smer.Normalize();
            float sila = Mathf.Clamp01(silaFaktor / vzdalenost / 2); // Omez�me s�lu na interval [0, 1]
            transform.Translate(smer * rychlost * sila * Time.deltaTime, Space.World);

        }
       
       
    }
}
