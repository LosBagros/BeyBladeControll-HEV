using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro.EditorUtilities;
using UnityEngine;

public class fallen : MonoBehaviour
{
    [SerializeField] 
    private string fallenName;

    [SerializeField]
    private TMP_Text text;

    private void Start()
    {
        text.enabled = false;

    }

    private void Update()
    {
        if (transform.position.y < -1)
        {
            text.text = fallenName + " vyhrál";
            text.enabled = true;
        }
    }
}
