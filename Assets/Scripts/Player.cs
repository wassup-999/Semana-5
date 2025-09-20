using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int life = 100;
    [SerializeField] private float probabilidad;
    void Start()
    {
        probabilidad=Random.Range(5,10);
        GetDamage(Random.Range(50, 80), true || false);
    }

    void Update()
    {
        RecieveDamage();
    }

    public void RecieveDamage()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetDamage(20);
        }
    }
    public void GetDamage(int damagebasic)
    {
        Debug.Log("El Player solo recibio daño_"+damagebasic+"!!");
        damagebasic = 20;
        life-=damagebasic;
        Death();
    }
    public void GetDamage(int damagecritical , bool knocback = true || false)
    {      
        damagecritical = Random.Range(50, 80);
        if (probabilidad >= 7)
        {
            life -= damagecritical;
            Debug.Log("El Player recibio daño critico_"+ damagecritical + "_más knocback_" + knocback);
            knocback = true;
            life -= 20;
            Death();
        }
        else
        {
            life -= damagecritical;
            Debug.Log("El Player solo recibio daño critico_" +damagecritical +"!!" );
            knocback = false;
        }            
    }
    public void Death()
    {
        if(life < 0)
        {
            Destroy(gameObject);
            Debug.Log("El player c mamut X_X");
        }
    }
}