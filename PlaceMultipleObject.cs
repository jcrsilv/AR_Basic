using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceMultipleObject : MonoBehaviour
{
    private PlaceIndicator placeIndicator;
    public GameObject objectFirst;
    public GameObject objectSecond;
    public GameObject objectThird;

    private GameObject objectToPlace;
    private GameObject checkBeforePlace;
    private GameObject newPlacedObject; 

    void Start()
    {
        placeIndicator = FindObjectOfType<PlaceIndicator>();
    }

    //public void InstantianteObject()
    //{
    //   Instantiate(objectToPlace, placeIndicator.transform.position, placeIndicator.transform.rotation);

    //}

    public void SetObjectToPlace(GameObject objePrefabs)
    {
        objectToPlace = objePrefabs;
    }

    public void ClicktoPlaceFirst()
    {
        SetObjectToPlace(objectFirst);
    }
    public void ClicktoPlaceSecond()
    {
        SetObjectToPlace(objectSecond);
    }
    public void ClicktoPlaceThird()
    {
        SetObjectToPlace(objectThird);
    }
    public void ClickToCheck()
    {
       if(objectToPlace == null) 
        {
            return;
        }
       if (checkBeforePlace != null)
        {
            Destroy(checkBeforePlace);
        }

      checkBeforePlace = Instantiate(objectToPlace, placeIndicator.transform.position, placeIndicator.transform.rotation);    
    }

    public void ClickToPlace()
    {
        if (objectToPlace == null)
        { return; }

        if (checkBeforePlace != null)
        {
            newPlacedObject = checkBeforePlace;
            Instantiate(newPlacedObject, newPlacedObject.transform.position, newPlacedObject.transform.rotation);
            Destroy(checkBeforePlace);
        }
        else
        {
           Instantiate(objectToPlace, placeIndicator.transform.position, placeIndicator.transform.rotation);

        }
    }
}
