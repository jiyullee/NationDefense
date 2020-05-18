using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class Skill : MonoBehaviour
{
    protected Skill[] skills;

    abstract public void ChooseSkill(City city);

}
