using UnityEngine;

public class Slime 
{
    public int life = 10;
    public Slime(int _life)
    {
       life = _life;
    }

    public static Slime operator +(Slime slime1 , Slime slime2 )
    {
        return new Slime(slime1.life + slime2.life);
    }
}
