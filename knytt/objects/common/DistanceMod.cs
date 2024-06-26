using Godot;

public class DistanceMod : Node2D
{
    enum DistanceMethod { Distance, ManhattanDistance, DistanceByX };

    [Export] float openDistance = 0;
    [Export] float closeDistance = 0;
    [Export] DistanceMethod method = DistanceMethod.Distance;
    [Export] NodePath spritePath = null;
    [Export] public string openAnimation = "open";

    [Signal] public delegate void EnterEvent();
    [Signal] public delegate void ExitEvent();

    protected AnimatedSprite sprite;

    protected GDKnyttBaseObject parent;
    protected Juni globalJuni;
    public bool IsEntered { get; protected set; } = false;


    public override void _Ready()
    {
        parent = GetParent<GDKnyttBaseObject>();
        globalJuni = parent.Juni;
        sprite = spritePath != null ? GetNode<AnimatedSprite>(spritePath) : null;
    }

    public override void _PhysicsProcess(float delta)
    {
        if (globalJuni.dead) { return; }

        var distance =
            method == DistanceMethod.Distance ? globalJuni.distance(GlobalPosition) :
            method == DistanceMethod.ManhattanDistance ? globalJuni.manhattanDistance(GlobalPosition) :
                Mathf.Abs(GlobalPosition.x - globalJuni.ApparentPosition.x);

        if (!IsEntered && distance < openDistance) { updateSpikes(show: true); }
        if (IsEntered && distance > closeDistance) { updateSpikes(show: false); }
    }

    protected virtual void updateSpikes(bool show)
    {
        IsEntered = show;
        EmitSignal(show ? nameof(EnterEvent) : nameof(ExitEvent));
        sprite?.Play(openAnimation, backwards: !show);
    }
}
