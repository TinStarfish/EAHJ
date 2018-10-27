using UnityEngine;
using UnityEngine.AI;


public class Enemy : MonoBehaviour {

    public string name;
    public int maxHealth;
    public int currentHealth;

    public int damage = 2;

    public Item droppedLoot;
    public int droppedGold;

    public float lookRadius = 5;

    Transform target;

    public TextMesh healthBar;

    public GameObject lootChest;


    public Camera cam;
    public Rigidbody bullet;
    public NavMeshAgent agent;

    public 

	void Start () {
        target = GameObject.Find("EthanBody").transform;
        agent = GetComponent<NavMeshAgent>();
        healthBar.text = currentHealth + "/" + maxHealth;
	}

    void Update()
    {

        target = GameObject.Find("EthanBody").transform;
        float distance = Vector3.Distance(target.position, transform.position);
        if (distance <= lookRadius)
        {
            agent.SetDestination(target.position);
            if(distance <= agent.stoppingDistance)
            {
                Rigidbody bulletInstance;
                bulletInstance = Instantiate(bullet, target.position, target.rotation) as Rigidbody;
                bulletInstance.GetComponent<DoDamage>().SetDamage(damage);
                bulletInstance.transform.localScale = new Vector3(.1f, .1f, .1f);
                bulletInstance.AddForce(target.forward * 100);

            }


        }
        if(currentHealth==maxHealth)
        {
            healthBar.color = Color.green;

        }
        if(currentHealth<=Mathf.Round(maxHealth/2))
        {
            healthBar.color = Color.yellow;
        }
        if(currentHealth<=(maxHealth - (maxHealth-1)))
        {
            healthBar.color = Color.red;
        }

        if(currentHealth<=0)
        {
            Die();

        }
        healthBar.text = currentHealth + "/" + maxHealth;



    }

    public void Die()
    {
        if(lootChest!=null)
            Instantiate(lootChest, transform.position, lootChest.transform.rotation);
        Destroy(gameObject);

    }

    void FaceTarget()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5);

    }

    public void setCurrentHealth(int damage)
    {
        currentHealth -= damage;

    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            currentHealth -= collision.gameObject.GetComponent<DoDamage>().GetDamage();
            Destroy(collision.gameObject);

        }
        if(collision.gameObject.tag=="Player")
        {
            Character player = collision.gameObject.GetComponent<Character>();
            player.SetHealth(damage);

        }
    }

    private void RangedAttack()
    {
      

    }

}
