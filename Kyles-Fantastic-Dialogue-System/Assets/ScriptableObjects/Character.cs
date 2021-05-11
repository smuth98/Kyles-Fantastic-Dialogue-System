using UnityEngine;

/*
 * Author: Stephen Kyle Muth
 * Date Written: 5/11/2021
 */

[CreateAssetMenu(fileName = "New Character", menuName = "Character")]
public class Character : ScriptableObject
{
    public string fullName;
    public Sprite portrait;
}
