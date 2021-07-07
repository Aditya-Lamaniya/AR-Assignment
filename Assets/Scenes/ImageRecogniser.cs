using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.ARFoundation;

public class ImageRecogniser : MonoBehaviour
{
    private ARTrackedImageManager Imagetracker;

    void Awake()
    {
        Imagetracker = FindObjectOfType<ARTrackedImageManager>();
    }

    public void OnEnable()
    {
        Imagetracker.trackedImagesChanged += OnImageChange;
    }

    public void OnDisable()
    {
        Imagetracker.trackedImagesChanged -= OnImageChange;
    }

    public void OnImageChange(ARTrackedImagesChangedEventArgs args)
    {
        foreach(var trackedimage in args.added)
        {
            Debug.Log(trackedimage.name);
        }
    }

}
