using UnityEngine;
using UnityEngine.UI;
using System;

public class SkinManager : MonoBehaviour
{
    public GameObject[] skins; // Array to hold different skin prefabs
    public int currentSkinIndex = 0;

    void Start()
    {
        // Initially, set the first skin as active
        SetActiveSkin(currentSkinIndex);
        ZmenSkin();
    }

    public void ChangeSkin()
    {
        // Disable the current skin
        SetActiveSkin(currentSkinIndex, false);

        // Move to the next skin
        currentSkinIndex = (currentSkinIndex + 1) % skins.Length;

        // Enable the new skin
        SetActiveSkin(currentSkinIndex, true);
    }

    private void SetActiveSkin(int index, bool active = true)
    {
        // Set the specified skin prefab as active or inactive
        if (index >= 0 && index < skins.Length)
        {
            skins[index].SetActive(active);
        }
    }
    public void ZmenSkin()
    {
        currentSkinIndex = (currentSkinIndex + 1) % skins.Length;
    }
}
