using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class metiotPistol : MonoBehaviour
{

    public ParticleSystem particals;

    public LayerMask layermask;
    public Transform shootSource;
    public float distance = 10f;

    private bool rayActivate = false;


    void Start()
    {
        XRGrabInteractable grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.activated.AddListener(x => startshoot());
        grabInteractable.deactivated.AddListener(x => stopshoot());
    }


    public void startshoot()
    {
        particals.Play();
        rayActivate = true;
    }
    public void stopshoot()
    {
        particals.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
        rayActivate = false;

    }
    // Update is called once per frame
    void Update()
    {
        if (rayActivate)
        {
                    Raycastcheak();

        }
    }

    void Raycastcheak()
    {
        RaycastHit hit;
        bool hasHit = Physics.Raycast(shootSource.position, shootSource.forward, out hit, distance, layermask);
        if (hasHit)
        {
            hit.transform.gameObject.SendMessage("Break", SendMessageOptions.DontRequireReceiver);
        }
    }
}
