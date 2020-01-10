using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/AgentProperties", order = 1)]
public class AgentProperties : ScriptableObject
{
    public float MovementSpeed;
    public float AttackSpeed;
    public float Health;
    public float Stamina;

}
