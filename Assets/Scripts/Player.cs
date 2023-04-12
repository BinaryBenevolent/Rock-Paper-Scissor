using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;


public class Player : MonoBehaviour
{
    [Header("Character Selected")]
    [SerializeField] private Character selectedCharacter;

    [Header("List of Characters")]
    [SerializeField] private List<Character> characterList;

    [Header("Attacking Position Reference")]
    [SerializeField] Transform attackReference;

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

    public void Attack()
    {
        selectedCharacter.transform
            .DOMove(attackReference.position, 1f);
    }

    public bool IsAttacking()
    {
        return DOTween.IsTweening(selectedCharacter.transform);
    }
}
