using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.AI;

public abstract class ICharacter
{
    protected ICharacterAttr _attr; //角色属性

    protected GameObject _obj; //角色Obj
    protected NavMeshAgent _navMeshAgent;  //导航网格
    protected AudioSource _audio; //声音

    private IWeapon _weapon; //武器

    protected IWeapon weapon {
        set { _weapon = value; }
    }

    public void Attack(Vector3 targetPosition) //攻击
    {
        if (_weapon != null)
        {
            _weapon.Fire(targetPosition);
        }
        
    }

    protected IAttrStrategy _strategy;

}
