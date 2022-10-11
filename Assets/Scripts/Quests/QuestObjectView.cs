using System;
using UnityEngine;
public class QuestObjectView : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private Color _completedColor;
    [SerializeField] private int _Id;
    public int Id => _Id;
    public Action<CharacterView> OnLevelObjectContact;
    private Color _defaultColor;
    
    private void Awake()
    {
        _defaultColor = _spriteRenderer.color;
    }

    public void ProccesComplete()
    {
        _spriteRenderer.color = _completedColor;
    }

    public void ProcessActivate()
    {
        _spriteRenderer.color = _defaultColor;
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        var levelObject = collider.gameObject.GetComponent<CharacterView>();
        OnLevelObjectContact?.Invoke(levelObject);
    }
}
