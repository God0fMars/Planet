using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerControl : MonoBehaviour
{
    GameManagerModel model;
    private void Awake()
    {
        model = GetComponent<GameManagerModel>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TouchedFlower()
    {
        model.flowersTouched++;
        Debug.Log(model.flowers.transform.childCount);
        if (model.flowers.transform.childCount <= model.flowersTouched)
        {
            GoToEnd();
        }
    }
    public void GoToEnd()
    {
        Debug.Log("End");
        model.conversationManager.SetActive(true);
        model.conversationUI.SetActive(true);
    }
}
