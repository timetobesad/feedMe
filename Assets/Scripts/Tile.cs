using UnityEngine;

public class Tile
{
    private Rect rect;
    private Texture texture;

    public Tile(Rect rect, Texture texture)
    {
        this.rect = rect;
        this.texture = texture;
    }

    public void draw()
    {
        GUI.DrawTexture(rect, texture);
    }
}