using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class boost : MonoBehaviour
{
    public static UnityEvent<GameObject> boostEvent;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other != null)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                boostEvent.Invoke(other.gameObject);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    
}
