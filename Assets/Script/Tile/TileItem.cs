using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileItem : MonoBehaviour
{
    private string ID;
    private bool notNull = false;
    public string id {
        get{
            return this.ID;
        }
    }
    public void setID(string id)
    {
        if (this.notNull)
        {
            Debug.LogWarning("ID is set!!. You cannot to set again");
            return;
        }
        this.ID = id;
        this.notNull = true;
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }




}
