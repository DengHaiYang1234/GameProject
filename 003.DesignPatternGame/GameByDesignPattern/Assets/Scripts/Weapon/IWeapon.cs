using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public abstract class IWeapon
{
    protected int _atk;

    protected float _atkRange;

    protected int _atkPlusValue;

    protected GameObject _gameObject;

    protected ICharacter _owner;

    protected ParticleSystem _parSystem;

    protected LineRenderer _line;

    protected Light _light;

    protected AudioSource _audio;

    public abstract void Fire(Vector3 targetPosition);
}
