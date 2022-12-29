using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardButton : MonoBehaviour
{
    string assetBundleFilePath = "Assets/AssetBundles/buttons/pressed";
    string assetBundleFilePath2 = "Assets/AssetBundles/cards/8";
    string pressedButton = "pressed";
    string card = "8";
    //public Sprite newSprite;
    private void Start()
    {

    }
    private void OnMouseDown()
    {
        // Load the AssetBundle from the specified file path
        AssetBundle assetBundle = AssetBundle.LoadFromFile(assetBundleFilePath);

        // Load the sprite image from the AssetBundle using the asset name
        Sprite newSprite = assetBundle.LoadAsset<Sprite>(pressedButton);

        // Get the SpriteRenderer component of the game object
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();

        // Set the sprite image that you want to use
        spriteRenderer.sprite = newSprite;



        GameObject card1 = GameObject.Find("card1");

        // Get the SpriteRenderer component of the game object
        spriteRenderer = card1.GetComponent<SpriteRenderer>();

        assetBundle = AssetBundle.LoadFromFile(assetBundleFilePath2);

        newSprite = assetBundle.LoadAsset<Sprite>(card);

        // Set the sprite image that you want to use
        spriteRenderer.sprite = newSprite;

    }





}
