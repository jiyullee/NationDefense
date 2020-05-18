using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill_PM4 : Skill
{
    public override void ChooseSkill(City city)
    {
        if (city.CityName == "천안시")
        {
            new Skill_Uijeongbu().UseSkill();
        }
        else if (city.CityName == "안산시")
        {
            new Skill_Gimpo().UseSkill();
        }

    }
    virtual public void UseSkill() { }
}

public class Skill_Cheonan : Skill_PM4
{

    public override void UseSkill()
    {

    }
}

public class Skill_Ansan : Skill_PM4
{

    public override void UseSkill()
    {

    }
}

