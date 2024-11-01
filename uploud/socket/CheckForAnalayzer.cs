using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CheckForAnalayzer : MonoBehaviour
{
      public int i = 0;

    public UnityEvent electricity_done;




public void checkForAnalayzer()
    {
        i++;
        if (i >=2)
        {
            electricity_done.Invoke();
        }

    }
    
}
