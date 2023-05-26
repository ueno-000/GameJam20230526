using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Genertator : MonoBehaviour
{
    [SerializeField, Header("�n�`")]
    GameObject Wasp;
    [SerializeField, Header("�I")]
    GameObject Chestnut;
    [SerializeField, Header("Enemy�P")]
    GameObject Enemy�P;
    [SerializeField, Header("Enemy�Q")]
    GameObject Enemy�Q;
    [SerializeField, Header("Enemy�R")]
    GameObject Enemy�R;
    [SerializeField, Header("Boss")]
    GameObject Boss;
    [SerializeField, Header("�P")]
    GameObject Usu;

    public int Wasptime;
    public int Chestnuttime;
    public int Enemy�Ptime;
    public int Enemy�Qtime;
    public int Enemy�Rtime;
    public int Bosstime;
    public int Usutime;


    public float X1;
    public float X2;
    public float Y1;
    public float Y2;
    public float Z1;
    public float Z2;

    public bool Not = false;

    public float a;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(wasp());
        StartCoroutine(chestnut());
        StartCoroutine(nemy�P());
        StartCoroutine(enemy2());
        StartCoroutine(Enemy3());
        StartCoroutine(usu());
    }

    // Update is called once per frame
    void Update()
    {
        a += Time.deltaTime;
        if ( a < 100)
        {
            Not = true;
        }
    }
    private IEnumerator wasp()
    {
        while (true)
        {
            yield return new WaitForSeconds(Wasptime);
            
                // �v���n�u�̈ʒu�������_���Őݒ�
                float x = Random.Range(X1, X2);
                float z = Random.Range(Z1, Z2);
                float y = Random.Range(Y1, Y2);
                Vector3 pos = new Vector3(x, y, z);

                // �v���n�u�𐶐�
                Instantiate(Wasp, pos, Quaternion.identity);
            
            
        }

    }
    private IEnumerator chestnut()
    {
        while (true)
        {
            yield return new WaitForSeconds(Chestnuttime);

            
                // �v���n�u�̈ʒu�������_���Őݒ�
                float x = Random.Range(X1, X2);
                float z = Random.Range(Z1, Z2);
                float y = Random.Range(Y1, Y2);
                Vector3 pos = new Vector3(x, y, z);

                // �v���n�u�𐶐�
                Instantiate(Chestnut, pos, Quaternion.identity);
            
        }

    }

    private IEnumerator nemy�P()
    {
        while (true)
        {
            yield return new WaitForSeconds(Enemy�Ptime);
            

                // �v���n�u�̈ʒu�������_���Őݒ�
                float x = Random.Range(X1, X2);
                float z = Random.Range(Z1, Z2);
                float y = Random.Range(Y1, Y2);
                Vector3 pos = new Vector3(x, y, z);

                // �v���n�u�𐶐�
                Instantiate(Enemy�P, pos, Quaternion.identity);
            
        }

    }
    private IEnumerator enemy2()
    {
        while (true)
        {
            yield return new WaitForSeconds(Enemy�Qtime);
            

                // �v���n�u�̈ʒu�������_���Őݒ�
                float x = Random.Range(X1, X2);
                float z = Random.Range(Z1, Z2);
                float y = Random.Range(Y1, Y2);
                Vector3 pos = new Vector3(x, y, z);

                // �v���n�u�𐶐�
                Instantiate(Enemy�Q, pos, Quaternion.identity);
            
        }

    }
    private IEnumerator Enemy3()
    {
        while (true)
        {
            yield return new WaitForSeconds(Enemy�Rtime);
            
                // �v���n�u�̈ʒu�������_���Őݒ�
                float x = Random.Range(X1, X2);
                float z = Random.Range(Z1, Z2);
                float y = Random.Range(Y1, Y2);
                Vector3 pos = new Vector3(x, y, z);

                // �v���n�u�𐶐�
                Instantiate(Enemy�R, pos, Quaternion.identity);
            
        }

    }
    private IEnumerator usu()
    {
        while (true)
        {
            yield return new WaitForSeconds(Usutime);
            
                // �v���n�u�̈ʒu�������_���Őݒ�
                float x = Random.Range(X1, X2);
                float z = Random.Range(Z1, Z2);
                float y = Random.Range(Y1, Y2);
                Vector3 pos = new Vector3(x, y, z);

                // �v���n�u�𐶐�
                Instantiate(Usu, pos, Quaternion.identity);
            
        }

    }
    private IEnumerator boss()
    {
        while (true)
        {
            yield return new WaitForSeconds(Bosstime);
            
                // �v���n�u�̈ʒu�������_���Őݒ�
                float x = Random.Range(X1, X2);
                float z = Random.Range(Z1, Z2);
                float y = Random.Range(Y1, Y2);
                Vector3 pos = new Vector3(x, y, z);

                // �v���n�u�𐶐�
                Instantiate(Boss, pos, Quaternion.identity);
            
        }

    }
}
