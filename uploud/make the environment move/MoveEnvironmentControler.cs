using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Content.Interaction;

public class MoveEnvironmentControler : MonoBehaviour
{

    public XRLever lever;
    public XRKnob knob;

    public float forwardspeed;
    public float sidespeed;

    void Start()
    {
        
    }

    void Update()
    {
        float forwardvelocity = forwardspeed * (lever.value ? 1 : 0);
        float sidevelocity = sidespeed * (lever.value ? 1 : 0) * Mathf.Lerp(-1, 1, knob.value);

        Vector3 Velocity = new Vector3(sidevelocity, 0, forwardvelocity);
        transform.position += Velocity * Time.deltaTime;
    }
}
