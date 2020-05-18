using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill_PM6 : Skill
{
    public override void ChooseSkill(City city)
    {
        if (city.CityName == "부천시")
        {
            new Skill_Buchun().UseSkill();
        }
        else if (city.CityName == "화성시")
        {
            new Skill_Hwasung().UseSkill();
        }

    }
    virtual public void UseSkill() { }
}

public class Skill_Buchun : Skill_PM6
{

    public override void UseSkill()
    {

    }
}

public class Skill_Hwasung : Skill_PM6
{

    public override void UseSkill()
    {

    }
}
