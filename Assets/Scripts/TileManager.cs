using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    public int sizeGrid = 8;
    public float sizeTile;

    public List<Tile> tiles;

    public Texture[] imageTiles;

    public Vector2 offsTileOnScreen;

    private void Start()
    {
        tiles = new List<Tile>();

        for (int i = 0; i < sizeGrid; i++)
            for (int j = 0; j < sizeGrid; j++)
                tiles.Add(createNewTile(i, j));
    }

    private void OnGUI()
    {
        if (tiles.Count > 0)
        {
            foreach (Tile tile in tiles)
                tile.draw();
        }
    }

    private Tile createNewTile(int x, int y)
    {
        Rect rect = new Rect(offsTileOnScreen.x + (x * sizeTile), offsTileOnScreen.y + (y * sizeTile), sizeTile, sizeTile);

        return new Tile(rect, imageTiles[Random.Range(0, imageTiles.Length)]);
    }
}
