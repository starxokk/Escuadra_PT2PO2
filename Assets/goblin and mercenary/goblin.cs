using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : NPCStats
{
    [SerializeField] private Archer archer;

    public void Start()
    {
        Debug.Log("Goblin Health: " + NPCHealth);
        Debug.Log("Archer Attacks Goblin: " + archer.Attack);
        NPCHealth -= archer.Attack;
        Debug.Log("Goblin Health: " + NPCHealth);
    }

}
