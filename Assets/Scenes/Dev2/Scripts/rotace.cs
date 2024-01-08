using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotace : MonoBehaviour
{
    [SerializeField]
    float zivoty;
    [SerializeField]
    int sila;
    [SerializeField]
    Transform headTransform;

    [SerializeField]
    Transform legTransform;

    [SerializeField]
    Transform bodyTransform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Toc(bodyTransform, false);
        Toc(legTransform, true);
        Toc(headTransform, true);



    }
    private void Toc(Transform tf,bool pravo)
    {
        if(pravo)
        tf.Rotate(0f, zivoty * sila,0f );
        if(!pravo)
        tf.Rotate(0f, -zivoty * sila,0f);

    }
}
