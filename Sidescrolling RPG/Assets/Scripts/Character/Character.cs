using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour {

    //character info
    private string Name;
    private string Race;
    private string Class;

    private bool gender;
    private string title;

    //character stats
    private float currentHealth;
    private float maxHealth;
    private float currentMagic;
    private float maxMagic;
    private float currentStamina;
    private float maxStamina;

    private float Level;
    private float PowerLevel;
    private float Experience;

    private float Brawn;
    private float Vitality;
    private float Reflex;
    private float Wits;
    private float Charm;
    private float Caution;

    //character skills


    //inventory
    private string[] inventory = new string[20];

    //interface
    public Text healthText;
    public Text staminaText;
    public Text magicText;

    public Slider MagicBar;
    public Slider HealthBar;
    public Slider StaminaBar;

    //Tracking
    private static bool spawned = false;

    void Start()
    {
       
       
        sample();
        StartCoroutine(RegenMagic());
        StartCoroutine(RegenHealth());
        StartCoroutine(RegenStamina());
        healthText.text = "" + currentHealth + "/" + maxHealth;
        staminaText.text = "" + currentStamina + "/" +  maxStamina;
        magicText.text = "" + currentMagic + "/" + maxMagic;

        
       


    }

    void Awake()
    {
        if(spawned==false)
        {
            spawned = true;
            gameObject.transform.position = new Vector3(-6, -2, 0);
            DontDestroyOnLoad(this.gameObject);

        } else
        {
            DestroyImmediate(gameObject);

        }





    }

    private void sample()
    {
        Level = 1;
        PowerLevel = 10;

        Name = "TinStarfish";
        title = "Expeditionist";
        Class = "Cavalier";
        Race = "Midern Human";


        Brawn = Random.Range(1, 3);
        Vitality = Random.Range(1, 3);
        Reflex = Random.Range(1, 3);
        Wits = Random.Range(1, 3);
        Charm = Random.Range(1, 3);
        Caution = Random.Range(1, 3);

        maxHealth = (Vitality + (Level * 10));
        currentHealth = maxHealth;
        maxMagic = (Wits + (Level * 10));
        currentMagic = maxMagic;
        maxStamina = (Brawn + (Level * 10));
        currentStamina = maxStamina;

       

    }
	
	
	void Update () {


        UpdateInterface();


        if(currentHealth<=0)
        {
            Die();

        }

       

    }

    void UpdateInterface()
    {
        if(healthText!=null)
        {
            healthText.text = "" + currentHealth + "/" + maxHealth;
            staminaText.text = "" + currentStamina + "/" + maxStamina;
            magicText.text = "" + currentMagic + "/" + maxMagic;

            HealthBar.value = (currentHealth / maxHealth);
            MagicBar.value = (currentMagic / maxMagic);
            StaminaBar.value = (currentStamina / maxStamina);

        }
       

       


    }

    IEnumerator RegenMagic()
    {
        while (true)
        {
            if (currentMagic < maxMagic)
            {
                currentMagic += Wits;
                yield return new WaitForSeconds(1);

            } else
            {
                yield return null;

            }

        }

    }
    IEnumerator RegenHealth()
    {
        while (true)
        {
            if (currentHealth < maxHealth)
            {
                currentHealth += Vitality * Level;
                yield return new WaitForSeconds(1);

            }
            else
            {
                yield return null;

            }

        }

    }

    IEnumerator RegenStamina()
    {
        while (true)
        {
            if (currentStamina < maxStamina)
            {
                currentStamina += Reflex * Level;
                yield return new WaitForSeconds(1);

            }
            else
            {
                yield return null;

            }

        }

    }

    private void Die()
    {
        Application.LoadLevel(Application.loadedLevel);

    }
    public string getRace()
    {
        return Race;
    }

    public string getClass ()
    {
        return Class;
    }

    public float getBrawn()
    {
        return Brawn;
    }
    public float getVitality()
    {
        return Vitality;
    }
    public float getReflex()
    {
        return Reflex;
    }
    public float getWits()
    {
        return Wits;
    }
    public float getCharm()
    {
        return Charm;
    }
    public float getCaution()
    {
        return Caution;
    }
    public string getName()
    {
        return Name;
    }
    public string getTitle()
    {
        return title;

    }
    public float getHealth()
    {
        return currentHealth;
    }
    public void SetHealth(int _health)
    {
        currentHealth -= _health;
    }

    public float getMagic()
    {
        return currentMagic;
    }
    public void SetMagic(float setMagic)
    {
        currentMagic+=setMagic;
    }
    public float getLevel()
    {
        return Level;
    }
    public float getPowerLevel()
    {
        return PowerLevel;
    }
    public void AddHealth(int healthToAdd)
    {
        if(currentHealth+healthToAdd>maxHealth)
        {
            currentHealth = maxHealth;

        } else
        {
            currentHealth += healthToAdd;
        }
      

    }
    public void AddStamina(int staminaToAdd)
    {
        if (currentStamina + staminaToAdd > maxStamina)
        {
            currentStamina = maxStamina;
            
        } else
        {
            currentStamina += staminaToAdd;

        }

    }
    public void AddMagic(int magicToAdd)
    {
        if (currentMagic + magicToAdd > maxMagic)
        {
            currentMagic = maxMagic;

        }
        else
        {
            currentMagic += magicToAdd;
        }

    }

    public void SetName(Text newName)
    {
        Name = newName.text;

    }
    public void SetRace(string newRace)
    {
        Race = newRace;

    }
    public void SetClass(string newClass)
    {
        Class = newClass;

    }

}
