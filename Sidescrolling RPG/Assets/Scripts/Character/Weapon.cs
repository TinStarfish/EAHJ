using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    //weapon statistics
    [Header("Weapon Stats")]
    private string name;
    private float fireRate; //if 0, semiautomatic
    private float bulletSpeed;
    private int damage;
    private int magicCost;
    private float lastFired;
    private float reloadSpeed;
    private float projectileSpeed;
    private float timeToFire;

    public AudioSource fireSound;
    

    [Header("Controls")]
    public KeyCode fireButton;

    //tracking
    private bool reloading = false;
    private bool secondaryReady = true;
    public bool isPaused = false;

    //models
    [Header("Models")]
    public Character player;
    public GameObject weapon;
    public Transform firePoint;
    public Rigidbody bullet;
    public LayerMask notToHit;

    public WeaponItem weaponItem;

	void Awake () {
        player = FindObjectOfType<Character>();

        firePoint = transform.Find("FirePoint");
        if(firePoint==null)
        {
            Debug.Log("No Fire Point"); 

        }

        GameObject prefab = Instantiate(weaponItem.weaponModel, weapon.transform.position, weapon.transform.rotation);
        prefab.transform.parent = weapon.transform;
        weapon = weaponItem.weaponModel;


	}

    private void Start()
    {
        if(weaponItem!=null)
        {
            name = weaponItem.name;
            damage = weaponItem.Damage;
            fireRate = weaponItem.Speed;
            magicCost = weaponItem.MagicCost;
            projectileSpeed = weaponItem.projectileSpeed;


        } else
        {
            name = "DEF Rifle";
            damage = 1;
            fireRate = 1;
            magicCost = 1;


        }

    }

    private void Update()
    {
        //Aim();

        if (player.getMagic()<=0 || player.getMagic()<magicCost)
        {
            Debug.Log("Not enough magic.");
            return;

        }

        if(fireRate==0 && !isPaused)
        {
            if(Input.GetKeyDown(fireButton))
            {
                Shoot();

            }

        } else
        {
            if(Input.GetKey(fireButton) && Time.time > timeToFire && !isPaused)
            {
                timeToFire = Time.time + 1 / fireRate;
                Shoot();

            }

        }
       

    }

    private void Shoot()
    {
        if(fireSound!=null)
        {
            fireSound.Play();

        }
           
        Rigidbody bulletInstance;
        bulletInstance = Instantiate(bullet, firePoint.position,firePoint.rotation) as Rigidbody;
        bulletInstance.GetComponent<DoDamage>().SetDamage(damage);
        bulletInstance.transform.localScale = new Vector3(.1f, .1f, .1f);
        bulletInstance.AddForce(firePoint.forward * bulletSpeed);

        player.SetMagic(-magicCost);

    }

    private void Aim()
    {

        var pos = Camera.main.WorldToScreenPoint(transform.position);
        var dir = Input.mousePosition - pos;
        var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);


    }

    public GameObject GetGameObjectComponent()
    {
        return weapon;

    }



}
