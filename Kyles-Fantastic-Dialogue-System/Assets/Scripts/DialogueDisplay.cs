using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

/*
 * Author: Stephen Kyle Muth
 * Date Written: 5/11/2021
 */

public class DialogueDisplay : MonoBehaviour
{
    public Conversation conversation;

    private int activeLineIndex = 0;

    public GameObject speaker;
    private SpeakerUI speakerUI;

    void Start()
    {
        speakerUI = speaker.GetComponent<SpeakerUI>();

        speakerUI.Hide();

    }

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            AdvanceConversation();
        }
    }

    void AdvanceConversation()
    {
        if (activeLineIndex < conversation.lines.Length)
        {
            DisplayLine();
            activeLineIndex += 1;
        }
        else
        {
            speakerUI.Hide();
            activeLineIndex = 0;
        }
    }

    void DisplayLine()
    {
        Line line = conversation.lines[activeLineIndex];
        Character character = line.character;
        bool isValid = true;

        if (!character)
        {
            Debug.Log("There is no character selected for line " + (activeLineIndex + 1).ToString());
            isValid = false;
        }
        else
        {
            if (character.fullName == "")
            {
                Debug.Log("Character at Line " + (activeLineIndex + 1).ToString() + " has no name.");
                isValid = false;
            }
            if (character.portrait == null)
            {
                Debug.Log("Character at Line " + (activeLineIndex + 1).ToString() + " has no portrait selected.");
                isValid = false;
            }
        }
        if (!isValid) return;

        SetDialogue(speakerUI, line.text);
        SetName(speakerUI, character.fullName);
        SetPortrait(speakerUI, character.portrait);
        SetSide(speakerUI, line.side);

        speakerUI.Show();
    }

    //this is where i need to put the Side flags
    void SetDialogue(
        SpeakerUI activeSpeakerUI,
        string text
        ) {
        activeSpeakerUI.Dialogue = text;
    }

    void SetName(
        SpeakerUI activeSpeakerUI,
        string name
        ) {
        activeSpeakerUI.fullName.text = name;
    }

    void SetPortrait(
        SpeakerUI activeSpeakerUI,
        Sprite curSprite
        ) {
        activeSpeakerUI.portrait.sprite = curSprite;
    }

    void SetSide(
        SpeakerUI activeSpeakerUI,
        Side curSide
        )
    {
        if (curSide.side == "Left")
        {
            ScaleImage(activeSpeakerUI.portrait, 1);
        }
        else if (curSide.side == "Right")
        {
            ScaleImage(activeSpeakerUI.portrait, -1);
        }
        else Debug.Log("Unknown side assigned assigned to current line.\n" +
            "Add paramaters for a new Side.");
    }

    void ScaleImage(
        Image curImage,
        int x
        ) {
        curImage.transform.localScale = new Vector3(x, 1, 1);
    }
}
