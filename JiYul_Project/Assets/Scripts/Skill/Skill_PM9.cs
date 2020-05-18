using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill_PM9 : Skill
{
    public override void ChooseSkill(City city)
    {
        if (city.CityName == "용인시")
        {
            new Skill_Yongin().UseSkill();
        }

    }
    virtual public void UseSkill() { }
}

public class Skill_Yongin : Skill_PM9
{

    public override void UseSkill()
    {

    }
}
