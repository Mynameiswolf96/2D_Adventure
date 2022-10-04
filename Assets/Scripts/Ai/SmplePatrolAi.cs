public class SmplePatrolAi 
{
    private readonly EnemyView _view;
    private readonly SmplePatrolAiModel _model;
    
    public SmplePatrolAi(EnemyView view, SmplePatrolAiModel model)
    {
        _view = view;
        _model = model;
    }

    public void FixedUpdate()
    {
        _view.Rigidbody.velocity = _model.CalculateVelocity(_view.transform.position);
    }
}
