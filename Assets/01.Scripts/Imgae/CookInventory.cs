using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CookInventory : MonoBehaviour
{
    [SerializeField] public List<PoolableMono> cookTurtleList = new List<PoolableMono>();
    private List<RectTransform> imagePos = new List<RectTransform>();
    Player player;

    private void Awake() 
    {
        player = GameObject.Find("Player").GetComponent<Player>();

        for(int i = 0; i < transform.childCount - 1; i++)
        {
            imagePos.Add(transform.GetChild(i).GetComponent<RectTransform>());
        }
        
        for(int i = 0; i < cookTurtleList.Count; i++)
        {
            cookTurtleList[i].transform.position = imagePos[i].position;
        }
    }

    public void AddFish(int index, Turtle turtle)
    {
        PoolableMono image = PoolManager.Instance.Pop(turtle.turtleImgae.name);
        image.transform.SetParent(this.transform);
        cookTurtleList.Add(image);

        if(imagePos.Count != 0)
        {
            cookTurtleList[cookTurtleList.Count - 1].transform.position = imagePos[cookTurtleList.Count - 1].position;
        }
    }
}
