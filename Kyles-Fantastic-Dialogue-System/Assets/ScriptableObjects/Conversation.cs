using UnityEngine;
using UnityEngine.UI;

/*
 * Author: Stephen Kyle Muth
 * Date Written: 5/11/2021
 */

[System.Serializable]
public struct Line
{
    public Character character;
    public Side side;

    [TextArea(2, 5)]
    public string text;
}

[CreateAssetMenu(fileName = "New Conversation", menuName = "Conversation")]
public class Conversation : ScriptableObject
{
    public Character[] characters;

    public Line[] lines;
}