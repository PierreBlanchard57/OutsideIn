using Godot;
using System;

public partial class Player : CharacterBody2D
{
    private const float GRAVITY = 700;
    private const float PLAYER_SPEED = 300;
    private const float JUMP_FORCE = 1500;
    private const int JUMP_DELTAS = 30;

    private float currentJumpForce = 0;

    public override void _PhysicsProcess(double delta)
    {
        Vector2 movement = new Vector2(0, 0);
        if (Input.IsActionPressed("move_left")) movement.X -= PLAYER_SPEED;
        if (Input.IsActionPressed("move_right")) movement.X += PLAYER_SPEED;
        if (Input.IsActionJustPressed("jump") && currentJumpForce==0)
        {
            currentJumpForce = JUMP_FORCE;
        }
        //add jump
        movement.Y -= currentJumpForce;
        if (currentJumpForce > 0) currentJumpForce -= JUMP_FORCE / JUMP_DELTAS;
        //add gravity
        movement.Y += GRAVITY;
        Velocity = movement;
        MoveAndSlide();
    }
}
