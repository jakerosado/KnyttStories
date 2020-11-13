using Godot;
using System;

public class SelfDropper : GDKnyttBaseObject
{
    private const int DISTANCE_TO_DROP = 12;
    private const int DROP_SPEED = 200;

    private enum State { Ready, Dropping, Dropped };
    private State state = State.Ready;

    private CollisionShape2D collisionShape;

    public override void _Ready()
    {
        collisionShape = GetNode<CollisionShape2D>("Area2D/CollisionShape2D");
        OrganicEnemy = true;
    }

    public override void _PhysicsProcess(float delta)
    {
        if (state == State.Ready && Mathf.Abs(Juni.ApparentPosition.x - (GlobalPosition.x + 12)) < DISTANCE_TO_DROP)
        {
            state = State.Dropping;
            GetNode<AnimatedSprite>("AnimatedSprite").Play("launch");
            collisionShape.SetDeferred("disabled", false);
        }
        if (state == State.Dropping)
        {
            Translate(new Vector2(0, delta * DROP_SPEED));
        }
    }

    private void _on_Area2D_body_entered(object body)
    {
        if (body is Juni juni) { juni.die(); return; }
        state = State.Dropped;
        collisionShape.SetDeferred("disabled", true);
        GetNode<AudioStreamPlayer2D>("DropPlayer").Play();
    }
}