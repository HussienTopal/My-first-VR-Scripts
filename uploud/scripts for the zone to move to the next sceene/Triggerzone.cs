using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Triggerzone : MonoBehaviour
{
    public string targettag;
    public UnityEvent<GameObject> onevententer;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == targettag)
        {
            onevententer.Invoke(other.gameObject);
        }
    }
}
