using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class shatterSkull : MonoBehaviour
{

    public Animator animator;

    private bool state = false;

    public TextMeshPro contentText;

    private string[] content = new string[2]
    {
        "EXPAND",
        "JOIN"
    };


    public void disLocate()
    {
        if (!state)
        {
            shatter();

        }
        else
        {
            Combine();
        }

       
    }

    private void shatter()
    {
        state = true;
        contentText.text = content[1];

        animator.SetBool("isShatter", true);
        animator.SetBool("isJoin", false);


    }


    private void Combine()
    {
        state = false;
        contentText.text = content[0];

        animator.SetBool("isJoin", true);
        animator.SetBool("isShatter", false);
    }




    /*
    // Start is called before the first frame update
    [Header("Distance Count Apart")]
    [Range(1f, 20f)]
    public float distanceRange = 2.5f;

    public TextMeshPro contentName;
    public string[] buttonNames = new string[2] { "SHATTER", "COMBINE" };
    public bool isShatter = false;

    
    public List<GameObject> forwardPositive = new List<GameObject>();
    private List<Vector3> fpPosition = new List<Vector3>();


    public List<GameObject> forwardNegative = new List<GameObject>();
    private List<Vector3> fnPosition = new List<Vector3>();


    public List<GameObject> down = new List<GameObject>();
    private List<Vector3> downPosition = new List<Vector3>();

    public List<GameObject> right = new List<GameObject>();
    private List<Vector3> rightPosition = new List<Vector3>();


    public List<GameObject> left = new List<GameObject>();
    private List<Vector3> leftPosition = new List<Vector3>();


    public void toggleName()
    {
        if (isShatter)
        {
            contentName.text = buttonNames[1];
        }
        else
        {
            contentName.text = buttonNames[0];
        }
    }


    public void storeOldpositions()
   {
        sectionPositions(fpPosition, forwardPositive);
        sectionPositions(fnPosition, forwardNegative);
        sectionPositions(downPosition, down);
        sectionPositions(rightPosition, right);
        sectionPositions(leftPosition, left);
   }


    public void restoreOldPositions()
    {
        restoreSectionPositions(fpPosition, forwardPositive);
        restoreSectionPositions(fnPosition, forwardNegative);
        restoreSectionPositions(downPosition, down);
        restoreSectionPositions(leftPosition, left);
        restoreSectionPositions(rightPosition, right);    
        
        isShatter = false;
        toggleName();
    }
   

    public void shatter()
   {
        storeOldpositions();

        moveforward(forwardPositive);
        moveBackWard(forwardNegative);
        moveRight(right);
        moveLeft(left);
        moveDown(down);

        isShatter = true;
        toggleName();
    
   }

    private void moveforward(List<GameObject> dataObjects)
    {
        foreach(GameObject go in dataObjects)
        {
            go.transform.position = new Vector3(go.transform.position.x + distanceRange, go.transform.position.y, go.transform.position.z);
        }
    }

    private void moveBackWard(List<GameObject> dataObjects)
    {
        foreach(GameObject go in dataObjects)
        {
            go.transform.position = new Vector3(go.transform.position.x - distanceRange, go.transform.position.y, go.transform.position.z);
        }
    }

    private void moveRight(List<GameObject> dataObjects)
    {
        foreach(GameObject go in dataObjects)
        {
            go.transform.position = new Vector3(go.transform.position.x, go.transform.position.y, go.transform.position.z + distanceRange);
        }
    }

    private void moveLeft(List<GameObject> dataObjects)
    {
        foreach(GameObject go in dataObjects)
        {
            go.transform.position = new Vector3(go.transform.position.x, go.transform.position.y, go.transform.position.z - distanceRange);
        }
    }

    private void moveDown(List<GameObject> dataObjects)
    {
        foreach(GameObject go in dataObjects)
        {
            go.transform.position = new Vector3(go.transform.position.x, go.transform.position.y - distanceRange, go.transform.position.z);
        }
    }




    private void sectionPositions(List<Vector3> dataPositions, List<GameObject> dataObjects)
    {
        for (int i = 0; i < dataObjects.Count; i++)
        {
            dataPositions[i] = dataObjects[i].transform.position;
        }
    }

    private void restoreSectionPositions(List<Vector3> dataPositions, List<GameObject> dataObjects)
    {
        for (int i = 0; i < dataObjects.Count; i++)
        {
            dataObjects[i].transform.position = dataPositions[i];
        }
    }
    */
}
