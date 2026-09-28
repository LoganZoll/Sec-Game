using Godot;
using System;

public partial class Player : CharacterBody2D
{
    public const float Speed = 300.0f;

    public override void _PhysicsProcess(double delta)
    {
        Vector2 direction = Input.GetVector("MoveLeft", "MoveRight", "MoveUp", "MoveDown");

        Velocity = direction * Speed;

        MoveAndSlide();
    }
}
