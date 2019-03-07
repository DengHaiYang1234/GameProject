using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public interface IAttrStrategy
{
    int GetExtraHPValue(int lv); // 额外血量

    int GetDmgDescValue(int lv); // 减免伤害

    int GetCritDmg(int critDmg); //暴击伤害



}
