using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterHandler : MonoBehaviour
{
    public float maxHealth, curHealth;
    public float maxStamina, curStamina;
    public float maxMana, curMana;

    public bool dead;

    public int level, maxExp, curExp;

    public GUIStyle healthBarRed;

    public Slider staminaSlider;
	// Use this for initialization
	void Start ()
    {
        maxHealth = 100f;
        curHealth = maxHealth;
        maxStamina = 100f;
        curStamina = maxStamina;
        staminaSlider.maxValue = maxStamina;
        staminaSlider.value = curStamina;
        maxMana = 100f;
        curMana = maxMana;
        maxExp = 60;
	}

    private void Update()
    {
        if (staminaSlider.maxValue != maxStamina)
        {
            staminaSlider.maxValue = maxStamina;
        }
        if (staminaSlider.value != curStamina)
        {
            staminaSlider.value = curStamina;
        }
    }


    // Update is called once per frame
    void LateUpdate ()
    {
	    if(curHealth > maxHealth)
        {
            curHealth = maxHealth;
        }
        if(curHealth <= 0 && !dead)
        {
            curHealth = 0;
            dead = true;
        }
        else if(curHealth < 0)
        {
            curHealth = 0;
        }
        //STAMINA
        if(curStamina > maxStamina)
        {
            curStamina = maxStamina;
        }
        if(curStamina < 0)
        {
            curStamina = 0;
        }
        //MANA
        if(curMana > maxMana)
        {
            curMana = maxMana;
        }
        if(curMana < 0)
        {
            curMana = 0;
        }
	}

    private void OnGUI()
    {
        float scrW = Screen.width / 16;
        float scrH = Screen.height / 9;

        GUI.Box(new Rect(6f * scrW, scrH, 4 * scrW, 0.5f * scrH), "");
        GUI.Box(new Rect(6f * scrW, scrH, curHealth * (4 * scrW) / maxHealth, 0.5f * scrH), "", healthBarRed); //Health

    }
}
