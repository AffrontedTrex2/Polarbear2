using UnityEngine;
using UnityEngine.UI;
using System.Collections;



public class Health : MonoBehaviour
{

    public static int startingHealth = 3;
    public static int currentHealth;
    public Transform[] heartsLeft;

    void Start()
    {
        currentHealth = startingHealth;
        for (int i = 0; i < currentHealth; i++)
        {
            heartsLeft[i].GetComponent<Renderer>().enabled = true;
        }
    }


    void Update()
    {

    }


    public void ChangeHealth(int amount)
    {
        currentHealth += amount;

        for (int i = startingHealth; i > currentHealth; i--)
        {
            heartsLeft[i - 1].GetComponent<Renderer>().enabled = false;
        }
    }
}