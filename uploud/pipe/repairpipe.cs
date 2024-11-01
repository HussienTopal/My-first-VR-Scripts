using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;

public class repairpipe : MonoBehaviour
{
   // public List<GameObject> breckablespieceies;
    public Animator animator;
    public string boolname = "open";


    public UnityEvent repairCoplete;

    public float timetobreak = 2;
    public float timer = 0;

    void Start()
    {
        animator = GetComponent<Animator>();

      
    }
    public void yalaaaah()
    {
        Invoke("Break", 290f);
    }
    public void Break()
    {

        bool isopen = animator.GetBool(boolname);
        animator.SetBool(boolname, !isopen);
        
    }
}
