using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grow : MonoBehaviour
{

    public Vector3 nSize;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale += nSize;
    }
}
