using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Quest : IQuest,IDisposable
{
    private readonly QuestObjectView _view;
    private readonly IQuestModel _model;
    public bool IsComplete { get; private set; }
    public event Action<IQuest> Completed;
    private bool _active;

    public Quest(QuestObjectView view, IQuestModel model)
    {
        _view = view;
        _model = model;
    }

    private void Complete()
    {
        if (!_active)
            return;
        _active = false;
        IsComplete = true;
        _view.OnLevelObjectContact -= OnContact;
        _view.ProccesComplete();
        OnCompleted();
    }

    private void OnCompleted()
    {
        Completed?.Invoke(this);
    }

    public void Reset()
    {
        if (_active)
            return;
        _active = true;
        IsComplete = false;
        _view.OnLevelObjectContact += OnContact;
        _view.ProcessActivate();
    }

    private void OnContact(CharacterView characterview)
    {
        var completed = _model.TryCompleted(characterview.gameObject);
        if(completed) 
            Complete();
    }

    public void Dispose()
    {
        _view.OnLevelObjectContact -= OnContact;
    }
}
