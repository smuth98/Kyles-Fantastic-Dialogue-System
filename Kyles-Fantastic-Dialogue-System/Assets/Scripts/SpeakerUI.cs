using UnityEngine;
using UnityEngine.UI;

/*
 * Author: Stephen Kyle Muth
 * Date Written: 5/11/2021
 */

public class SpeakerUI : MonoBehaviour
{
    public Image portrait;
    public Text fullName;
    public Text dialogue;

    private Character speaker;
    public Character Speaker
    {
        get { return speaker; }
        set {
            speaker = value;
            portrait.sprite = speaker.portrait;
            fullName.text = speaker.fullName;
        }
    }
    
    public string Dialogue
    {
        set { dialogue.text = value; }
    }

    public bool HasSpeaker()
    {
        return speaker != null;
    }

    public bool SpeakerIs(Character character)
    {
        return speaker == character;
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }
}
