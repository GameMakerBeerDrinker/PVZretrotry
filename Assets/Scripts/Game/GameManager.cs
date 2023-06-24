using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum WhichPlant
{
    NoPlant,
    Peashooter,
    Sunflower
}

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;

    public int row=5;
    public int column=9;

    private Tile tile;
    private Cell[,] field;

    public WhichPlant pickedUpPlant;
    public int sun;

    public Plant peashooter;
    public Plant sunflower;

    private void Awake()
    {
        if (gameManager == null)
            gameManager = this;
        tile = GetComponentInChildren<Tile>();
        
    }

    private void Start()
    {
        
        NewGame();
    }

    private void Update()
    {
        Grow();
        //Debug.Log(pickedUpPlant);
    }

    private void NewGame()
    {
        sun = 50;
        pickedUpPlant = WhichPlant.NoPlant;
        field = new Cell[column, row];

        for (int x = 0; x < column; x++) 
        {
            for(int y=0;y<row;y++)
            {
                Cell cell = new Cell();
                cell.position = new Vector2Int(x, y);
                cell.type = Cell.Type.Grass;
                field[x, y] = cell;
            }
        }

        //Camera.main.transform.position = new Vector3(row / 2f, column / 2f, -10f);
    }

    private void Grow()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3Int cellPosition = tile.tilemap.WorldToCell(worldPosition);
            //Debug.Log(cellPosition);
            Cell cell = GetCell(cellPosition.x, cellPosition.y);

            if(cell.type==Cell.Type.Invalid||cell.plant!=WhichPlant.NoPlant)
            {
                return;
            }

            switch(pickedUpPlant)
            {
                case WhichPlant.Peashooter:
                    PutPlant(peashooter, cellPosition);
                    Debug.Log("ÖÖÖ²Íã¶¹ÉäÊÖ");
                    break;

                case WhichPlant.Sunflower:
                    PutPlant(sunflower, cellPosition);
                    break;
            }
        }
    }

    private void PutPlant(Plant plant,Vector3Int cellPosition)
    {
        Instantiate(plant, tile.tilemap.CellToWorld(cellPosition) + new Vector3(0.3f, 0.3f, 0), Quaternion.Euler(0, 0, 0));
        sun -= plant.cost;
        pickedUpPlant = WhichPlant.NoPlant;
    }

    private Cell GetCell(int x,int y)
    {
        if(Isvalid(x,y))
        {
            return field[x, y];
        }
        else
        {
            return new Cell();
        }
    }

    private bool Isvalid(int x,int y)
    {
        return x >= 0 && x < column && y >= 0 && y < row;
    }

    public void GetSun(int value)
    {
        sun += value;
        Debug.Log(sun);
    }
}
