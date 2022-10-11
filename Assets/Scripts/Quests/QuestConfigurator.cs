using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestConfigurator : MonoBehaviour
{
  [SerializeField] private QuestObjectView _singleQuestObjectView;
  private Quest _singleQuest;
  private void Start()
  {
    _singleQuest = new Quest(_singleQuestObjectView, new SwitchQuestModel());
    _singleQuest.Reset();
  }
  private void OnDestroy()
  {
    _singleQuest.Dispose();
  }
}
