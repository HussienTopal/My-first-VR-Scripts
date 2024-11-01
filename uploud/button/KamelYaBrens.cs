using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.Content.Interaction;

public class KamelYaBrens : MonoBehaviour
{
   // public XRLever lever;
    public XRKnob knob;
    public UnityEvent yallabena;

   // public float forwardspeed;
    //public float sidespeed;

    

    void Update()
    {
      //  float forwardvelocity = forwardspeed * (lever.value ? 1 : 0);
        float sidevelocity =  Mathf.Lerp(-1, 1, knob.value);
       if (sidevelocity !=0)
        {
            yallabena.Invoke();
        }
       // Vector3 Velocity = new Vector3(sidevelocity, 0, forwardvelocity);
     //   transform.position += Velocity * Time.deltaTime;
    }
}
