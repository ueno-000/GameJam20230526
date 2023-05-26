using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Genertator : MonoBehaviour
{
    [SerializeField, Header("ハチ")]
    GameObject Wasp;
    [SerializeField, Header("栗")]
    GameObject Chestnut;
    [SerializeField, Header("Enemy１")]
    GameObject Enemy１;
    [SerializeField, Header("Enemy２")]
    GameObject Enemy２;
    [SerializeField, Header("Enemy３")]
    GameObject Enemy３;
    [SerializeField, Header("Boss")]
    GameObject Boss;
    [SerializeField, Header("臼")]
    GameObject Usu;

    public int Wasptime;
    public int Chestnuttime;
    public int Enemy１time;
    public int Enemy２time;
    public int Enemy３time;
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
        StartCoroutine(nemy１());
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
            
                // プレハブの位置をランダムで設定
                float x = Random.Range(X1, X2);
                float z = Random.Range(Z1, Z2);
                float y = Random.Range(Y1, Y2);
                Vector3 pos = new Vector3(x, y, z);

                // プレハブを生成
                Instantiate(Wasp, pos, Quaternion.identity);
            
            
        }

    }
    private IEnumerator chestnut()
    {
        while (true)
        {
            yield return new WaitForSeconds(Chestnuttime);

            
                // プレハブの位置をランダムで設定
                float x = Random.Range(X1, X2);
                float z = Random.Range(Z1, Z2);
                float y = Random.Range(Y1, Y2);
                Vector3 pos = new Vector3(x, y, z);

                // プレハブを生成
                Instantiate(Chestnut, pos, Quaternion.identity);
            
        }

    }

    private IEnumerator nemy１()
    {
        while (true)
        {
            yield return new WaitForSeconds(Enemy１time);
            

                // プレハブの位置をランダムで設定
                float x = Random.Range(X1, X2);
                float z = Random.Range(Z1, Z2);
                float y = Random.Range(Y1, Y2);
                Vector3 pos = new Vector3(x, y, z);

                // プレハブを生成
                Instantiate(Enemy１, pos, Quaternion.identity);
            
        }

    }
    private IEnumerator enemy2()
    {
        while (true)
        {
            yield return new WaitForSeconds(Enemy２time);
            

                // プレハブの位置をランダムで設定
                float x = Random.Range(X1, X2);
                float z = Random.Range(Z1, Z2);
                float y = Random.Range(Y1, Y2);
                Vector3 pos = new Vector3(x, y, z);

                // プレハブを生成
                Instantiate(Enemy２, pos, Quaternion.identity);
            
        }

    }
    private IEnumerator Enemy3()
    {
        while (true)
        {
            yield return new WaitForSeconds(Enemy３time);
            
                // プレハブの位置をランダムで設定
                float x = Random.Range(X1, X2);
                float z = Random.Range(Z1, Z2);
                float y = Random.Range(Y1, Y2);
                Vector3 pos = new Vector3(x, y, z);

                // プレハブを生成
                Instantiate(Enemy３, pos, Quaternion.identity);
            
        }

    }
    private IEnumerator usu()
    {
        while (true)
        {
            yield return new WaitForSeconds(Usutime);
            
                // プレハブの位置をランダムで設定
                float x = Random.Range(X1, X2);
                float z = Random.Range(Z1, Z2);
                float y = Random.Range(Y1, Y2);
                Vector3 pos = new Vector3(x, y, z);

                // プレハブを生成
                Instantiate(Usu, pos, Quaternion.identity);
            
        }

    }
    private IEnumerator boss()
    {
        while (true)
        {
            yield return new WaitForSeconds(Bosstime);
            
                // プレハブの位置をランダムで設定
                float x = Random.Range(X1, X2);
                float z = Random.Range(Z1, Z2);
                float y = Random.Range(Y1, Y2);
                Vector3 pos = new Vector3(x, y, z);

                // プレハブを生成
                Instantiate(Boss, pos, Quaternion.identity);
            
        }

    }
}
