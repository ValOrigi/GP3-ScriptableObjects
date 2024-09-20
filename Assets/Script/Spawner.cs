using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class Spawner : MonoBehaviour
{
/*
    [SerializeField] private EnemyTypes enemyTypes;

    void Start()
    {
        GameObject newEnemy = Instantiate(enemyTypes.enemyPrefab);
        EnemyStats stats = newEnemy.GetComponent<EnemyStats>();
        stats.physicalDamage = enemyTypes.physicalDamage;
        stats.magicalDamage = enemyTypes.magicalDamage;
        stats.health = enemyTypes.health;
        stats.armor = enemyTypes.armor;
        stats.magicResistance = enemyTypes.magicResistance;
        stats.speed = enemyTypes.speed;

        newEnemy.transform.position = enemyTypes.position;
    }
*/

    [SerializeField] List<EnemyTypes> enemyTypes = new List<EnemyTypes>();
    int count = 0;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && count < 4)
        {
            GameObject newEnemy = Instantiate(enemyTypes[count].enemyPrefab);
            EnemyStats stats = newEnemy.GetComponent<EnemyStats>();
            stats.attackPower = enemyTypes[count].attackPower;
            stats.defense = enemyTypes[count].defense;
            stats.health = enemyTypes[count].health;
            stats.speed = enemyTypes[count].speed;
            newEnemy.transform.position = enemyTypes[count].position;
            count++;
        }

        if(Input.GetKeyDown(KeyCode.Backspace))
        {
            count = 0;

            GameObject[] gos = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject go in gos)
                Destroy(go);
        }

    }
}