using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class EnemyAttrStrategy : IAttrStrategy
{
    public int GetCritDmg(int critDmg)
    {
        if (UnityEngine.Random.Range(0, 1f) < critDmg)
        { 
            return (int)(10 * UnityEngine.Random.Range(0.5f, 1f));
        }

        return 0;
    }

    public int GetDmgDescValue(int lv)
    {
        return 0;
    }

    public int GetExtraHPValue(int lv)
    {
        return 0;
    }
}
