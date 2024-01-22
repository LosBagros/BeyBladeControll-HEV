using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialFade : MonoBehaviour
{
    public float transitionDuration = 1.0f;
    private new Renderer renderer;
    private Color startColor;
    private Color endColor;
    private float transitionTimer;

    void Start()
    {
        renderer = GetComponent<Renderer>();
        SetRandomColor();
    }

    void Update()
    {
        transitionTimer += Time.deltaTime;

        renderer.material.color = Color.Lerp(startColor, endColor, transitionTimer / transitionDuration);

        if (transitionTimer >= transitionDuration)
        {
            transitionTimer = 0f;
            startColor = renderer.material.color;
            SetRandomColor();
        }
    }

    void SetRandomColor()
    {
        endColor = new Color(Random.value, Random.value, Random.value);
    }
}