using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class playsteps : MonoBehaviour
{

    PlayableDirector director;
    public List<step> steps;

    void Start()
    {
        director = GetComponent<PlayableDirector>();
    }
      
    [System.Serializable]
    public class step
    {
        public string name;
        public float time;
        public bool hasplayed = false;  

    }

    public void playstepindex(int index)
    {
        step step = steps[index];
        if(!step.hasplayed)
        {
            step.hasplayed = true;


            director.Stop();
            director.time = step.time;
            director.Play();


        }
    }
    
}
