using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamage
{
    void Damage(float damage);//interfaceのメソッド定義
}

public interface IItim
{
    void HP(float Hp);//interfaceのメソッド定義

    void Speed(float spe);
}

