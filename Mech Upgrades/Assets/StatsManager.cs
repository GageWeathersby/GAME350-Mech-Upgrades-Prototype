using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class StatsManager : MonoBehaviour
{
    public static StatsManager Instance;

    [Header("Stats")]
    public int health;
    public int healthMin;
    public int damage;
    public int damageMin;
    public int armor;
    public int armorMin;
    public int speed;
    public int speedMin;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

}

