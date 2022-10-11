using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "QuestItemsConfig",menuName = "Quest/QuestItem")]
public class QuestItemsConfig : ScriptableObject
{
   [SerializeField] private int _questId;
   [SerializeField] public List<int> _questItemIdCollection;
   public int QuestId => _questId;
   public List<int> QuestItemIdCollection => _questItemIdCollection;
}
