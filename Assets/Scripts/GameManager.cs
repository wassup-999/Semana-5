using JetBrains.Annotations;
using UnityEngine;

public class GameManager:MonoBehaviour
{
    public Slime Slime1 = new(10);
    public Slime Slime2 = new(10);
    void Start()
    {
        
        Slime Slime3 =Slime1 + Slime2;
        
    }

    public void Update()
    {
        Status();
    }
    public void Status()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Slime Slime3 = Slime1 + Slime2;
            Debug.Log("El slime 1 y slime 2 se fucionan y obtiene la vida del Slime " + Slime3.life);
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log("Slime 1 tiene"+ Slime1.life);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Debug.Log("Slime 2 tiene"+Slime2.life);
        }
    }

}
