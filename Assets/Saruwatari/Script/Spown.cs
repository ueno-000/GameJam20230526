using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spown : MonoBehaviour
{
    public float a;
    public float b;

    [SerializeField] GameObject Boss;
    [SerializeField] GameObject Kara;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        a += Time.deltaTime;
        if ( a > b)
        {
            Instantiate(Boss,Kara.transform.position,Kara.transform.rotation);
        }
    }
}
