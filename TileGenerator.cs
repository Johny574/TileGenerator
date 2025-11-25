using UnityEngine;
using UnityEngine.Tilemaps;

public class TileGenerator : MonoBehaviour
{
    [Range(2, 100)]
    [SerializeField] int _noise = 2;

    [SerializeField] Tilemap floormap, tilemap;
    [SerializeField] TileBase _tile;

    public void Generate()
    {
        for (int x = floormap.cellBounds.min.x; x < floormap.cellBounds.max.x; x++)
        {
            for (int y = floormap.cellBounds.min.y; y < floormap.cellBounds.max.y; y++)
            {
                var position = tilemap.WorldToCell(new Vector2(x, y));
                if (floormap.HasTile(position))
                {
                    if (Random.Range(0, _noise) == 0)
                        tilemap.SetTile(position, _tile);
                }
            }
        }
    }

    public void Clear()
    {
        tilemap.ClearAllTiles();
    }
}
