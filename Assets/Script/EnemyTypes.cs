using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Enemy Type", menuName = "Enemy Type")]

public class EnemyTypes : ScriptableObject
{
    [Header("Enemy Model")]
    public GameObject enemyPrefab;
    
    [Header("Enemy Stats")]
    public string enemyName;
    public int attackPower;
    public int defense;
    public int health;
    public int speed;

    [Header("Enemy Position")]
    public Vector3 position;
}
