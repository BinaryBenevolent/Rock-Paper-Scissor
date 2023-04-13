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
    [SerializeField] private int attackPower;
    [SerializeField] private TMP_Text overHeadText;
    [SerializeField] private Image avatar;
    [SerializeField] private TMP_Text nameText;
    [SerializeField] private TMP_Text typeText;
    [SerializeField] private Image healthBar;
    [SerializeField] private TMP_Text hpText;
    [SerializeField] private Button button;

    public Button Button { get => button; }
    public CharacterType Type { get => type; }
    public int AttackPower { get => attackPower; }
    public int CurrentHp { get => currentHp; }

    private void Start()
    {
        overHeadText.text = name;
        nameText.text = name;
        typeText.text = Type.ToString();
        UpdateHpUi();
        button.interactable = false;
    }

    public void ChangeHP(int amount)
    {
        currentHp += amount;
        currentHp = Mathf.Clamp(currentHp, 0, maxHp);

        UpdateHpUi();
    }

    private void UpdateHpUi()
    {
        healthBar.fillAmount = (float)currentHp / maxHp;
        hpText.text = CurrentHp + "/" + maxHp;
    }
}
