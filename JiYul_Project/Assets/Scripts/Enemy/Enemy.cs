using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class Enemy : MonoBehaviour
{
    [SerializeField] protected int damage;
    abstract public void SelectDisaster();
}
