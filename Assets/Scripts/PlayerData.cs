using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PlayerData")]
public class PlayerData : ScriptableObject
{
    public string Name;
    public Sprite sprite;
    public int rarity;
    public bool retired;
    public string team;
    public string position;
}
