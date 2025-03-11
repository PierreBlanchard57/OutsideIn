using Godot;
using System;

public partial class Utils : Node
{
    public static void scaleTileMapToViewport(int widthTiles,int heightTiles,Viewport viewport,Camera2D camera,TileMapLayer tileMap)
    {
        Vector2 vp = viewport.GetVisibleRect().Size;
        Vector2 tileSize=tileMap.TileSet.TileSize;
        float widthRatio = vp.X / (tileSize.X * widthTiles);
        float heightRatio = vp.Y / (tileSize.Y * heightTiles);
        camera.Zoom = new Vector2(widthRatio, heightRatio);
    }

}
