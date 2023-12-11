using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSkin : MonoBehaviour
{
    [SerializeField] private List<GameObject> Modely; // Seznam obrázků
    [SerializeField] private string skinName; // Název skinu pro uložení do editoru
    private GameObject targetObject; // Cílový objekt, na kterém chceme mìnit obrázek
    private int currentImageIndex = 0; // Index aktuálního obrázku

    private void Awake()
    {
        // Získáme SpriteRenderer ze stejného objektu, ke kterému je tento skript připojen
        targetObject = GetComponent<GameObject>();

        // Pokud existuje uložený skin pro tento objekt, zobrazíme ho
        if (PlayerPrefs.HasKey(skinName))
        {
            int savedIndex = PlayerPrefs.GetInt(skinName);
            if (savedIndex >= 0 && savedIndex < Modely.Count)
            {
                currentImageIndex = savedIndex;
                targetObject = Modely[currentImageIndex];
            }
        }
    }

    // Metoda pro změnu obrázku
    public void Change(bool forward)
    {
        if (forward)
        {
            currentImageIndex++;
            if (currentImageIndex >= Modely.Count)
            {
                currentImageIndex = 0;
            }
        }
        else
        {
            currentImageIndex--;
            if (currentImageIndex < 0)
            {
                currentImageIndex = Modely.Count - 1;
            }
        }

        targetObject = Modely[currentImageIndex];
        PlayerPrefs.SetInt(skinName, currentImageIndex);
    }
}