
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    int cardValue;
    char suit;
    string assetBundleFilePath = "Assets/AssetBundles/cardsall/";
    string card;
    // Start is called before the first frame update 
    void Start()
    {
        cardValue = Random.Range(7, 15);
        changeCard();

    }

    // Update is called once per frame
    void Update()
    {
    }


    private void changeCard()
    {
        //switch (cardValue)
        //{
        //    case 7:
        //        cardValue = 7;
        //        break;
        //    case 8:
        //        cardValue = 8;
        //        break;
        //    case 9:
        //        cardValue = 9;
        //        break;
        //    case 10:
        //        cardValue = 10;
        //        break;
        //    case 11:
        //        cardValue = 11;
        //        break;
        //    case 12:
        //        cardValue = 12;
        //        break;
        //    case 13:
        //        cardValue = 13;
        //        break;
        //    case 14:
        //        cardValue = 14;
        //        break;
        //}
        Debug.Log(cardValue);
        suit = 'C';
        card = suit.ToString();
        card = suit + cardValue.ToString();
        //assetBundleFilePath = assetBundleFilePath + suit + card;
        AssetBundle assetBundle = AssetBundle.LoadFromFile(assetBundleFilePath);

        // Load the sprite image from the AssetBundle using the asset name
        Sprite newSprite = assetBundle.LoadAsset<Sprite>(card);

        // Get the SpriteRenderer component of the game object
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();

        // Set the sprite image that you want to use
        spriteRenderer.sprite = newSprite;
    }


}
