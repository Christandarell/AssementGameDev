using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TreeHealth : MonoBehaviour
{
    public int health;
    public int maxHealth = 50;
    public Slider slider;
    public Sprite[] TreeSprites;
    public SpriteRenderer treeSr;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        slider.maxValue = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = health;
        if(health <= 0)
        {
            Destroy(gameObject);
            Destroy(slider.gameObject);
        }
        else
        {
            float healthPercentage = (float)health / maxHealth;
            int spriteIndex = Mathf.Clamp(Mathf.FloorToInt(healthPercentage * TreeSprites.Length -1), 0, TreeSprites.Length -1);
            treeSr.sprite = TreeSprites[spriteIndex];

        }
    }
}
