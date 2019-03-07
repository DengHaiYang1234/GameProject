using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class SoldierAtteStrategy : IAttrStrategy
{
    public int GetCritDmg(int critDmg)
    {
        return 0; 
    }

    public int GetDmgDescValue(int lv)
    {
        return (lv - 1)*5;
    }

    public int GetExtraHPValue(int lv)
    {
        return (lv - 1)*10;
    }
}
