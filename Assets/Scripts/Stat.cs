﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stat : MonoBehaviour
{
    public Game game;
    public Ship ship;

    public Text starsText;
    public Text highScoreText;

    public Text shipText;
    public Image shipModelImage;
    public Text shipHitpoints;
    public Text shipDamage;
    public Text shipFireRate;
    public Text shipFirePower;

    void Awake ()
    {
        // Get current ship
        ship = game.ships [Storage.ship].GetComponent<Ship> ();
    }

    void OnEnable ()
    {
        // Set vars
        starsText.text = Storage.stars.ToString ();
        highScoreText.text = Storage.highScore.ToString ();

        // Set ship vars
        shipText.text = ship.GetComponentInChildren<SpriteRenderer> ().sprite.name;
        shipModelImage.sprite = ship.GetComponentInChildren<SpriteRenderer> ().sprite;
        shipHitpoints.text = ship.GetComponent<Hitpoint> ().maxHitpoints.ToString ();
        shipDamage.text = ship.fireDamage.ToString ();
        shipFireRate.text = ship.fireRate.ToString ();
        shipFirePower.text = ship.firePower.ToString ();
    }
}
