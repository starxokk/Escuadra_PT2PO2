using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class NPCStats : MonoBehaviour
{
    [SerializeField] protected int NPCHealth;
    [SerializeField] protected int NPCAttack;
    [SerializeField] protected int NPCDefense;
    [SerializeField] protected float NPCSpeed;
}