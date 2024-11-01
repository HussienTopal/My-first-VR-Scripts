using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breckable : MonoBehaviour
{

    public List<GameObject> breckablespieceies;

    public float timetobreak = 2;
    public float timer = 0;
    
    void Start()
    {
        foreach (var item in breckablespieceies) 
        {
            item.SetActive(false); 
        }
    }
    public void Break()
    {
        timer += Time.deltaTime;

        if (timer > timetobreak)
        {
            foreach (var item in breckablespieceies)
            {
                item.SetActive(true);
                item.transform.parent = null;
            }
            gameObject.SetActive(false);
        }
    }
}
