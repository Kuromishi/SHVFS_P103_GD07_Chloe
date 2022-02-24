using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AttackableComponent : MonoBehaviour
{
    public AttackGUIDComponent AttackGUIDComponent;
    public Guid GUID => AttackGUIDComponent.ID;

}
