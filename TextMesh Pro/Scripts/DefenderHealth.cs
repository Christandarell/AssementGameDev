using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DefenderHealth : MonoBehaviour
{
    public int health;
    public int maxHealth = 50;
    public float delayTime =.15f;
    public Gun gun;
    public GameObject popUpDamagePrefab;
    public TMP_Text popUpText;
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    public void TakeDamage(int damage)
    {
        health -= damage;
        popUpText.text = damage.ToString();
        Instantiate(popUpDamagePrefab, transform.position, Quaternion.identity);
        StartCoroutine(knockbackDelay());
    }
    IEnumerator knockbackDelay()
    {
        gun.enabled = false;
        yield return new WaitForSeconds(delayTime);
        if(health <= 0 )
        {
            Destroy(gameObject);

        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            gun.enabled = true;
        }
    }
}
