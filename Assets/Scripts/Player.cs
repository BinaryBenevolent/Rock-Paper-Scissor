using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Character Selected")]
    [SerializeField] private Character selectedCharacter;

    [Header("List of Characters")]
    [SerializeField] private List<Character> characterList;

    public Character SelectedCharacter { get => selectedCharacter; }

    public void Prepare()
    {
        selectedCharacter = null;
    }

    public void SelectCharacter(Character character)
    {
        selectedCharacter = character;
    }

    public void SetPlay(bool value)
    {
        foreach(var character in characterList)
        {
            character.Button.interactable = value;
        }
    }
}
