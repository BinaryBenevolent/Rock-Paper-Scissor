using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour
{
    [SerializeField] private new string name;
    [SerializeField] private CharacterType type;
    [SerializeField] private int currentHp;
    [SerializeField] private int maxHp;
    [SerializeField] private int attack;
    [SerializeField] private TMP_Text overHeadText;
    [SerializeField] private Image avatar;
    [SerializeField] private TMP_Text nameText;
    [SerializeField] private TMP_Text typeText;
    [SerializeField] private Image healthBar;
    [SerializeField] private TMP_Text hpText;
    [SerializeField] private Button button;

    public Button Button { get => button; }

    private void Start()
    {
        overHeadText.text = name;
        nameText.text = name;
        typeText.text = type.ToString();
        healthBar.fillAmount = (float) currentHp/maxHp;
        hpText.text = currentHp + "/" + maxHp;
        button.interactable = false;
    }
}
