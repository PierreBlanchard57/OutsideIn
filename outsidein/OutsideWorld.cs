using Godot;
using System;

public partial class OutsideWorld : Node2D
{
    public const int WORLD_HEIGHT = 20;
    public const int WORLD_WIDTH = 40;
    public const float TILE_SIZE = 16;
    public override void _Ready()
    {
        Camera2D camera = GetNode<Camera2D>("Camera2D");
        Vector2 viewport = GetViewport().GetVisibleRect().Size;
        float widthRatio = viewport.X / (TILE_SIZE * WORLD_WIDTH);
        float heightRatio = viewport.Y / (TILE_SIZE * WORLD_HEIGHT);
        camera.Zoom = new Vector2(widthRatio,heightRatio);
    }
}
