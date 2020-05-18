using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill_AM9 : Skill
{
    public override void ChooseSkill(City city)
    {
        if (city.CityName == "군포시")
        {
            new Skill_GunPo().UseSkill();
        }
        else if (city.CityName == "군산시")
        {
            new Skill_GunSan().UseSkill();
        }
        else if (city.CityName == "하남시")
        {
            new Skill_Hanam().UseSkill();
        }
    }
    virtual public void UseSkill() { }
}

public class Skill_GunPo : Skill_AM9
{

    public override void UseSkill()
    {

    }
}

public class Skill_GunSan : Skill_AM9
{

    public override void UseSkill()
    {

    }
}

public class Skill_Hanam : Skill_AM9
{

    public override void UseSkill()
    {

    }
}
