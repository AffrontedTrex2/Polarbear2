using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Health : MonoBehaviour
{
    public int startingHealth = 5;
    public int currentHealth;
    public Sprite[] heartsLeft;
    public Image HeartUI;

    void Start()
    {
        currentHealth = startingHealth;
        HeartUI.sprite = heartsLeft[currentHealth];
        Debug.Log(currentHealth);
    }


    void Update()
    {

    }


    public void ChangeHealth(int amount)
    {
        currentHealth = 5;
        currentHealth += amount;
        Debug.Log(currentHealth);
        HeartUI.sprite = heartsLeft[4];
    }
}