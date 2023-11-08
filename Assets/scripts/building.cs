using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class building : MonoBehaviour
{
     public GameObject roomTemplates;
    public int width = 5;
    public int breadth = 5;
    public int height = 3;

    private List<GameObject> roomPool = new List<GameObject>();

    void Start()
    {
        CreateRoomPool();
        GenerateBuilding();
    }

    void CreateRoomPool()
    {
        
            for (int i = 0; i < width * breadth * height; i++)
            {
                GameObject room = Instantiate(roomTemplates);
                room.SetActive(false);
                roomPool.Add(room);
            }
        
    }

    void GenerateBuilding()
    {
        for (int h = 0; h < height; h++)
        {
            for (int x = 0; x < width; x++)
            {
                for (int z = 0; z < breadth; z++)
                {
                    Vector3 position = new Vector3(x * roomTemplates.transform.localScale.x,
                                                  h * roomTemplates.transform.localScale.y,
                                                  z * roomTemplates.transform.localScale.z);
                    int randomIndex = Random.Range(0, roomPool.Count);
                    GameObject room = roomPool[randomIndex];
                    room.SetActive(true);
                    room.transform.position = position;
                    roomPool.RemoveAt(randomIndex);
                }
            }
        }
    }
}
