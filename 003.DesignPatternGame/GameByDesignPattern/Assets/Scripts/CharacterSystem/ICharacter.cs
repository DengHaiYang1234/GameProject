using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.AI;

public abstract class ICharacter
{
    protected ICharacterAttr _attr;

    protected GameObject _obj;
    protected NavMeshAgent _navMeshAgent;
    protected AudioSource _audio;

}
