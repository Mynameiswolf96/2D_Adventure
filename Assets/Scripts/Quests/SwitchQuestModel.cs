using UnityEngine;

public class SwitchQuestModel : IQuestModel
{
    public bool TryCompleted(GameObject activator)
    {
        return activator.GetComponent<CharacterView>();
    }
}
