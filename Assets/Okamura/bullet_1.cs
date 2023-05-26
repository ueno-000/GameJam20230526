using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_1 : MonoBehaviour
{
    Transform _tr;
    Rigidbody2D _rb;
    [SerializeField] GameObject Chased_object;
    public int Bulletspeed1_;
    float ChasedTime;
    [SerializeField] int ChasedTimeLimid;
    [SerializeField] int ResetTime;
    // Start is called  the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _tr = GetComponent<Transform>();

        
    }

    // Update is called once per frame
    void Update()
    {
        ChasedTime += Time.deltaTime;
        if(ChasedTime <= ChasedTimeLimid)
        {
            Vector3 vector3 = Chased_object.transform.position - _tr.position;
            _rb.AddForce(vector3.normalized * Bulletspeed1_);
        }
        //else if(ChasedTime > ResetTime)
        //{
        //    ChasedTime = 0;
        //}

    }
}
