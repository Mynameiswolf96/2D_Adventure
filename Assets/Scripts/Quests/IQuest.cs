using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IQuest
{
   event Action<IQuest> Completed;
   bool IsComplete { get; }
   void Reset();  
}
