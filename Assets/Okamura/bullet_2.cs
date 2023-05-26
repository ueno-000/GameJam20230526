using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_2 : MonoBehaviour
{
    AudioSource b_audio;
    Rigidbody2D _rb;
    Transform _tr;
    [SerializeField] GameObject ChildBulletleft;
    [SerializeField] GameObject ChildBulletright;
    [SerializeField] float BulletSpeed;
    float ProceedTime;
    [SerializeField] int BurstTime;
    [SerializeField] GameObject b_effect;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _tr = GetComponent<Transform>();
        b_audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0, Time.deltaTime * BulletSpeed);
        ProceedTime += Time.deltaTime;
        if(ProceedTime == BurstTime)
        {
            Instantiate(b_effect);
            Instantiate(ChildBulletleft, transform.position, transform.rotation);
            Instantiate(ChildBulletright, transform.position, transform.rotation);
            Destroy(this);

        }
    }
}
