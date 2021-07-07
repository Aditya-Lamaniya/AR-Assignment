using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class Adressablefield : MonoBehaviour
{
    public AssetReference Asset_Reference;
    void Start()
    {
        Asset_Reference.InstantiateAsync();
    }
}
