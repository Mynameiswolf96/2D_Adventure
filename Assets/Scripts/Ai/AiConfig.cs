using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[Serializable] 
public struct AiConfig
{
  public float speed;
  public float MinDistanceToTarget;
  public Transform[] WayPoints;
}
